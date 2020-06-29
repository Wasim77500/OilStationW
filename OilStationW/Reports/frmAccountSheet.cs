using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmAccountSheet : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmAccountSheet()
        {
            InitializeComponent();
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
            }
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

        private void frmAccountSheet_Load(object sender, EventArgs e)
        {
            strDataFromDataSource = true ;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtAcc = cnn.GetDataTable("SELECT pkid,acc_no,acc_name FROM accounts where level=5 and stat='فعال' order by acc_no");
            lstAccNo.DataSource = dtAcc.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAcc.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            strDataFromDataSource = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstAccNo.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الحساب");
                return;
            }

            cryRepAccSheet report = new cryRepAccSheet();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();

            //TextObject txtCurrency = (TextObject)report.ReportDefinition.ReportObjects["txtReportTitel"];
            //txtCurrency.Text = "اليمن-صنعاء-شارع الرقاص" + "\n" + "رقم التلفون/ 474240-01-00967" + "\n"+"";

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
                   " where d.acc_id=" + lstAccNo.SelectedValue.ToString() + " and h.created_date < str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y') " + strStat);

                dBalance = Convert.ToDouble(dtReport.Rows[0][0].ToString());
            }
            else
                dBalance = 0;

            dtReport.Clear();

            dtReport = cnn.GetDataTable("select h.pkid,h.jour_no,h.trans_no,h.trans_name,date_format(h.jour_date,'%d/%m/%Y') jour_date,h.jour_note, " +
               " if (d.main_value > 0,d.main_value,0) Dept,if (d.main_value < 0,d.main_value * -1,0) Credit,d.jour_details,0 Balance, 'مدين' BalStat" +
                      "  from journal_header h " +
                      "  join journal_details d on(h.pkid= d.header_id)" +
                      " where d.acc_id=" + lstAccNo.SelectedValue.ToString() + strStat + strDate + " order by h.jour_date,main_value desc");


            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                dBalance = dBalance + Convert.ToDouble(dtReport.Rows[i]["Dept"].ToString()) - Convert.ToDouble(dtReport.Rows[i]["Credit"].ToString());

                if (dBalance < 0)
                {
                    dtReport.Rows[i]["Balance"] = dBalance * -1;
                    dtReport.Rows[i]["BalStat"] = "دائن";
                }
                else
                {
                    dtReport.Rows[i]["Balance"] = dBalance;
                    dtReport.Rows[i]["BalStat"] = "مدين";
                }

                //   dtReport.Rows[i]["Balance"]
            }



            report.SetDataSource(dtReport);
            report.SetParameterValue("From", (ckbSelectDate.Checked == false ? "" : dtpFrom.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("To", (ckbSelectDate.Checked == false ? DateTime.Now.ToString("dd/MM/yyyy") : dtpTo.Value.ToString("dd/MM/yyyy")));
            report.SetParameterValue("AccNo", lstAccNo.Text);
            report.SetParameterValue("AccName", lstAccName.Text);

            // report.SetParameterValue("strValueAlpha", new ConvertNumbersToArabicAlphabet(txtCreditTotal.Text).GetNumberAr());
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
