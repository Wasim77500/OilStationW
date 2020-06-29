using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmEmp : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmEmp()
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

        private void frmEmp_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();

            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnUpdate.Enabled = false;
        }
        private void FillData()
        {
            strDataFromDataSource = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,Branch_name FROM branches ");
            lstBranches.DataSource = dtBrnch.DefaultView;
            lstBranches.ValueMember = "pkid";
            lstBranches.DisplayMember = "Branch_name";


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

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindEmp frm = new frmFindEmp();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPk)
        {

            btnNew_Click(null, null);
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtWarehouse = cnn.GetDataTable("select pkid, stat, created_date, created_user, empno, " +
                                        " empname, address, tel, branch_id, empNote,acc_id " +
                                        " from emp " +
                                       "where pkid= " + strPk);


            txtPkid.Text = dtWarehouse.Rows[0]["pkid"].ToString();
            txtEmpNo.Text = dtWarehouse.Rows[0]["empno"].ToString();
            txtEmpName.Text = dtWarehouse.Rows[0]["empname"].ToString();
            txtAddress.Text = dtWarehouse.Rows[0]["address"].ToString();
            txtTel.Text = dtWarehouse.Rows[0]["tel"].ToString();
            lstBranches.SelectedValue = dtWarehouse.Rows[0]["branch_id"].ToString();
            lstAccNo.SelectedValue = dtWarehouse.Rows[0]["acc_id"].ToString();
            lstAccName.SelectedValue = dtWarehouse.Rows[0]["acc_id"].ToString();
            txtEmpNote.Text = dtWarehouse.Rows[0]["empNote"].ToString();


            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            btnSave.Enabled = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }
        private bool CheckEntries()
        {
            if (txtEmpNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم العامل");
                txtEmpNo.Focus();
                return false;
            }
            if (txtEmpName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم العامل");
                txtEmpName.Focus();
                return false;
            }

            if (lstBranches.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الفرع");
                lstBranches.Focus();
                return false;
            }

            if (lstAccNo.SelectedIndex != -1 || lstAccName.SelectedIndex != -1)
            {
                if (lstAccNo.SelectedValue.ToString() != lstAccName.SelectedValue.ToString())
                {
                    glb_function.MsgBox("الرجاء التاكد أن رقم الحساب مطابق لاسم الحساب");
                    lstAccNo.Focus();
                    return false;
                }
            }
            else
            {
                glb_function.MsgBox("الرجاء التاكد من اختيار الحساب");
                lstAccNo.Focus();
                return false;
            }



            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from emp b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into emp " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtEmpNo.Text.Trim() + "'" +
                           ",'" + txtEmpName.Text.Trim() + "'" +
                           ",'" + txtAddress.Text.Trim() + "'" +
                             ",'" + txtTel.Text.Trim() + "'" +
                           "," + lstBranches.SelectedValue.ToString() +

                          ",'" + txtEmpNote.Text.Trim() + "'" +
                         "," + lstAccNo.SelectedValue.ToString() +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات العامل");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();


            int icheck = cnnSave.TranDataToDB("update emp set " +

                          " created_user=" + glb_function.glb_strUserId +
                          ",empno='" + txtEmpNo.Text.Trim() + "'" +
                          ",empname='" + txtEmpName.Text.Trim() + "'" +
                           ",address='" + txtAddress.Text.Trim() + "'" +
                           ",tel='" + txtTel.Text.Trim() + "'" +
                           ",branch_id=" + lstBranches.SelectedValue.ToString() +
                          ",empNote='" + txtEmpNote.Text.Trim() + "'" +
                           ",acc_id=" + lstAccNo.SelectedValue.ToString() +
                         " where pkid=" + txtPkid.Text);

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات العامل");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
