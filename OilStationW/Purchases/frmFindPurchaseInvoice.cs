using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Purchases
{
    public partial class frmFindPurchaseInvoice : OilStationW.myForm
    {
        public string strPKid = "";

        public string strWhere = "";
        public frmFindPurchaseInvoice()
        {
            InitializeComponent();
        }

        private void frmFindPurchaseInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strPKid = dgvJournalData[clmPkid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
            {
                strPKid = "";

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            strPKid = "";
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("SELECT h.pkid,h.invoice_no ,h.pi_note,a.acc_name,a.Acc_no,w.warehouse_name  " +
                                       " FROM pi_header h " +
                                       " join accounts a on(a.pkid = h.acc_id) " +
                                       " join warehouse w on(w.pkid = h.warehosue_id) " +
                                       " where concat(concat( concat(invoice_no,  ifnull(pi_note, '')), acc_name), warehouse_name)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {
                dgvJournalData.Rows.Add();

                dgvJournalData[clmPkid.Index,i].Value = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmInvoiceNo.Index, i].Value = dtJournal.Rows[i]["invoice_no"].ToString();
                dgvJournalData[clmWarehouseName.Index, i].Value = dtJournal.Rows[i]["warehouse_name"].ToString();

                dgvJournalData[clmAccNo.Index, i].Value = dtJournal.Rows[i]["Acc_no"].ToString();
                dgvJournalData[clmAccName.Index, i].Value = dtJournal.Rows[i]["acc_name"].ToString();

                dgvJournalData[clmNote.Index, i].Value = dtJournal.Rows[i]["pi_note"].ToString();
                

            }
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
