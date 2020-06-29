using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmJournalsRep : OilStationW.myForm
    {
        public frmJournalsRep()
        {
            InitializeComponent();
        }

        private void ckbSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectDate.Checked)
                gbDate.Enabled = true;
            else
                gbDate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cryRepJournals report = new cryRepJournals();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            double dBalance = 0;
            string strDate = "";
            string strStat = "";
            if (ckbPosting.Checked == true)
            {
                strStat = " and h.stat in ('فعال', 'مرحل')";
            }
            else
                strStat = " and h.stat in ( 'مرحل')";

            if (ckbSelectDate.Checked == true)
            {

                strDate = " and jour_date between str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpTo.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";

                dtReport = cnn.GetDataTable("select ifnull(sum(main_value) ,0) balance " +
                   " from journal_header h " +
                   " join journal_details d on (h.pkid = d.header_id) " +
                   " where  h.created_date < str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y') " + strStat);

                dBalance = Convert.ToDouble(dtReport.Rows[0][0].ToString());
            }
            else
                dBalance = 0;

            dtReport.Clear();

            dtReport = cnn.GetDataTable("select h.pkid,h.jour_no,h.trans_no,h.trans_name,date_format(h.jour_date,'%d/%m/%Y') jour_date,h.jour_note, " +
                " d.acc_id,a.Acc_no,a.acc_name," +
               " if (d.main_value > 0,d.main_value,0) Dept,if (d.main_value < 0,d.main_value * -1,0) Credit,d.jour_details,0 Balance, 'مدين' BalStat" +
                      "  from journal_header h " +
                      "  join journal_details d on(h.pkid= d.header_id)" +
                      " join accounts a on (d.acc_id=a.pkid)" +
                      " where 1=1  " + strStat + strDate + " order by h.pkid,main_value desc");






            report.SetDataSource(dtReport);
            report.SetParameterValue("From", (ckbSelectDate.Checked == false ? "" : dtpFrom.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("To", (ckbSelectDate.Checked == false ? DateTime.Now.ToString("dd/MM/yyyy") : dtpTo.Value.ToString("dd/MM/yyyy")));


            // report.SetParameterValue("strValueAlpha", new ConvertNumbersToArabicAlphabet(txtCreditTotal.Text).GetNumberAr());
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
