using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Purchases
{
    public partial class frmFindVendor : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindVendor()
        {
            InitializeComponent();
        }

        private void frmFindVendor_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            strPKid = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strPKid = dgvJournalData[clmPKid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
            {
                strPKid = "";

            }
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                       " vendorno, vendorname, addess1, addess2, tel1, tel2, " +
                                       " acc_id, vendornote " +
                                       " from vendors " +
                                       " where concat(concat(concat(vendorno, concat(vendorname, concat(ifnull(addess1, ''), ifnull(addess2, '')))), tel1), tel2)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
               dgvJournalData[clmPKid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();
                dgvJournalData[clmVendorNo.Index, i].Value = dtJournal.Rows[i]["vendorno"].ToString();
                dgvJournalData[clmVendorName.Index, i].Value = dtJournal.Rows[i]["vendorname"].ToString();
                dgvJournalData[clmAddress.Index, i].Value = dtJournal.Rows[i]["addess1"].ToString();
                dgvJournalData[clmTel.Index, i].Value = dtJournal.Rows[i]["tel1"].ToString();
                dgvJournalData[clmVendorNote.Index, i].Value = dtJournal.Rows[i]["vendornote"].ToString();


                

            }
        }
    }
}
