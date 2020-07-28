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
            ("SELECT * FROM [2018$]", strConn);
            //("SELECT * FROM [header2018$]", strConn); 
            da.Fill(ds);
            dtCoordinats = ds.Tables[0];

            myDataGrid1 .DataSource  = dtCoordinats.DefaultView;

            myDataGrid1.Columns.Add("level","level");
            myDataGrid1.Columns.Add("acc_short_no", "acc_short_no");

            //for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            //{
            //    myDataGrid1[2, i].Value = Convert.ToDateTime(myDataGrid1[0, i].Value).ToString("dd/MM/yyyy");
            //}
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=ammar2016;userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = 0;
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                icheck = cnn.TranDataToDB("insert into accounts values(" +myDataGrid1[0,i].Value.ToString()+
                    ",'فعال'" +
                    ",sysdate()" +
                    ",1" +
                    ",'"+ myDataGrid1[0, i].Value.ToString() + "'" +
                     ",'" + myDataGrid1[1, i].Value.ToString() + "'" +
                     ","+(myDataGrid1[2, i].Value.ToString()==""?"null":"'" + myDataGrid1[2, i].Value.ToString() + "'" )+
                     ",''" +
                     ",'" + myDataGrid1[5, i].Value.ToString() + "'" +
                     ",'" + myDataGrid1[6, i].Value.ToString() + "'" +
                      ",''" +
                       ",''" +
                     ",'" + myDataGrid1[4, i].Value.ToString() + "'" +
                    ")");

                if(icheck <=0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("Error");
                    return;
                }

                
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("Save");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=ammar2016;userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = 0;
            icheck = cnn.TranDataToDB("insert into journal_header values(1" +
                ",'مرحل'" +
                ",sysdate()" +
                ",1" +
                ",1" +
                ",'1-1'" +
                 ",'قيد افتتاحي'" +
                  ",1" +
                  ",str_to_date('01/01/2016',' %d/%m/%Y')" +
                ",'الرصيد الافتتاحي 01/ 01/ 2016م'" +
                ",null" +
                ",'1-1'" +
                ")");

            if(icheck<=0)
            {
                glb_function.MsgBox("Error");
                return;
            }
            string strAmount = "";
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {

                if(myDataGrid1[6, i].Value.ToString().Trim()=="0")
                {
                    strAmount ="-"+ myDataGrid1[7, i].Value.ToString().Trim();
                }
                else
                {
                    strAmount =  myDataGrid1[6, i].Value.ToString().Trim();
                }

                icheck = cnn.TranDataToDB("insert into journal_details values((select ifnull(max(b.pkid),0)+1 from journal_details b)" +
                ",'فعال'" +
                ",sysdate()" +
                ",1" +
                ",1" +
                ",1" +
                 "," +myDataGrid1[3,i].Value.ToString()+
                  "," + strAmount+
                 "," + strAmount +
                ",1" +
                 ",'الرصيد الافتتاحي 01/ 01/ 2016م'" +
                 ",'" + myDataGrid1[13, i].Value.ToString() +"'"+
                ")");
                if (icheck<=0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("Error");
                    return;
                }
            }


            cnn.glb_commitTransaction();
            glb_function.MsgBox("Save");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                if(myDataGrid1[3,i].Value.ToString().Trim()=="")
                {
                    myDataGrid1.Rows.Remove(myDataGrid1.Rows[i]);
                    i--;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=ammar2018;userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = 0;

            string strAmount = "";
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {

                if (myDataGrid1[6, i].Value.ToString().Trim() == "0")
                {
                    strAmount = "-" + myDataGrid1[7, i].Value.ToString().Trim();
                }
                else
                {
                    strAmount = myDataGrid1[6, i].Value.ToString().Trim();
                }

                icheck = cnn.TranDataToDB("insert into journal_details values((select ifnull(max(b.pkid),0)+1 from journal_details b)" +
                ",'فعال'" +
                ",sysdate()" +
                ",1" +
                "," + myDataGrid1[10, i].Value.ToString() +
                ",1" +
                 "," + myDataGrid1[3, i].Value.ToString() +
                  "," + strAmount +
                 "," + strAmount +
                ",1" +
                 ",'"+ myDataGrid1[11, i].Value.ToString() + "'" +
                 ",'" + myDataGrid1[13, i].Value.ToString() + "'" +
                ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("Error");
                    return;
                }
            }


            cnn.glb_commitTransaction();
            glb_function.MsgBox("Save");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=ammar2018;userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = 0;
            int jourNo = 2;
            for (int i = 0; i < myDataGrid1.Rows.Count; i++)
            {
                icheck = cnn.TranDataToDB("insert into journal_header values(" +myDataGrid1[1,i].Value.ToString()+
               ",'مرحل'" +
               ",sysdate()" +
               ",1" +
               ",1" +
               ",'1-"+ jourNo + "'" +
                ",'سند قيد'" +
                 "," +(i+1)+
                 ",str_to_date('"+ myDataGrid1[2, i].Value.ToString() + "',' %d/%m/%Y')" +
               ",''" +
               ",null" +
               ",'1-"+ (i + 1) + "'" +
               ")");

                jourNo++;
                if (icheck <= 0)
                {
                    glb_function.MsgBox("Error");
                    return;
                }
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("Save");
           
        }
    }
}
