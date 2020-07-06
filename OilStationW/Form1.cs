using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtCoordinats;
        private void button1_Click(object sender, EventArgs e)
        {
            myDataGrid1.DataSource  = null;
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
            ("SELECT * FROM [Sheet3$]", strConn);

            da.Fill(ds);
            dtCoordinats = ds.Tables[0];

            myDataGrid1 .DataSource  = dtCoordinats.DefaultView;

            myDataGrid1.Columns.Add("level","level");
            myDataGrid1.Columns.Add("acc_short_no", "acc_short_no");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                if(myDataGrid1[0,i].Value.ToString().Trim().Length ==1   )
                {
                    myDataGrid1["level", i].Value = "1";
                    myDataGrid1["acc_short_no", i].Value = myDataGrid1[0, i].Value.ToString().Trim();
                }
                else if (myDataGrid1[0, i].Value.ToString().Trim().Length == 2)
                {
                    myDataGrid1["level", i].Value = "2";
                    myDataGrid1["acc_short_no", i].Value = myDataGrid1[0, i].Value.ToString().Trim().Substring(1);
                }
                else if (myDataGrid1[0, i].Value.ToString().Trim().Length == 3)
                {
                    myDataGrid1["level", i].Value = "3";
                    myDataGrid1["acc_short_no", i].Value = myDataGrid1[0, i].Value.ToString().Trim().Substring(2);
                }
                else if (myDataGrid1[0, i].Value.ToString().Trim().Length == 5)
                {
                    myDataGrid1["level", i].Value = "4";
                    myDataGrid1["acc_short_no", i].Value = myDataGrid1[0, i].Value.ToString().Trim().Substring(3);
                }
                else if (myDataGrid1[0, i].Value.ToString().Trim().Length == 9)
                {
                    myDataGrid1["level", i].Value = "5";
                    myDataGrid1["acc_short_no", i].Value = myDataGrid1[0, i].Value.ToString().Trim().Substring(5);
                }

            }
        }
    }
}
