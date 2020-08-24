using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmTrialBalanceOld : OilStationW.myForm
    {
        public frmTrialBalanceOld()
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
            cryRepTrialBalance report = new cryRepTrialBalance();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();

            string strDate = "";
            string strPrevDate = "";
            string strStat = "";
            if (ckbPosting.Checked == true)
            {
                strStat = " and h.stat in ('فعال', 'مرحل')";
            }
            else
                strStat = " and h.stat in ( 'مرحل')";

            if(ckbClosingEntry.Checked ==false )
            {
                strStat += " and h.trans_name!='سند اقفال'";
            }

            if (ckbSelectDate.Checked == true)
            {

                strDate = " and h.trans_name!='قيد افتتاحي' and jour_date between str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpTo.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";
                
                if(dtpFrom.Value.ToString("dd/MM")== "01/01"  )
                    strPrevDate = " and h.trans_name='قيد افتتاحي'";
                else
                strPrevDate = " and jour_date between str_to_date('01/01/" + dtpFrom.Value.ToString("yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpFrom.Value.AddDays(-1).ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";

            }

            if(strPrevDate=="")
            {
                //  strPrevDate = " and jour_date between str_to_date('01/01/1999', '%d/%m/%Y') and str_to_date('02/01/1999', '%d/%m/%Y')";
                strDate = " and h.trans_name!='قيد افتتاحي'";
                strPrevDate = " and h.trans_name='قيد افتتاحي'";
            }
           
            dtReport.Clear();

            dtReport = cnn.GetDataTable("SELECT Acc_no,acc_name ," +
                   "(select sum(main_value) " +
                   " from journal_header h " +
                   " join journal_details d on (d.header_id = h.Pkid) " +
                   " join accounts a on (a.pkid = d.acc_id) " +
                   " where main_value > 0 " +
                   " and acc_no like concat(acc.acc_no, '%') " + strDate + strStat + ") dept, " +
                   "(select sum(main_value) " +
                   " from journal_header h " +
                   " join journal_details d on (d.header_id = h.Pkid) " +
                   " join accounts a on (a.pkid = d.acc_id) " +
                   " where main_value > 0 " +
                   " and acc_no like concat(acc.acc_no, '%') "  + strPrevDate + strStat + ") Prevdept, " +
                   " (select sum(main_value) * -1 " +
                   " from journal_header h " +
                   " join journal_details d on (d.header_id = h.Pkid) " +
                   " join accounts a on (a.pkid = d.acc_id) " +
                   " where main_value < 0 " +
                   " and acc_no like concat(acc.acc_no,'%')" + strDate + strStat + ") credit, " +
                   " (select sum(main_value) * -1 " +
                   " from journal_header h " +
                   " join journal_details d on (d.header_id = h.Pkid) " +
                   " join accounts a on (a.pkid = d.acc_id) " +
                   " where main_value < 0 " +
                   " and acc_no like concat(acc.acc_no,'%')" + strPrevDate + strStat + ") Prevcredit, " +
                   " 0.00 balance_dept,0.00 balance_credit " +
                   " FROM accounts acc " +
                   " order by acc_no desc");

            decimal dDept = 0;
            decimal  dCredit = 0;
            decimal dPreDept = 0;
            decimal dPreCredit = 0;
            decimal dBalance = 0;

            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                if(dtReport.Rows[i]["Acc_no"].ToString()== "11102")
                {
                   int x = 1;
                }
                if (dtReport.Rows[i]["dept"].ToString() == "")
                {
                    dDept = 0;
                    dtReport.Rows[i]["dept"] = "0";
                }
                else
                    dDept = Convert.ToDecimal(dtReport.Rows[i]["dept"].ToString());

                if (dtReport.Rows[i]["Prevdept"].ToString() == "")
                {

                    dtReport.Rows[i]["Prevdept"] = "0";
                    dPreDept = 0;
                }
                else
                    dPreDept = Convert.ToDecimal(dtReport.Rows[i]["Prevdept"].ToString());

                if (dtReport.Rows[i]["credit"].ToString() == "")
                {
                    dCredit = 0;
                    dtReport.Rows[i]["credit"] = "0";
                }
                else
                    dCredit = Convert.ToDecimal(dtReport.Rows[i]["credit"].ToString());


                if (dtReport.Rows[i]["Prevcredit"].ToString() == "")
                {

                    dtReport.Rows[i]["Prevcredit"] = "0";
                    dPreCredit = 0;
                }
                else
                    dPreCredit = Convert.ToDecimal(dtReport.Rows[i]["Prevcredit"].ToString());



                if ((dDept + dPreDept) - (dCredit + dPreCredit) == 0 )
                {
                    dtReport.Rows.Remove(dtReport.Rows[i]);
                    i--;
                }
                else
                {
                    dBalance = (dDept+dPreDept) - (dCredit+dPreCredit);

                    if (dBalance < 0)
                    {
                        dtReport.Rows[i]["balance_credit"] = (dBalance * -1).ToString();

                    }
                    else
                    {
                        dtReport.Rows[i]["balance_dept"] = (dBalance).ToString();
                    }
                }


            }





            report.SetDataSource(dtReport);
            report.SetParameterValue("From", (ckbSelectDate.Checked == false ? "" : dtpFrom.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("To", (ckbSelectDate.Checked == false ? DateTime.Now.ToString("dd/MM/yyyy") : dtpTo.Value.ToString("dd/MM/yyyy")));


            // report.SetParameterValue("strValueAlpha", new ConvertNumbersToArabicAlphabet(txtCreditTotal.Text).GetNumberAr());
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
