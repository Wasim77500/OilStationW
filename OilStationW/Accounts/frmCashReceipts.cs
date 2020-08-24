using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmCashReceipts : OilStationW.myForm
    {
        bool bLoad = false;
        string strCasherAccId = "";
        public frmCashReceipts()
        {
            InitializeComponent();
        }

        private void frmCashReceipts_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
            strCasherAccId = txtAccNo.Text.Trim();
            if (strCasherAccId == null || strCasherAccId == "")
            {
                glb_function.MsgBox("لايوجد صندوق محدد لهذا النموذج");
                this.Close();
            }
            PrepareForm();
        }
        private void FillData()
        {
            bLoad = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtAcc = cnn.GetDataTable("SELECT pkid,acc_no,acc_name " +
                       " FROM accounts " +
                       " where level = 5 and stat='فعال' order by acc_no");

            lstAccNo.DataSource = dtAcc.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAcc.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";

            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            bLoad = false;
        }
        private void PrepareForm()
        {
            FillData();
            txtCreditTotal.Text = "0";
            txtCreditTotal.BackColor = Color.LawnGreen;
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnUpdate.Enabled = false;
            btnPrint.Enabled = false;

            for (int i = 0; i < 10; i++)
            {
                dgvJourDetails.Rows.Add();
            }



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindJournal frm = new frmFindJournal();
            frm.strWhere = " and trans_name='سند قبض' and h.stat='فعال' and branch_id=" + glb_function.glb_strBranchPkid + " ";
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }

        private void GetData(string strPkid)
        {

            btnNew_Click(null, null);
            dgvJourDetails.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtJournalData = cnn.GetDataTable("SELECT h.Pkid, h.stat, Branch_id, jour_no, trans_name, trans_id, date_format(jour_date,'%d/%m/%Y') jour_date, jour_note,Person,trans_no, " +
                          "  d.pkid dpkid, d.stat dstat, curr_id,(select c.curr_name from currency c where c.pkid=d.curr_id) curr_name, acc_id, main_value, jour_value, exchange_Rate, jour_details,profitCenter, " +
                           " a.acc_no, a.acc_name " +
                          "  FROM journal_header h " +
                          "  join journal_details d " +
                          " join accounts a on(a.pkid = d.acc_id) " +
                          "  on(h.pkid = d.header_id) " +
                          "  where h.pkid =  " + strPkid + " order by d.pkid");
            bLoad = true;

            txtPkid.Text = strPkid;

            txtJourNo.Text = dtJournalData.Rows[0]["trans_no"].ToString();
            dtpJourDate.Value = DateTime.ParseExact(dtJournalData.Rows[0]["jour_date"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txtHeaderNote.Text = dtJournalData.Rows[0]["jour_note"].ToString();
            txtPerson.Text = dtJournalData.Rows[0]["Person"].ToString();
            txtCreditTotal.Text = "0";
            for (int i = 0; i < dtJournalData.Rows.Count; i++)
            {

               
                if (Convert.ToDouble(dtJournalData.Rows[i]["main_value"].ToString()) < 0)
                {
                    dgvJourDetails.Rows.Add();
                    dgvJourDetails[clmCredit.Index,dgvJourDetails.Rows.Count -1].Value   = (Convert.ToDecimal(dtJournalData.Rows[i]["main_value"].ToString()) * -1).ToString();


                }
                else
                    continue;





                dgvJourDetails[clmPKid.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["dpkid"].ToString();



                dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["acc_id"].ToString();
                dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["acc_no"].ToString();
                dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["acc_name"].ToString();

                dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["jour_details"].ToString();
                dgvJourDetails[clmProfitCenter.Index, dgvJourDetails.Rows.Count - 1].Value = dtJournalData.Rows[i]["profitCenter"].ToString();

                



                txtCreditTotal.Text = (Convert.ToDecimal(txtCreditTotal.Text.Trim()) + Convert.ToDecimal(dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value)).ToString("###,###,###,##0.##");

                //Test git hub
            }






            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            if (UserTemplate.HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;

            btnSave.Enabled = false;
            bLoad = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;

                dgvJourDetails[Convert.ToUInt16(nmbEditor.W_ColumnName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString("###,###,###,##0.##");


                GetTotal();
            }
        }
        private void GetTotal()
        {
            
            double dCreditTotal = 0;

            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index, i].Value != null && dgvJourDetails[clmAccId.Index, i].Value.ToString() != "")
                {
                   
                    double dCredit = Convert.ToDouble(dgvJourDetails[clmCredit.Index, i].Value);
                   
                    dCreditTotal += dCredit;

                }
            }
           
            txtCreditTotal.Text = Math.Round(dCreditTotal, glb_function.glb_iMainCurrDecimal).ToString("###,###,###,##0.##");


          
           txtCreditTotal.BackColor = Color.LawnGreen;
            
           
        }

        private void dgvJourDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == clmDelete.Index)
            {
                dgvJourDetails.Rows.Remove(dgvJourDetails.Rows[e.RowIndex]);
                GetTotal();
                return;
            }


            // dgvJourDetails.RightToLeft = RightToLeft.No;
            DataGridViewCell abc = dgvJourDetails.CurrentCell;
            Rectangle RECT = dgvJourDetails.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
            // dgvJourDetails.RightToLeft = RightToLeft.Yes;
            if (e.ColumnIndex == clmAccNo.Index)
            {
                lstAccNo.W_ColumnName = e.ColumnIndex.ToString();

                lstAccNo.Tag = e.RowIndex.ToString();
                if (dgvJourDetails[clmAccNo.Index, e.RowIndex].Value.ToString() == "")
                    lstAccNo.SelectedIndex = -1;
                else
                    lstAccNo.SelectedValue = dgvJourDetails[clmAccId.Index, e.RowIndex].Value.ToString();

                CtlLocation(RECT, lstAccNo);

                return;
            }

            nmbEditor.W_ColumnName = e.ColumnIndex.ToString();
            nmbEditor.DecimalPlaces = glb_function.glb_iMainCurrDecimal;
            nmbEditor.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == clmCredit.Index)
            {
                if (dgvJourDetails[clmCredit.Index, e.RowIndex].Value == null || dgvJourDetails[clmCredit.Index, e.RowIndex].Value.ToString() == "")
                    dgvJourDetails[clmCredit.Index, e.RowIndex].Value = "0";

                nmbEditor.Value = Convert.ToDecimal(dgvJourDetails[clmCredit.Index, e.RowIndex].Value.ToString());

                CtlLocation(RECT, nmbEditor);

            }
           


        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {

            // ctrl.Location = dgvPurQuotDetail.PointToScreen(dgvPurQuotDetail.GetCellDisplayRectangle(icolumnindex, irowindex, true ).Location);
            ctrl.Top = dgvJourDetails.Location.Y + rect.Y;
            ctrl.Left = dgvJourDetails.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void dgvJourDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == clmAccNo.Index || e.ColumnIndex == clmAccName.Index)
            {
                GetAccount(e.RowIndex);
            }
            else if (e.ColumnIndex == clmProfitCenter.Index)
            {
                frmFindProfitCenter frm = new frmFindProfitCenter();
                frm.ShowDialog();
                if (frm.strAccName != "")
                    dgvJourDetails[clmProfitCenter.Index, e.RowIndex].Value = frm.strAccName;



            }
            else if (e.ColumnIndex == clmJourNote.Index)
            {
                frmTextDetail frm = new frmTextDetail();
                frm.txtDetails.Text = dgvJourDetails.CurrentCell.Value.ToString();
                frm.ShowDialog();
                dgvJourDetails.CurrentCell.Value = frm.txtDetails.Text;
                SendKeys.Send("{TAB}");
                return;
            }

            GetTotal();
        }

        private void GetAccount(int iRow)
        {

            frmFindAccount frm = new frmFindAccount();
            frm.strWhere = " ";
            frm.ShowDialog();
            if (frm.strPKid != "")
            {

                dgvJourDetails[clmPKid.Index, iRow].Value = "";
                dgvJourDetails[clmAccId.Index, iRow].Value = frm.strPKid;
                dgvJourDetails[clmAccNo.Index, iRow].Value = frm.strAccNo;
                dgvJourDetails[clmAccName.Index, iRow].Value = frm.strAccName;


            }

            GetTotal();



        }

        private void dgvJourDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvJourDetails.CurrentRow.Index <= 0)
                return;


            if (e.KeyCode == Keys.F9)
            {

                if (dgvJourDetails.CurrentCell.ColumnIndex == clmAccNo.Index || dgvJourDetails.CurrentCell.ColumnIndex == clmAccName.Index)
                {
                    GetAccount(dgvJourDetails.CurrentRow.Index);
                }
            }
            if (e.KeyCode == Keys.F7)
                dgvJourDetails.Rows.Add();


            GetTotal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckEntries()
        {

            if (dgvJourDetails.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال البيانات التفصيلية للسند");
                return false;
            }

            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if ( dgvJourDetails[clmAccId.Index,i].Value !=null && dgvJourDetails[clmAccId.Index, i].Value.ToString() != "")
                    if (dgvJourDetails[clmCredit.Index, i].Value.ToString()  == "0")
                    {
                        glb_function.MsgBox("الرجاء ادخال مبلغ المدين  للحساب رقم" + "\n" + dgvJourDetails[clmAccNo.Index, i].Value.ToString() );
                        return false;
                    }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtKeys = cnn.GetDataTable("select (select  ifnull(max(trans_id),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='سند قبض') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid,(select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " ) JourNo");
            txtPkid.Text = dtKeys.Rows[0]["pkid"].ToString();

            string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();
            //JourNo
            txtJourNo.Text = glb_function.glb_strBranchPkid + "-" + dtKeys.Rows[0]["JourNo"].ToString();

            int icheck = 0;

            icheck = cnn.TranDataToDB("insert into journal_header values (" + txtPkid.Text +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                "," + glb_function.glb_strBranchPkid +
                ",'" + txtJourNo.Text.Trim() + "'" +
                ",'سند قبض'" +
                "," + strIssueNo +
                ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                ",'" + txtHeaderNote.Text.Trim() + "'" +
                ",'" + txtPerson.Text.Trim() + "'" +
                  ",'" + glb_function.glb_strBranchPkid + "-" + strIssueNo + "'" +
                ")");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                return;
            }

            //حفظ بيانات الدائن 
            //يكون الصندوق مدين في سند القبض ويميزه انه اكبر من الصفر
            double dCredit = Convert.ToDouble(txtCreditTotal.Text);

            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + txtPkid.Text +
            "," + glb_function.glb_iMainCurrId +
            "," + strCasherAccId +
            "," + dCredit +
            "," + dCredit +
            ",1" +
            ",'"+ txtHeaderNote .Text .Trim()+ "'" +
            ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }


            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index,i].Value ==null || dgvJourDetails[clmAccId.Index, i].Value.ToString()  == "")
                    continue;

                decimal dMainValue = 0;
                decimal dCurrValue = 0;

                if (Convert.ToDouble(dgvJourDetails[clmCredit.Index, i].Value.ToString() ) > 0)
                {
                    dMainValue = Convert.ToDecimal(dgvJourDetails[clmCredit.Index, i].Value.ToString()) * -1;
                    dCurrValue = dMainValue;
                }


                icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + txtPkid.Text +
                "," + glb_function.glb_iMainCurrId +
                "," + dgvJourDetails[clmAccId.Index, i].Value.ToString()  +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",'" + dgvJourDetails[clmJourNote.Index, i].Value.ToString()  + "'" +
                ",'" + dgvJourDetails[clmProfitCenter.Index, i].Value.ToString()  + "'" +
               ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }

            }


            cnn.glb_commitTransaction();
            GetData(txtPkid.Text);
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToMySQL cnn = new ConnectionToMySQL();


            int icheck = 0;

            icheck = cnn.TranDataToDB("update journal_header set " +

                " created_user=" + glb_function.glb_strUserId +

                ",jour_date=str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                ",jour_note='" + txtHeaderNote.Text.Trim() + "'" +
                 ",person='" + txtPerson.Text.Trim() + "'" +
                " where pkid=" + txtPkid.Text);
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء تعديل البيانات الأساسية");
                return;
            }

            icheck = cnn.TranDataToDB("delete from journal_details where header_id= " + txtPkid.Text);
            if (icheck <= 0)
            {
                cnn.glb_commitTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حذف البيانات السابقة");
                return;
            }





            //حفظ بيانات الدائن 
            //يكون الصندوق مدين في سند القبض  ويميزه انه أكبر من الصفر
            double dCredit = Convert.ToDouble(txtCreditTotal.Text);

            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + txtPkid.Text +
            "," + glb_function.glb_iMainCurrId +
            "," + strCasherAccId +
            "," + dCredit +
            "," + dCredit +
            ",1" +
            ",'"+ txtHeaderNote .Text.Trim()+ "'" +
             ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }


            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index,i].Value ==null || dgvJourDetails[clmAccId.Index,i].Value.ToString() == "")
                    continue;

                double dMainValue = 0;
                double dCurrValue = 0;

                if (Convert.ToDouble(dgvJourDetails[clmCredit.Index, i].Value.ToString()) > 0)
                {
                    dMainValue = Convert.ToDouble(dgvJourDetails[clmCredit.Index, i].Value.ToString()) * -1;
                    dCurrValue = dMainValue;
                }


                icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + txtPkid.Text +
                "," + glb_function.glb_iMainCurrId +
                "," +  dgvJourDetails[clmAccId.Index, i].Value.ToString()  +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",'" + dgvJourDetails[clmJourNote.Index, i].Value.ToString()  + "'" +
                ",'" + dgvJourDetails[clmProfitCenter.Index, i].Value.ToString()  + "'" +
               ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }

            }


            cnn.glb_commitTransaction();
            GetData(txtPkid.Text);
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار القيد");
                return;
            }

            cryRepCashReceipts report = new cryRepCashReceipts();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtReport = cnn.GetDataTable("select h.pkid,h.jour_no,h.trans_name,date_format(h.jour_date,'%d/%m/%Y') jour_date,h.jour_note, a.Acc_no,a.acc_name, " +
                   " if (d.main_value > 0,d.main_value,0) Dept,if (d.main_value < 0,d.main_value * -1,0) Credit,d.jour_details,d.trans_no " +
                           " from journal_header h " +
                          "  join journal_details d on(h.pkid= d.header_id) " +
                          "  join accounts a on(a.pkid= d.acc_id)  " +
                           " where d.main_value<0 and  h.pkid=  " + txtPkid.Text);



            report.SetDataSource(dtReport);
            report.SetParameterValue("strCasher", "الصندوق الرئيسي");
            report.SetParameterValue("strValueAlpha", N2C.ConvertN2C.ConvertNow (Convert.ToDouble( txtCreditTotal.Text), "ريال", "فلس")) ;
            report.SetParameterValue("strValue", txtCreditTotal.Text);
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }

        private void dgvJourDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvJourDetails[clmPKid.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = "";
          
            dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
            dgvJourDetails[clmProfitCenter.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = "";
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || bLoad == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
            }
        }

        private void lstAccNo_Leave(object sender, EventArgs e)
        {
            if (lstAccNo.Visible == true)
            {
                lstAccNo.Visible = false;
                if (lstAccNo.SelectedIndex == -1)
                {
                    dgvJourDetails[Convert.ToUInt16(lstAccNo.W_ColumnName), Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = "";
                    dgvJourDetails[clmAccId.Index, Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = "";
                    dgvJourDetails[clmAccName.Index, Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = "";

                }
                else
                {
                    dgvJourDetails[Convert.ToUInt16(lstAccNo.W_ColumnName), Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = lstAccNo.Text;
                    dgvJourDetails[clmAccId.Index, Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = lstAccNo.SelectedValue.ToString();
                    dgvJourDetails[clmAccName.Index, Convert.ToUInt16(lstAccNo.Tag.ToString())].Value = lstAccName.Text;
                }





                GetTotal();
            }
        }

        private void lstAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
