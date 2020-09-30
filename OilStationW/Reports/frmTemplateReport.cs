using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmTemplateReport : OilStationW.myForm
    {
        private DataTable dtCoordinats;

        public frmTemplateReport()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            myDataGrid1.DataSource = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string filename;
            //if (openFileDialog1.ShowDialog() ==     DialogResult.OK)
            //{
            //    filename = openFileDialog1.FileName;
            //}
            //else
            //    return;

            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            // string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=Excel 12.0;";

            //for excel 365
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties='Excel 12.0;HDR=YES'";
            myDataGrid1.Rows.Clear();
            DataSet ds = new DataSet();

            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter
            ("SELECT * FROM [Sheet1$]", strConn);
            //("SELECT * FROM [header2018$]", strConn); 
            da.Fill(ds);
            dtCoordinats = ds.Tables[0];

            myDataGrid1.DataSource = dtCoordinats.DefaultView;
        }

        private void btnNoCordinate_Click(object sender, EventArgs e)
        {
            
           
            

            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                if (myDataGrid1[2, i].Value.ToString() == "")
                    myDataGrid1[2, i].Value = "0";
                if (myDataGrid1[3, i].Value.ToString() == "")
                    myDataGrid1[3, i].Value = "0";
                if (myDataGrid1[4, i].Value.ToString() == "")
                    myDataGrid1[4, i].Value= "0";

                if (myDataGrid1[5, i].Value.ToString() == "")
                    myDataGrid1[5, i].Value = "0";
                if (myDataGrid1[6, i].Value.ToString() == "")
                    myDataGrid1[6, i].Value = "0";

                if (myDataGrid1[7, i].Value.ToString() == "")
                    myDataGrid1[7, i].Value = "0";
               
            }
        }

        private void btnTrailBalance_Click(object sender, EventArgs e)
        {
            cryRepTrialBalance report = new cryRepTrialBalance();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("pkid");
            dtReport.Columns.Add("acc_no");
            dtReport.Columns.Add("acc_name");
            dtReport.Columns.Add("parent_id");
            dtReport.Columns.Add("Prevdept");
            dtReport.Columns.Add("Prevcredit");
            dtReport.Columns.Add("Dept");
            dtReport.Columns.Add("credit");
            dtReport.Columns.Add("balance_dept");
            dtReport.Columns.Add("balance_credit");
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                DataRow repRow = dtReport.NewRow();

                repRow["pkid"] = "";
                repRow["acc_no"] = myDataGrid1[0,i].Value.ToString();
                repRow["acc_name"] = myDataGrid1[1, i].Value.ToString();
                repRow["parent_id"] = "";
                repRow["Prevdept"] = myDataGrid1[2, i].Value.ToString();
                repRow["Prevcredit"] = myDataGrid1[3, i].Value.ToString();
                repRow["Dept"] = myDataGrid1[4, i].Value.ToString();
                repRow["credit"] = myDataGrid1[5, i].Value.ToString();
                repRow["balance_dept"] = myDataGrid1[6, i].Value.ToString();
                repRow["balance_credit"] = myDataGrid1[7, i].Value.ToString();


                dtReport.Rows.Add(repRow);
            }

            decimal dTotalDept = 0;
            decimal dTotalCredit = 0;
            decimal dTotalPreDept = 0;
            decimal dTotalPreCredit = 0;
            decimal dTotalBalanceDept = 0;
            decimal dTotalBalanceCredit = 0;
            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                if(dtReport.Rows[i]["acc_no"].ToString().Trim().Length==1)
                {
                    dTotalDept = dTotalDept + Convert.ToDecimal(dtReport.Rows[i]["Dept"].ToString().Trim());
                    dTotalCredit = dTotalCredit + Convert.ToDecimal(dtReport.Rows[i]["credit"].ToString().Trim());
                    dTotalPreDept = dTotalPreDept + Convert.ToDecimal(dtReport.Rows[i]["Prevdept"].ToString().Trim());
                    dTotalPreCredit = dTotalPreCredit + Convert.ToDecimal(dtReport.Rows[i]["Prevcredit"].ToString().Trim());
                    dTotalBalanceDept = dTotalBalanceDept + Convert.ToDecimal(dtReport.Rows[i]["balance_dept"].ToString().Trim());
                    dTotalBalanceCredit = dTotalBalanceCredit + Convert.ToDecimal(dtReport.Rows[i]["balance_credit"].ToString().Trim());
                }
            }

            report.SetDataSource(dtReport);
            report.SetParameterValue("From",dtpFrom.Value.ToString("dd/MM/yyyy"));
            report.SetParameterValue("To", dtpFrom.Value.ToString("dd/MM/yyyy"));

            report.SetParameterValue("dTotalDept", dTotalDept.ToString("###,###,###,###.#########"));
            report.SetParameterValue("dTotalCredit", dTotalCredit.ToString("###,###,###,###.#########"));
            report.SetParameterValue("dTotalPreDept", dTotalPreDept.ToString("###,###,###,###.#########"));
            report.SetParameterValue("dTotalPreCredit", dTotalPreCredit.ToString("###,###,###,###.#########"));
            report.SetParameterValue("dTotalBalanceDept", dTotalBalanceDept.ToString("###,###,###,###.#########"));
            report.SetParameterValue("dTotalBalanceCredit", dTotalBalanceCredit.ToString("###,###,###,###.#########"));

            //report.SetParameterValue("dTotalDept","0");
            //report.SetParameterValue("dTotalCredit", "0");
            //report.SetParameterValue("dTotalPreDept", "0");
            //report.SetParameterValue("dTotalPreCredit", "0");
            //report.SetParameterValue("dTotalBalanceDept", "0");
            //report.SetParameterValue("dTotalBalanceCredit", "0");




            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();

        }
    }
}
