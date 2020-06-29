using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Sales
{
    public partial class frmCustomers : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
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
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtVendor = cnn.GetDataTable("SELECT pkid,acc_no,acc_name " +
                       " FROM accounts " +
                       " where level = 5 and parent_id in (select pkid from accounts where acc_name in('العملاء')) ");

            lstAccNo.DataSource = dtVendor.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtVendor.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindCustomer frm = new frmFindCustomer();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPkid)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtVendor = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                               " Custno, Custname, addess1, addess2, tel1, tel2, " +
                                " acc_id, Custnote " +
                               " from customers where pkid=" + strPkid);

            txtPkid.Text = dtVendor.Rows[0]["pkid"].ToString();
            txtCustNo.Text = dtVendor.Rows[0]["Custno"].ToString();
            txtCustName.Text = dtVendor.Rows[0]["Custname"].ToString();
            txtAddress1.Text = dtVendor.Rows[0]["addess1"].ToString();
            txtAddress2.Text = dtVendor.Rows[0]["addess2"].ToString();
            txtTel1.Text = dtVendor.Rows[0]["tel1"].ToString();
            txtTel2.Text = dtVendor.Rows[0]["tel2"].ToString();

            lstAccNo.SelectedValue = dtVendor.Rows[0]["acc_id"].ToString();
            lstAccName.SelectedValue = dtVendor.Rows[0]["acc_id"].ToString();
            txtCustNote.Text = dtVendor.Rows[0]["Custnote"].ToString();

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
            if (txtCustNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم المورد");
                txtCustNo.Focus();
                return false;
            }
            if (txtCustName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المورد");
                txtCustName.Focus();
                return false;
            }





            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from customers b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into customers " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtCustNo.Text.Trim() + "'" +
                          ",'" + txtCustName.Text.Trim() + "'" +
                           ",'" + txtAddress1.Text.Trim() + "'" +
                           ",'" + txtAddress2.Text.Trim() + "'" +
                            ",'" + txtTel1.Text.Trim() + "'" +
                           ",'" + txtTel2.Text.Trim() + "'" +

                          "," + (lstAccNo.SelectedIndex == -1 ? "null" : lstAccNo.SelectedValue.ToString()) +
                           ",'" + txtCustNote.Text.Trim() + "'" +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات المورد");
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

            int icheck = cnnSave.TranDataToDB("update customers set " +

                          " created_user=" + glb_function.glb_strUserId +
                          ",custno='" + txtCustNo.Text.Trim() + "'" +
                          ",custname='" + txtCustName.Text.Trim() + "'" +
                           ",addess1='" + txtAddress1.Text.Trim() + "'" +
                           ",addess2='" + txtAddress2.Text.Trim() + "'" +
                            ",tel1='" + txtTel1.Text.Trim() + "'" +
                           ",tel2='" + txtTel2.Text.Trim() + "'" +
                           ",acc_id=" + (lstAccNo.SelectedIndex == -1 ? "null" : lstAccNo.SelectedValue.ToString()) +
                           ",custnote='" + txtCustNote.Text.Trim() + "'" +
                         " where pkid=" + txtPkid.Text);

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات المورد");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }
    }
}
