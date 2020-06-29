using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Sales
{
    public partial class frmFindSalesInvoice : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindSalesInvoice()
        {
            InitializeComponent();
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

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("SELECT h.pkid pkheader,h.invoice_no,h.invoice_note,h.invoice_value,date_format(h.invoice_date,'%d/%m/%Y') invoice_date , " +
                                       " d.warehouse_id, d.pump_emp, d.pump_id, p.PumpNo, p.PumpName, d.emp_id, e.empname, d.old_counter, d.new_counter, " +
                                       " d.item_id, i.itemname, d.qty, d.unitsellingPrice, d.TotalSellingPrice " +
                                        " FROM invoice_header h " +
                                       "  join invoice_details d on(h.pkid = d.header_id) " +
                                       "  join pumps p on(p.pkid = d.pump_id) " +
                                       "  join emp e on(e.pkid = d.emp_id) " +
                                       "  join items i on(i.pkid = d.item_id) " + 
                                       " where concat(concat(concat(itemname, concat(invoice_no, concat(ifnull(PumpName, ''), ifnull(itemno, '')))), empname), invoice_note)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

           
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {
                dgvCustomers.Rows.Add();

                dgvCustomers[clmPKid.Index,i].Value  = dtJournal.Rows[i]["pkheader"].ToString();
                dgvCustomers[clmInvoiceNo.Index, i].Value = dtJournal.Rows[i]["invoice_no"].ToString();
                dgvCustomers[clmEmpName.Index, i].Value = dtJournal.Rows[i]["empname"].ToString();
                dgvCustomers[clmPumpName.Index, i].Value = dtJournal.Rows[i]["PumpName"].ToString();
                dgvCustomers[clmValue.Index, i].Value = dtJournal.Rows[i]["TotalSellingPrice"].ToString();
                dgvCustomers[clmtNote.Index, i].Value = dtJournal.Rows[i]["invoice_note"].ToString();


               

            }

        }
    }
}
