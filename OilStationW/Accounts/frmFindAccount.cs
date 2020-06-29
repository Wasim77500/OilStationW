using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmFindAccount : OilStationW.myForm
    {
        public string strPKid = "";
        public string strAccNo = "";
        public string strAccName = "";
        public string strWhere = "";
        public frmFindAccount()
        {
            InitializeComponent();
        }

        private void frmFindAccount_Load(object sender, EventArgs e)
        {
            GetAccounts();
            txtSearchField.Focus();
        }
        private void GetAccounts()
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid,acc_no,acc_name from accounts a " +
                                       " where stat='فعال' and level=5 and concat(concat( a.acc_no), a.acc_name)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

           
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
                dgvJournalData[clmPKid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmAccNo.Index, i].Value = dtJournal.Rows[i]["acc_no"].ToString();
                dgvJournalData[clmAccName.Index, i].Value = dtJournal.Rows[i]["acc_name"].ToString();


            

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            strPKid = "";
            strAccNo = "";
            strAccName = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strPKid = dgvJournalData[clmPKid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                strAccNo = dgvJournalData[clmAccNo.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                strAccName = dgvJournalData[clmAccName.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
            {
                strPKid = "";
                strAccNo = "";
                strAccName = "";
            }
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetAccounts();
        }

        private void txtSearchField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(null, null);
        }
    }
}
