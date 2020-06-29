using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OilStationW.Reports
{
    public partial class frmSalesInvoiceRep : OilStationW.myForm
    {
        public frmSalesInvoiceRep()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectDate.Checked)
                gbDate.Enabled = true;
            else
                gbDate.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cryRepSalesInvoice report = new cryRepSalesInvoice();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();

            string strDate = "";



            if (ckbSelectDate.Checked == true)
            {

                strDate = " and h.invoice_date between str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpTo.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";


            }


            dtReport.Clear();

            dtReport = cnn.GetDataTable("SELECT  h.pkid,date_format(h.invoice_date,'%d/%m/%Y') created_date,h.invoice_no, " +
                   " p.PumpName, d.old_counter, d.new_counter, d.qty, d.TotalSellingPrice " +
                   " FROM invoice_header h " +
                   " join invoice_details d on (h.pkid=d.header_id)"+
                   " join pumps p on(p.pkid = d.pump_id) " +
                   " where 1 = 1 " + strDate +
                   " order by h.pkid");









            report.SetDataSource(dtReport);
            report.SetParameterValue("From", (ckbSelectDate.Checked == false ? "" : dtpFrom.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("To", (ckbSelectDate.Checked == false ? DateTime.Now.ToString("dd/MM/yyyy") : dtpTo.Value.ToString("dd/MM/yyyy")));


            // report.SetParameterValue("strValueAlpha", new ConvertNumbersToArabicAlphabet(txtCreditTotal.Text).GetNumberAr());
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
