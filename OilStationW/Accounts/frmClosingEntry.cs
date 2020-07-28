using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmClosingEntry : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmClosingEntry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetCloseingEntry_Click(object sender, EventArgs e)
        {
            dgvJourDetails.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtProfitExp = cnn.GetDataTable("SELECT acc_id,a.Acc_no,a.acc_name, sum(main_value),if (sum(main_value) > 0,sum(main_value),0) Dept,"+
                                    " if (sum(main_value) < 0,sum(main_value) * -1,0) Credit"+
                                   " FROM journal_details d"+
                                   " join accounts a on(d.acc_id = a.pkid)"+
                                   " where acc_id like '5%'"+
                                   " group by acc_id"+
                                    " having sum(main_value) != 0");



            for (int i = 0; i < dtProfitExp.Rows.Count; i++)
            {
                dgvJourDetails.Rows.Add();
                dgvJourDetails[clmAccId.Index, i].Value = dtProfitExp.Rows[i]["acc_id"].ToString ();
                dgvJourDetails[clmAccNo.Index, i].Value = dtProfitExp.Rows[i]["Acc_no"].ToString();
                dgvJourDetails[clmAccName.Index, i].Value = dtProfitExp.Rows[i]["acc_name"].ToString();
                dgvJourDetails[clmCredit.Index, i].Value =Convert.ToDecimal( dtProfitExp.Rows[i]["Dept"].ToString()).ToString("###,###,###,##0.##");
                dgvJourDetails[clmDept.Index, i].Value = "0";
                dgvJourDetails[clmJourNote.Index, i].Value = "قيد الاقفال لسنة " + glb_function.glb_Year;
                
            }
           
          

            dtProfitExp.Rows.Clear();
            dtProfitExp = cnn.GetDataTable("SELECT acc_id,a.Acc_no,a.acc_name, sum(main_value),if (sum(main_value) > 0,sum(main_value),0) Dept," +
                                    " if (sum(main_value) < 0,sum(main_value) * -1,0) Credit" +
                                   " FROM journal_details d" +
                                   " join accounts a on(d.acc_id = a.pkid)" +
                                   " where acc_id like '6%'" +
                                   " group by acc_id" +
                                    " having sum(main_value) != 0");



            for (int i = 0; i < dtProfitExp.Rows.Count; i++)
            {
                dgvJourDetails.Rows.Add();
                dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = dtProfitExp.Rows[i]["acc_id"].ToString();
                dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = dtProfitExp.Rows[i]["Acc_no"].ToString();
                dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = dtProfitExp.Rows[i]["acc_name"].ToString();
                dgvJourDetails[clmDept.Index, dgvJourDetails.Rows.Count - 1].Value =Convert.ToDecimal( dtProfitExp.Rows[i]["Credit"].ToString()).ToString("###,###,###,##0.##");
                dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
               dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = "قيد الاقفال لسنة " + glb_function.glb_Year;
            }
            GetTotal();
            dgvJourDetails.Rows.Add();
            dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccNo.SelectedValue.ToString();
            dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccNo.Text;
            dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccName.Text;
            dgvJourDetails[clmDept.Index, dgvJourDetails.Rows.Count - 1].Value = txtCreditTotal.Text.Trim();
            dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
            dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = "قيد الاقفال لسنة " + glb_function.glb_Year;



            dgvJourDetails.Rows.Add();
            dgvJourDetails[clmAccId.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccNo.SelectedValue.ToString();
            dgvJourDetails[clmAccNo.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccNo.Text;
            dgvJourDetails[clmAccName.Index, dgvJourDetails.Rows.Count - 1].Value = lstAccName.Text;
            dgvJourDetails[clmCredit.Index, dgvJourDetails.Rows.Count - 1].Value = txtDeptTotal.Text.Trim();
            dgvJourDetails[clmDept.Index, dgvJourDetails.Rows.Count - 1].Value = "0";
           dgvJourDetails[clmJourNote.Index, dgvJourDetails.Rows.Count - 1].Value = "قيد الاقفال لسنة " + glb_function.glb_Year;


            GetTotal();


        }

        private void GetTotal()
        {
            decimal dDeptTotal = 0;
            decimal dCreditTotal = 0;

            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index, i].Value != null && dgvJourDetails[clmAccId.Index, i].Value.ToString() != "")
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

        private void frmClosingEntry_Load(object sender, EventArgs e)
        {
            txtCreditTotal.Text = "0";
            txtDeptTotal.Text = "0";
            txtDiff.Text = "0";
            FillData();
        }
        private void FillData()
        {
            strDataFromDataSource = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtVendor = cnn.GetDataTable("SELECT pkid,acc_no,acc_name " +
                       " FROM accounts " +
                       " where level=5 and stat='فعال' order by acc_no ");

            lstAccNo.DataSource = dtVendor.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtVendor.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";
            strDataFromDataSource = false;
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtKeys = cnn.GetDataTable("select (select  ifnull(max(trans_id),0)+1  FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='سند اقفال') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid, (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " ) JounNo");
            txtPkid.Text = dtKeys.Rows[0]["pkid"].ToString();
            //JounNo
            string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();

            txtJourNo.Text = glb_function.glb_strBranchPkid + "-" + dtKeys.Rows[0]["JounNo"].ToString();

            int icheck = 0;

            icheck = cnn.TranDataToDB("insert into journal_header values (" + txtPkid.Text +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                "," + glb_function.glb_strBranchPkid +
                ",'" + txtJourNo.Text.Trim() + "'" +
                ",'سند اقفال'" +
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

            for (int i = 0; i < dgvJourDetails.Rows.Count; i++)
            {
                if (dgvJourDetails[clmAccId.Index, i].Value == null || dgvJourDetails[clmAccId.Index, i].Value.ToString() == "")
                    continue;

                double dMainValue = 0;
                double dCurrValue = 0;

                if (Convert.ToDouble(dgvJourDetails[clmDept.Index, i].Value.ToString()) > 0)
                {
                    dMainValue = Convert.ToDouble(dgvJourDetails[clmDept.Index, i].Value.ToString());
                    dCurrValue = dMainValue;
                }
                else
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
                "," + dgvJourDetails[clmAccId.Index, i].Value.ToString() +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",'" + dgvJourDetails[clmJourNote.Index, i].Value.ToString() + "'" +
                ",''" +
               ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }

            }


            cnn.glb_commitTransaction();
           
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");

        }
    }
}
