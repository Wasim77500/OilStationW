using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Sales
{
    public partial class frmFindCustomer : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            strPKid = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow.Index >= 0)
            {

                strPKid = dgvCustomers[clmPKid.Index, dgvCustomers.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
            {
                strPKid = "";

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                       " custno, custname, addess1, addess2, tel1, tel2, " +
                                       " acc_id, custnote " +
                                       " from customers " +
                                       " where concat(concat(concat(custno, concat(custname, concat(ifnull(addess1, ''), ifnull(addess2, '')))), tel1), tel2)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvCustomers.Rows.Add();
                dgvCustomers[clmPKid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();
                dgvCustomers[clmCustNo.Index, i].Value = dtJournal.Rows[i]["custno"].ToString();
                dgvCustomers[clmCustName.Index, i].Value = dtJournal.Rows[i]["custname"].ToString();
                dgvCustomers[clmAddress.Index, i].Value = dtJournal.Rows[i]["addess1"].ToString();
                dgvCustomers[clmTel.Index, i].Value = dtJournal.Rows[i]["tel1"].ToString();
                dgvCustomers[clmCustNote.Index, i].Value = dtJournal.Rows[i]["custnote"].ToString();


               

            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
