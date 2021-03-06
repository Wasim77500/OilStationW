﻿using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).FlatAppearance.BorderColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Chocolate;
            ((Button)sender).FlatAppearance.BorderColor = Color.Chocolate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myText1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            glb_function.glb_Year = nmbYear.Value.ToString();
            if (lstBranches.SelectedValue.ToString()=="0")
            {
                //glb_function.strDbCnnString = "server=localhost;port=3306;charset=utf8;database=ammar" + nmbYear.Value.ToString() + ";userid=root;password=ammar7700;SslMode=none;AllowPublicKeyRetrieval=True";
                 glb_function.strDbCnnString =  "server=192.168.1.7;port=3306;charset=utf8;database=headoffice"+nmbYear.Value.ToString()+";userid=root;password=alforat#Wasim5241;SslMode=none;AllowPublicKeyRetrieval=True";

             //    glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=headoffice" + nmbYear.Value.ToString() + ";userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
                glb_function.glb_DB_Name = "headoffice";
                glb_function.strArabicTitel = "الأدارة العامة" + "\n" + "اليمن - صنعاء - شارع الرقاص" + "\n" + "رقم التلفون/ 213569 -1-00967";
                glb_function.strEnglishTitel = "Head Office" + "\n"+ "Yemen - Sana'a - Alrkaas St" +"\n"+ "Tel No.    : 00967-1-213569";
            }
            else if(lstBranches.SelectedValue.ToString() == "1")
            {
               // glb_function.strDbCnnString = "server=localhost;port=3306;charset=utf8;database=ammar" + nmbYear.Value.ToString() + ";userid=root;password=ammar7700;SslMode=none;AllowPublicKeyRetrieval=True";
                 glb_function.strDbCnnString = "server=192.168.1.7;port=3306;charset=utf8;database=alobur" + nmbYear.Value.ToString() + ";userid=root;password=alforat#Wasim5241;SslMode=none;AllowPublicKeyRetrieval=True";
                  // glb_function.strDbCnnString = "server=localhost;port=3300;charset=utf8;database=alobur"+nmbYear.Value.ToString()+ ";userid=root;password=bigboss;SslMode=none;AllowPublicKeyRetrieval=True";
                glb_function.glb_DB_Name = "alobur";
                glb_function.strArabicTitel = "محطة العبور للمحروقات" + "\n" + "اليمن - صنعاء - شارع الرقاص" + "\n" + "رقم التلفون/ 213569 -1-00967";
                glb_function.strEnglishTitel = "Al-Obur Petral Station" + "\n" + "Yemen - Sana'a - Alrkaas St" + "\n" + "Tel No.    : 00967-1-213569";
            }
            else if (lstBranches.SelectedValue.ToString() == "100")
            {
               // glb_function.strDbCnnString = "server=localhost;port=3306;charset=utf8;database=ammar" + nmbYear.Value.ToString() + ";userid=root;password=ammar7700;SslMode=none;AllowPublicKeyRetrieval=True";
               //   glb_function.strDbCnnString = "server=192.168.1.7;port=3306;charset=utf8;database=ammar"+nmbYear.Value.ToString()+";userid=root;password=alforat#Wasim5241;SslMode=none;AllowPublicKeyRetrieval=True";
                glb_function.strDbCnnString = "server=localhost;port=3306;charset=utf8;database=ammar" + nmbYear.Value.ToString() + ";userid=root;password=root;SslMode=none;AllowPublicKeyRetrieval=True";
                glb_function.glb_DB_Name = "ammar";
                glb_function.strArabicTitel = "الأدارة العامة" + "\n" + "اليمن - صنعاء - شارع الرقاص" + "\n" + "رقم التلفون/ 213569 -1-00967";
                glb_function.strEnglishTitel = "Head Office" + "\n" + "Yemen - Sana'a - Alrkaas St" + "\n" + "Tel No.    : 00967-1-213569";

            }
            ConnectionToMySQL.glb_cnn = new MySqlConnection(glb_function.strDbCnnString);
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable MyDataTable;
            MyDataTable = cnn.GetDataTable("SELECT pkid,UserLoginName,UserFullName,password,notes,branch_id FROM users Where userLoginEncry = '" +  glb_function.Encrypt(txtUsername.Text.Trim(), true) + "' And Password = '" +  glb_function.Encrypt(txtPassword.Text.Trim(), true) + "'");


            if (MyDataTable != null && MyDataTable.Rows.Count != 0)
            {


                glb_function.glb_strUserName = MyDataTable.Rows[0]["UserFullName"].ToString();
                glb_function.glb_strUserId = MyDataTable.Rows[0]["pkid"].ToString();
                glb_function.glb_strBranchPkid = MyDataTable.Rows[0]["branch_id"].ToString();
                glb_function.glb_strBranchName = lstBranches.Text ;
                if (glb_function.glb_strUserId != "1")
                {
                    MyDataTable = cnn.GetDataTable("SELECT pkid currid,curr_decimal FROM currency where ismaincurr='1' ");
                    glb_function.glb_iMainCurrId = MyDataTable.Rows[0]["currid"].ToString();
                    glb_function.glb_iMainCurrDecimal = Convert.ToInt16(MyDataTable.Rows[0]["curr_decimal"].ToString());
                }



                this.Close();

            }
            else
            {
                // new glb_function().MsgBox("خطأ في اسم المستخدم او كلمة السر!", "تسجيل الدخول");
                glb_function.MsgBox("خطأ في اسم المستخدم او كلمة السر!", "تسجيل الدخول");
                txtPassword.Focus();
            }
        }

        private bool CheckEntries()
        {

            if (txtUsername.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المستخدم", "رسالة تنبية");
                txtUsername.Focus();
                return false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال كلمة السر", "رسالة تنبية");
                txtPassword.Focus();
                return false;
            }

            return true;


        }
        class Branches
        {
            public string strBranchNo { get; set; }
            public string strBranchName { get; set; }
        }
        private void FillBranches()
        {
            List<Branches> lst = new List<Branches>();

            Branches newRow = new Branches();
            newRow.strBranchNo = "0";
            newRow.strBranchName = "الأدارة العامة";
            //  newRow.strBranchName = "headoffice"+DateTime.Today.ToString("yyyy");
            lst.Add(newRow);

            newRow = new Branches();
            newRow.strBranchNo = "1";
            newRow.strBranchName = "محطة العبور";
            // newRow.strBranchName = "alobur" + DateTime.Today.ToString("yyyy");
            lst.Add(newRow);


            newRow = new Branches();
            newRow.strBranchNo = "100";
            newRow.strBranchName = "الأدارة الخارجية";
            // newRow.strBranchName = "alobur" + DateTime.Today.ToString("yyyy");
            lst.Add(newRow);



            lstBranches.DataSource = lst;
            lstBranches.ValueMember = "strBranchNo";
            lstBranches.DisplayMember = "strBranchName";

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            nmbYear.Value = DateTime.Now.Year;
            
           FillBranches();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
