using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmItemTrans : OilStationW.myForm
    {
        public frmItemTrans()
        {
            InitializeComponent();
        }

        private void frmItemTrans_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,warehouse_name FROM warehouse where branch_id= " + glb_function.glb_strBranchPkid);
            lstWarehouses.DataSource = dtBrnch.DefaultView;
            lstWarehouses.ValueMember = "pkid";
            lstWarehouses.DisplayMember = "warehouse_name";


            DataTable dtItem = cnn.GetDataTable("select pkid,itemname from items");
            lstItems.DataSource = dtItem.DefaultView;
            lstItems.ValueMember = "pkid";
            lstItems.DisplayMember = "itemname";




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstWarehouses.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWarehouses.Focus();
                return;
            }

            if (lstItems.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الصنف");
                lstItems.Focus();
                return;
            }


            cryRepItemTrans report = new cryRepItemTrans();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();







            dtReport.Clear();

            dtReport = cnn.GetDataTable("SELECT pkid,date_format(trans_date,'%d/%m/%Y') created_date, " +
                               " trans_name, trans_no, qty, 0 Balance " +
                                " FROM item_trans " +
                                " where warehouse_id = " + lstWarehouses.SelectedValue.ToString() + " and item_id =" + lstItems.SelectedValue.ToString() +
                                " order by trans_date");


            double dBalance = 0;
            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                dtReport.Rows[i]["Balance"] = Convert.ToDouble(dtReport.Rows[i]["qty"].ToString()) + dBalance;
                dBalance = Convert.ToDouble(dtReport.Rows[i]["Balance"].ToString());
            }





            report.SetDataSource(dtReport);
            report.SetParameterValue("From", lstWarehouses.Text);
            report.SetParameterValue("To", lstItems.Text);


            frm.CrystalReportsViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
