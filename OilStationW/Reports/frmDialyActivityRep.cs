using CrystalDecisions.CrystalReports.Engine;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Reports
{
    public partial class frmDialyActivityRep : OilStationW.myForm
    {
        
        public frmDialyActivityRep()
        {
            InitializeComponent();
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void mainButton2_Click(object sender, EventArgs e)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            frmReportContainer frm = new frmReportContainer();
           
            DataTable dtReport = new DataTable();

            dtReport = cnn.GetDataTable("select item_id,itemname,warehouse_id, warehouse_name, " +

                                   " ifnull((select sum(qty) from item_trans PrevT where PrevT.item_id = trans.item_id and PrevT.warehouse_id = trans.warehouse_id and PrevT.trans_date  between str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and PrevT.qty > 0),0) TodayInQty, " +
                                   " ifnull((select sum(qty) from item_trans PrevT where PrevT.item_id = trans.item_id and PrevT.warehouse_id = trans.warehouse_id and PrevT.trans_date  between str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and PrevT.qty < 0),0) TodayOutQty, " +
                                   " ifnull((select sum(qty) from item_trans PrevT where PrevT.item_id = trans.item_id and PrevT.warehouse_id = trans.warehouse_id and PrevT.trans_date  < str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')  and PrevT.qty > 0),0) PostingInQty, " +
                                   " ifnull((select sum(qty) from item_trans PrevT where PrevT.item_id = trans.item_id and PrevT.warehouse_id = trans.warehouse_id and PrevT.trans_date  < str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and PrevT.qty < 0),0) PostingOutQty," +
                                   "0 TotalInQty,0 TotalOutQty,0 RemaindQty,'1' linkR" +
                                   "  from " +
                                   " (SELECT item_id, warehouse_id " +
                                   " FROM item_trans " +
                                   " group by item_id, warehouse_id) trans " +
                                   " join warehouse w on(w.pkid = trans.warehouse_id) " +
                                   " join items i on(i.pkid= trans.item_id)");


            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                dtReport.Rows[i]["TodayOutQty"] = Convert.ToDecimal(dtReport.Rows[i]["TodayOutQty"].ToString()) * -1;
                dtReport.Rows[i]["PostingOutQty"] = Convert.ToDecimal(dtReport.Rows[i]["PostingOutQty"].ToString()) * -1;

                dtReport.Rows[i]["TotalInQty"] = Convert.ToDecimal(dtReport.Rows[i]["TodayInQty"].ToString()) + Convert.ToDecimal(dtReport.Rows[i]["PostingInQty"].ToString());
                dtReport.Rows[i]["TotalOutQty"] = Convert.ToDecimal(dtReport.Rows[i]["TodayOutQty"].ToString()) + Convert.ToDecimal(dtReport.Rows[i]["PostingOutQty"].ToString());
                dtReport.Rows[i]["RemaindQty"] = Convert.ToDecimal(dtReport.Rows[i]["TotalInQty"].ToString()) - Convert.ToDecimal(dtReport.Rows[i]["TotalOutQty"].ToString());
            }



            DataTable dtSubReport = new DataTable();
            DataTable dtAccount = new DataTable();
            dtSubReport.Columns.Add("acc_name");
            dtSubReport.Columns.Add("accType");
            dtSubReport.Columns.Add("TodayAcc");
            dtSubReport.Columns.Add("PosingAcc");
            dtSubReport.Columns.Add("TotalAcc");
            dtSubReport.Columns.Add("linkR");


            dtAccount = cnn.GetDataTable("select acc.acc_name ,'الايرادات' accType, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                       " from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and   a.Acc_no  like '6%' " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) TodayAcc, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                      "  from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('01/" + dtpDialyDate.Value.ToString("MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.AddDays(-1).ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and  a.Acc_no  like '6%' " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) PosingAcc,'0' TotalAcc,'1' linkR " +
                       " from(" +
                       " select pkid, acc_name " +
                       " from accounts acc " +
                       " where level = 5) acc " +
                        "");




            for (int i = 0; i < dtAccount.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) != 0 || Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString()) != 0)
                {
                    string str1 = dtAccount.Rows[i]["TodayAcc"].ToString();
                    string str2 = dtAccount.Rows[i]["PosingAcc"].ToString();

                    dtAccount.Rows[i]["TotalAcc"] = (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) + Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString())).ToString();

                    dtSubReport.Rows.Add();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["acc_name"] = dtAccount.Rows[i]["acc_name"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["accType"] = dtAccount.Rows[i]["accType"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TodayAcc"] = dtAccount.Rows[i]["TodayAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["PosingAcc"] = dtAccount.Rows[i]["PosingAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TotalAcc"] = dtAccount.Rows[i]["TotalAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["linkR"] = dtAccount.Rows[i]["linkR"].ToString();
                }

            }

            dtAccount.Rows.Clear();
            dtAccount = cnn.GetDataTable("select acc.acc_name ,'المصروفات' accType, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                       " from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and a.Acc_no  like '5%'  " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) TodayAcc, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                      "  from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('01/" + dtpDialyDate.Value.ToString("MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.AddDays(-1).ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and a.Acc_no  like '5%'  " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) PosingAcc,'0' TotalAcc,'1' linkR " +
                       " from(" +
                       " select pkid, acc_name " +
                       " from accounts acc " +
                       " where level = 5) acc " +
                        "");




            for (int i = 0; i < dtAccount.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) != 0 || Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString()) != 0)
                {
                    string str1 = dtAccount.Rows[i]["TodayAcc"].ToString();
                    string str2 = dtAccount.Rows[i]["PosingAcc"].ToString();

                    dtAccount.Rows[i]["TotalAcc"] = (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) + Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString())).ToString();

                    dtSubReport.Rows.Add();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["acc_name"] = dtAccount.Rows[i]["acc_name"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["accType"] = dtAccount.Rows[i]["accType"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TodayAcc"] = dtAccount.Rows[i]["TodayAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["PosingAcc"] = dtAccount.Rows[i]["PosingAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TotalAcc"] = dtAccount.Rows[i]["TotalAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["linkR"] = dtAccount.Rows[i]["linkR"].ToString();
                }

            }



            dtAccount.Rows.Clear();


            dtAccount = cnn.GetDataTable("select acc.acc_name ,'أخرى' accType, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                       " from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and a.Acc_no not like '5%' and a.Acc_no not like '6%' " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) TodayAcc, " +
                       " ifnull((select if (sum(d.main_value) < 0,(sum(d.main_value) * -1),sum(d.main_value)) " +
                      "  from journal_header h " +
                       " join journal_details d on (h.Pkid = d.header_id) " +
                       " join accounts a on (a.pkid = d.acc_id) " +
                       " where h.jour_date between str_to_date('01/" + dtpDialyDate.Value.ToString("MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpDialyDate.Value.AddDays(-1).ToString("dd/MM/yyyy") + "', '%d/%m/%Y') " +
                       " and a.Acc_no not like '5%' and a.Acc_no not like '6%' " +
                       " and d.acc_id = acc.pkid " +
                       " group by d.acc_id " +
                       " having sum(d.main_value) != 0),0) PosingAcc,'0' TotalAcc,'1' linkR " +
                       " from(" +
                       " select pkid, acc_name " +
                       " from accounts acc " +
                       " where level = 5) acc " +
                        "");




            for (int i = 0; i < dtAccount.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) != 0 || Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString()) != 0)
                {
                    string str1 = dtAccount.Rows[i]["TodayAcc"].ToString();
                    string str2 = dtAccount.Rows[i]["PosingAcc"].ToString();

                    dtAccount.Rows[i]["TotalAcc"] = (Convert.ToDecimal(dtAccount.Rows[i]["TodayAcc"].ToString()) + Convert.ToDecimal(dtAccount.Rows[i]["PosingAcc"].ToString())).ToString();

                    dtSubReport.Rows.Add();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["acc_name"] = dtAccount.Rows[i]["acc_name"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["accType"] = dtAccount.Rows[i]["accType"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TodayAcc"] = dtAccount.Rows[i]["TodayAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["PosingAcc"] = dtAccount.Rows[i]["PosingAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["TotalAcc"] = dtAccount.Rows[i]["TotalAcc"].ToString();
                    dtSubReport.Rows[dtSubReport.Rows.Count - 1]["linkR"] = dtAccount.Rows[i]["linkR"].ToString();
                }

            }






            cryRepDialyActivity report = new cryRepDialyActivity();

            //يجب اسناد التقرير الفرعي قبل التقرير الرئيسي 
            // ليتم ظهور البيانات
            report.Subreports[0].SetDataSource(dtSubReport);
            
            report.SetDataSource(dtReport);

            report.Refresh();
            frm.CrystalReportsViewer1.ReportSource = report;
            frm.CrystalReportsViewer1.Refresh();
            frm.ShowDialog();
        }
    }
}
