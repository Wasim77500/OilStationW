using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmTrialBalance : OilStationW.myForm
    {
        public frmTrialBalance()
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

            if (ckbClosingEntry.Checked == false)
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

            if (strPrevDate == "")
            {
                //  strPrevDate = " and jour_date between str_to_date('01/01/1999', '%d/%m/%Y') and str_to_date('02/01/1999', '%d/%m/%Y')";
                strDate = " and h.trans_name!='قيد افتتاحي'";
                strPrevDate = " and h.trans_name='قيد افتتاحي'";
            }

            dtReport.Clear();

            //dtReport = cnn.GetDataTable("SELECT Acc_no,acc_name ," +
            //       "(select sum(main_value) " +
            //       " from journal_header h " +
            //       " join journal_details d on (d.header_id = h.Pkid) " +
            //       " join accounts a on (a.pkid = d.acc_id) " +
            //       " where main_value > 0 " +
            //       " and acc_no like concat(acc.acc_no, '%') " + strDate + strStat + ") dept, " +
            //       "(select sum(main_value) " +
            //       " from journal_header h " +
            //       " join journal_details d on (d.header_id = h.Pkid) " +
            //       " join accounts a on (a.pkid = d.acc_id) " +
            //       " where main_value > 0 " +
            //       " and acc_no like concat(acc.acc_no, '%') "  + strPrevDate + strStat + ") Prevdept, " +
            //       " (select sum(main_value) * -1 " +
            //       " from journal_header h " +
            //       " join journal_details d on (d.header_id = h.Pkid) " +
            //       " join accounts a on (a.pkid = d.acc_id) " +
            //       " where main_value < 0 " +
            //       " and acc_no like concat(acc.acc_no,'%')" + strDate + strStat + ") credit, " +
            //       " (select sum(main_value) * -1 " +
            //       " from journal_header h " +
            //       " join journal_details d on (d.header_id = h.Pkid) " +
            //       " join accounts a on (a.pkid = d.acc_id) " +
            //       " where main_value < 0 " +
            //       " and acc_no like concat(acc.acc_no,'%')" + strPrevDate + strStat + ") Prevcredit, " +
            //       " 0.00 balance_dept,0.00 balance_credit " +
            //       " FROM accounts acc " +
            //       " order by acc_no desc");


            dtReport = cnn.GetDataTable("select a.pkid,acc_no,acc_name ,a.parent_id, sum(if (d.main_value > 0 " + strPrevDate + strStat + ",d.main_value,0)) Prevdept, "+
           " sum( if (d.main_value < 0 " + strPrevDate + strStat + ",d.main_value *-1,0))  Prevcredit,  " +
           " sum(if (d.main_value > 0 " + strDate + strStat + ", d.main_value,0)) Dept,sum(if (d.main_value  < 0 "+strDate + strStat + ",d.main_value*-1,0) ) credit," +
           " 0.00 balance_dept,0.00 balance_credit " +
           "from journal_header h " +
           " join journal_details d on(h.Pkid = d.header_id) " +
           " join accounts a on(a.pkid = d.acc_id) "+
           " group by a.pkid,acc_no,acc_name ,a.parent_id " +
           " order by acc_no " +
           "");
            decimal dDept = 0;
            decimal  dCredit = 0;
            decimal dPreDept = 0;
            decimal dPreCredit = 0;
            decimal dBalance = 0;

            decimal dTotalDept = 0;
            decimal dTotalCredit = 0;
            decimal dTotalPreDept = 0;
            decimal dTotalPreCredit = 0;
            decimal dTotalBalanceDept = 0;
            decimal dTotalBalanceCredit = 0;
            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
               
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


                string stracc = dtReport.Rows[i]["acc_no"].ToString();
                // if ((dDept + dPreDept) - (dCredit + dPreCredit) == 0 )
                // if ((dDept- dPreDept)==0 && (dCredit- dPreCredit )== 0)
                if ((dDept - dCredit ) == 0 && (dPreDept - dPreCredit) == 0)
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


            DataTable dtMainAcc = cnn.GetDataTable("select pkid,acc_no,acc_name ,a.parent_id  " +
               " from accounts a  " +
               " where a.level < 5  " +
               " order by Acc_no desc");


            decimal sumDept = 0;
            decimal sumCredit = 0;
            decimal sumPrevDept = 0;
            decimal sumPrevCredit = 0;
            decimal sumBalDept = 0;
            decimal sumBalCredit = 0;
            int icount = 0;

            int iReportCount = dtReport.Rows.Count;
            decimal dBalanceTotal = 0;
            for (int i = 0; i < dtMainAcc.Rows.Count; i++)
            {
                sumDept = 0;
                sumCredit = 0;
                sumPrevDept = 0;
                sumPrevCredit = 0;
                sumBalDept = 0;
                sumBalCredit = 0;
                icount = 0;
                for (int j = 0; j < iReportCount; j++)
                {


                    if (dtMainAcc.Rows[i]["pkid"].ToString() == dtReport.Rows[j]["parent_id"].ToString())
                    {
                        sumDept = sumDept + Convert.ToDecimal(dtReport.Rows[j]["Dept"].ToString());
                        sumCredit = sumCredit + Convert.ToDecimal(dtReport.Rows[j]["credit"].ToString());
                        sumPrevDept = sumPrevDept + Convert.ToDecimal(dtReport.Rows[j]["Prevdept"].ToString());
                        sumPrevCredit = sumPrevCredit + Convert.ToDecimal(dtReport.Rows[j]["Prevcredit"].ToString());


                        decimal dSumBalanc = (sumDept + sumPrevDept) - (sumCredit + sumPrevCredit);
                        if (dSumBalanc > 0)
                        {
                            sumBalDept = dSumBalanc;
                            sumBalCredit = 0;
                        }
                        else
                        {
                            sumBalDept = 0;
                            sumBalCredit = dSumBalanc * -1;
                        }

                        icount = 1;


                    }


                }
                if (icount <= 0)
                    continue;




                DataRow repRow = dtReport.NewRow();
                repRow["pkid"] = dtMainAcc.Rows[i]["pkid"].ToString();
                repRow["acc_no"] = dtMainAcc.Rows[i]["acc_no"].ToString();
                repRow["acc_name"] = dtMainAcc.Rows[i]["acc_name"].ToString();
                if (dtMainAcc.Rows[i]["parent_id"].ToString() == "" || dtMainAcc.Rows[i]["parent_id"].ToString() == "0")
                {
                    repRow["parent_id"] = "0";
                    dTotalDept = dTotalDept + sumDept;
                    dTotalCredit = dTotalCredit + sumCredit;
                    dTotalPreDept = dTotalPreDept + sumPrevDept;
                    dTotalPreCredit = dTotalPreCredit + sumPrevCredit;




                    dTotalBalanceDept = dTotalBalanceDept + sumBalDept;
                    dTotalBalanceCredit = dTotalBalanceCredit + sumBalCredit;

                }
                else
                    repRow["parent_id"] = dtMainAcc.Rows[i]["parent_id"].ToString();

                repRow["Dept"] = sumDept;
                repRow["credit"] = sumCredit;
                repRow["Prevdept"] = sumPrevDept;
                repRow["Prevcredit"] = sumPrevCredit;

                dBalanceTotal = (sumDept + sumPrevDept) - (sumCredit + sumPrevCredit);

                if (dBalanceTotal < 0)
                {
                    repRow["balance_credit"] = (dBalanceTotal * -1).ToString();
                    repRow["balance_dept"] = "0";

                }
                else
                {
                    repRow["balance_dept"] = (dBalanceTotal).ToString();
                    repRow["balance_credit"] = "0";
                }

                dtReport.Rows.Add(repRow);
                iReportCount = iReportCount + 1;


            }


            DataView dv = dtReport.DefaultView;
            dv.Sort = "acc_no";
            DataTable sortedDT = dv.ToTable();

           



            report.SetDataSource(sortedDT);
            report.SetParameterValue("From", (ckbSelectDate.Checked == false ? "" : dtpFrom.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("To", (ckbSelectDate.Checked == false ? DateTime.Now.ToString("dd/MM/yyyy") : dtpTo.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("dTotalDept", dTotalDept.ToString("###,###,###,###.##"));
            report.SetParameterValue("dTotalCredit", dTotalCredit.ToString("###,###,###,###.##"));
            report.SetParameterValue("dTotalPreDept", dTotalPreDept.ToString("###,###,###,###.##"));
            report.SetParameterValue("dTotalPreCredit", dTotalPreCredit.ToString("###,###,###,###.##"));
            report.SetParameterValue("dTotalBalanceDept", dTotalBalanceDept.ToString("###,###,###,###.##"));
            report.SetParameterValue("dTotalBalanceCredit", dTotalBalanceCredit.ToString("###,###,###,###.##"));

            // report.SetParameterValue("strValueAlpha", new ConvertNumbersToArabicAlphabet(txtCreditTotal.Text).GetNumberAr());
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
