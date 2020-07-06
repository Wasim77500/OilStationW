using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmBeginingEntry : OilStationW.myForm
    {
        bool bLoad = false;
        public frmBeginingEntry()
        {
            InitializeComponent();
        }

        private void frmBeginingEntry_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();
            //nmbCredit.FormatString = "N" + glb_function.glb_iMainCurrDecimal.ToString();
            //nmbDept.FormatString = "N" + glb_function.glb_iMainCurrDecimal.ToString();
            txtCreditTotal.Text = "0";
            txtDeptTotal.Text = "0";
            txtDiff.Text = "0";
            txtDeptTotal.BackColor = txtCreditTotal.BackColor = Color.LawnGreen;
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
        private void FillData()
        {
            //ConnectionToMySQL cnn = new ConnectionToMySQL();
            //DataTable dtCurr = cnn.GetDataTable("SELECT pkid,curr_name FROM currency order by pkid");
            //lstCurrency.ItemsSource = dtCurr.DefaultView;
            //lstCurrency.SelectedValuePath = "pkid";
            //lstCurrency.DisplayMemberPath = "curr_name";
            //lstCurrency.SelectedIndex = 0;




            //DataTable dtAcc = cnn.GetDataTable("SELECT pkid,acc_no,acc_name FROM accounts where level=5 and stat='فعال' order by acc_no");
            //lstAccNo.ItemsSource = dtAcc.DefaultView;
            //lstAccNo.SelectedValuePath = "pkid";
            //lstAccNo.DisplayMemberPath = "acc_no";

            //lstAccName.ItemsSource = dtAcc.DefaultView;
            //lstAccName.SelectedValuePath = "pkid";
            //lstAccName.DisplayMemberPath = "acc_name";
            //lstAccNo.SelectedIndex = -1;
            //lstAccName.SelectedIndex = -1;
        }

        private void dgvJourDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if(e.ColumnIndex == clmAccNo.Index || e.ColumnIndex==clmAccName.Index)
            {
                GetAccount(e.RowIndex);
            }
            else if(e.ColumnIndex==clmProfitCenter.Index)
            {
                frmFindProfitCenter frm = new frmFindProfitCenter();
                frm.ShowDialog();
                if (frm.strAccName != "")             
                    dgvJourDetails[clmProfitCenter.Index, e.RowIndex].Value = frm.strAccName;


                
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
                   
                    dgvJourDetails[clmPKid.Index, iRow].Value  = "";
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


            if (e.KeyCode== Keys.F9)
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


            nmbEditor.W_ColumnName = e.ColumnIndex.ToString();
            nmbEditor.DecimalPlaces = glb_function.glb_iMainCurrDecimal;
            nmbEditor.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == clmDept.Index)
            {
                dgvJourDetails[clmCredit.Index, e.RowIndex].Value = "0";
                if (dgvJourDetails[clmDept.Index, e.RowIndex].Value == null || dgvJourDetails[clmDept.Index, e.RowIndex].Value.ToString() == "")
                    dgvJourDetails[clmDept.Index, e.RowIndex].Value = "0";

                nmbEditor.Value = Convert.ToDecimal(dgvJourDetails[clmDept.Index, e.RowIndex].Value.ToString());

                CtlLocation(RECT, nmbEditor);

            }
            else if (e.ColumnIndex == clmCredit.Index)
            {
                dgvJourDetails[clmDept.Index, e.RowIndex].Value = "0";

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
        private void GetTotal()
        {
            decimal dDeptTotal = 0;
            decimal dCreditTotal = 0;

            for(int i=0;i<dgvJourDetails.Rows.Count;i++)
            {
                if (dgvJourDetails[clmAccId.Index, i].Value!=null && dgvJourDetails[clmAccId.Index,i].Value .ToString() != "")
                {
                    decimal dDept = Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value);
                    decimal dCredit = Convert.ToDecimal(dgvJourDetails[clmCredit.Index, i].Value);
                    dDeptTotal += dDept;
                    dCreditTotal += dCredit;

                }
            }
            txtDiff.Text = (dDeptTotal - dCreditTotal).ToString("###,###,###,##0.##");
            txtDeptTotal.Text = Math.Round(dDeptTotal, glb_function.glb_iMainCurrDecimal).ToString("###,###,###,##0.##");
            txtCreditTotal.Text = Math.Round(dCreditTotal, glb_function.glb_iMainCurrDecimal).ToString("###,###,###,##0.##");


            if (txtCreditTotal.Text.Trim() == txtDeptTotal.Text.Trim())
            {

                txtDeptTotal.BackColor = Color.LawnGreen;
                txtCreditTotal.BackColor = Color.LawnGreen;
            }
            else
            {
                txtDeptTotal.BackColor = Color.Red;
                txtCreditTotal.BackColor = Color.Red;
            }
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

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindJournal frm = new frmFindJournal();
            frm.strWhere = " and trans_name='قيد افتتاحي' and h.stat='فعال' and branch_id=" + glb_function.glb_strBranchPkid + " ";
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
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
            txtCreditTotal.Text = "0";
            txtDeptTotal.Text = "0";
            for (int i = 0; i < dtJournalData.Rows.Count; i++)
            {
                dgvJourDetails.Rows.Add();

                if (Convert.ToDouble(dtJournalData.Rows[i]["main_value"].ToString()) > 0)
                {
                    dgvJourDetails[clmDept.Index,i].Value = (Convert.ToDecimal( dtJournalData.Rows[i]["main_value"].ToString())).ToString("###,###,###,##0.##");
                    // newRow.clmCurrValue= dtJournalData.Rows[i]["jour_value"].ToString();
                    dgvJourDetails[clmCredit.Index, i].Value = "0";
                }

                else
                {
                    dgvJourDetails[clmCredit.Index, i].Value = (Convert.ToDecimal(dtJournalData.Rows[i]["main_value"].ToString()) * -1).ToString("###,###,###,##0.##");
                    // newRow.clmCurrValue = (Convert.ToDouble(dtJournalData.Rows[i]["jour_value"].ToString()) * -1).ToString();
                    dgvJourDetails[clmDept.Index, i].Value = "0";
                }



                dgvJourDetails[clmPKid.Index, i].Value = dtJournalData.Rows[i]["dpkid"].ToString();



                dgvJourDetails[clmAccId.Index, i].Value = dtJournalData.Rows[i]["acc_id"].ToString();
                dgvJourDetails[clmAccNo.Index, i].Value = dtJournalData.Rows[i]["acc_no"].ToString();
                dgvJourDetails[clmAccName.Index, i].Value = dtJournalData.Rows[i]["acc_name"].ToString();

                dgvJourDetails[clmJourNote.Index, i].Value= dtJournalData.Rows[i]["jour_details"].ToString();
                dgvJourDetails[clmProfitCenter.Index, i].Value = dtJournalData.Rows[i]["profitCenter"].ToString();


                decimal dCreditTemp = Convert.ToDecimal(txtCreditTotal.Text.Trim()) + Convert.ToDecimal(dgvJourDetails[clmCredit.Index, i].Value);
                decimal dDebitTemp = Convert.ToDecimal(txtDeptTotal.Text.Trim()) + Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value);
                txtCreditTotal.Text = (dCreditTemp).ToString("###,###,###,##0.##");
                txtDeptTotal.Text = (dDebitTemp).ToString("###,###,###,##0.##");


            }



            if (txtCreditTotal.Text.Trim() == txtDeptTotal.Text.Trim())
            {

                txtDeptTotal.BackColor = Color.LawnGreen;
                txtCreditTotal.BackColor = Color.LawnGreen;
            }
            else
            {
                txtDeptTotal.BackColor = Color.Red;
                txtCreditTotal.BackColor = Color.Red;
            }


            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            if (UserTemplate.HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;

            btnSave.Enabled = false;
            bLoad = false;
        }

        private bool CheckEntries()
        {

            if (dgvJourDetails.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال البيانات التفصيلية للقيد");
                return false;
            }
            if (txtDeptTotal.Text.Trim() != txtCreditTotal.Text.Trim())
            {
                glb_function.MsgBox("مبلغ المدين لا يساوي الدائن");
                return false;
            }
            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index, i].Value !=null && dgvJourDetails[clmAccId.Index,i].Value.ToString() != "")
                    if (dgvJourDetails[clmDept.Index, i].Value.ToString()  == "0" && dgvJourDetails[clmCredit.Index, i].Value.ToString() == "0")
                    {
                        glb_function.MsgBox("الرجاء ادخال مبلغ المدين او الدائن للحساب رقم" + "\n" + dgvJourDetails[clmAccNo.Index, i].Value.ToString() );
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
            DataTable dtBiginingEntry = cnn.GetDataTable("select pkid,stat from journal_header where trans_name='قيد افتتاحي' and date_format(jour_date,'%Y')='" + dtpJourDate.Value.ToString("yyyy") + "' ");
            int icheck = 0;
            if (dtBiginingEntry == null || dtBiginingEntry.Rows.Count <= 0)
            {
                DataTable dtKeys = cnn.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='قيد افتتاحي') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
                txtPkid.Text = dtKeys.Rows[0]["pkid"].ToString();

                string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();

                txtJourNo.Text = glb_function.glb_strBranchPkid + "-" + txtPkid.Text;



                icheck = cnn.TranDataToDB("insert into journal_header values (" + txtPkid.Text +
                    ",'فعال'" +
                    ",sysdate()" +
                    "," + glb_function.glb_strUserId +
                    "," + glb_function.glb_strBranchPkid +
                    ",'" + txtJourNo.Text.Trim() + "'" +
                    ",'قيد افتتاحي'" +
                    "," + strIssueNo +
                    ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                    ",'" + txtHeaderNote.Text.Trim() + "'" +
                    ",null" +
                    ",'" + glb_function.glb_strBranchPkid + "-" + strIssueNo + "'" +
                    ")");
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                    return;
                }
            }
            else
                txtPkid.Text = dtBiginingEntry.Rows[0]["pkid"].ToString();


            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)          
            {
                if (dgvJourDetails[clmAccId.Index,i].Value  == null || dgvJourDetails[clmAccId.Index, i].Value.ToString() == "")
                    continue;

                decimal dMainValue = 0;
                decimal dCurrValue = 0;

                if (Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value) > 0)
                {
                    dMainValue = Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value);
                    dCurrValue = dMainValue;
                }
                else
                {
                    dMainValue = Convert.ToDecimal(dgvJourDetails[clmCredit.Index, i].Value) * -1;
                    dCurrValue = dMainValue;
                }

                icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + txtPkid.Text +
                "," + glb_function.glb_iMainCurrId +
                "," + dgvJourDetails[clmAccId.Index, i].Value +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",'" + dgvJourDetails[clmJourNote.Index, i].Value + "'" +
                ",'" + dgvJourDetails[clmProfitCenter.Index, i].Value + "'" +
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

            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index,i].Value   == null || dgvJourDetails[clmAccId.Index, i].Value.ToString() == "")
                    continue;


                decimal dMainValue = 0;
                decimal dCurrValue = 0;

                if (Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value) > 0)
                {
                    dMainValue = Convert.ToDecimal(dgvJourDetails[clmDept.Index, i].Value);
                    dCurrValue = dMainValue;
                }
                else
                {
                    dMainValue = Convert.ToDecimal(dgvJourDetails[clmCredit.Index, i].Value) * -1;
                    dCurrValue = dMainValue;
                }

                icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + txtPkid.Text +
                "," + glb_function.glb_iMainCurrId +
                "," + dgvJourDetails[clmAccId.Index, i].Value +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",'" + dgvJourDetails[clmJourNote.Index, i].Value + "'" +
                ",'" + dgvJourDetails[clmProfitCenter.Index, i].Value + "'" +
               ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء تعديل التفاصيل");
                    return;
                }

            }


            cnn.glb_commitTransaction();
            GetData(txtPkid.Text);
            glb_function.MsgBox("تمت عملية التعديل بنجاح");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار القيد");
                return;
            }

            cryRepVoucher report = new cryRepVoucher();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            TextObject txtTitel = (TextObject)report.ReportDefinition.ReportObjects["txtReportTitel"];
            txtTitel.Text = "قيد افتتاحي";
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtReport = cnn.GetDataTable("select h.pkid,h.jour_no,h.trans_name,date_format(h.jour_date,'%d/%m/%Y') jour_date,h.jour_note, a.Acc_no,a.acc_name, " +
                   " if (d.main_value > 0,d.main_value,0) Dept,if (d.main_value < 0,d.main_value * -1,0) Credit,d.jour_details " +
                           " from journal_header h " +
                          "  join journal_details d on(h.pkid= d.header_id) " +
                          "  join accounts a on(a.pkid= d.acc_id) " +
                           " where h.pkid=  " + txtPkid.Text);






            report.SetDataSource(dtReport);
            ////// report.SetParameterValue("P_Date", (ckbSelectDate.IsChecked == true ? " من تاريخ : " + dtpFrom.SelectedDate.Value.ToString("dd/MM/yyyy") + " إلى تاريخ : " + dtpTo.SelectedDate.Value.ToString("dd/MM/yyyy") : ""));
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }

        private void dgvJourDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvJourDetails[clmPKid.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmDept.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
            dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
            dgvJourDetails[clmProfitCenter.Index, dgvJourDetails.Rows.Count - 1].Value = "";
            dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = "";
        }
    }
}
