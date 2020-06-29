using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Purchases
{
    public partial class frmVendors : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmVendors()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVendors_Load(object sender, EventArgs e)
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
            strDataFromDataSource = true ;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtVendor = cnn.GetDataTable("SELECT pkid,acc_no,acc_name " +
                       " FROM accounts " +
                       " where level = 5 and parent_id in (select pkid from accounts where acc_name in( 'موردين خارجيين','موردين محليين')) ");

            lstAccNo.DataSource = dtVendor.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtVendor.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";
            strDataFromDataSource = false;
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

        private void smallButton1_Click(object sender, EventArgs e)
        {
            frmFindVendor frm = new frmFindVendor();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPkid)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtVendor = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                               " vendorno, vendorname, addess1, addess2, tel1, tel2, " +
                                " acc_id, vendornote " +
                               " from vendors where pkid=" + strPkid);

            txtPkid.Text = dtVendor.Rows[0]["pkid"].ToString();
            txtVendorNo.Text = dtVendor.Rows[0]["vendorno"].ToString();
            txtVendorName.Text = dtVendor.Rows[0]["vendorname"].ToString();
            txtAddress1.Text = dtVendor.Rows[0]["addess1"].ToString();
            txtAddress2.Text = dtVendor.Rows[0]["addess2"].ToString();
            txtTel1.Text = dtVendor.Rows[0]["tel1"].ToString();
            txtTel2.Text = dtVendor.Rows[0]["tel2"].ToString();

            lstAccNo.SelectedValue = dtVendor.Rows[0]["acc_id"].ToString();
            lstAccName.SelectedValue = dtVendor.Rows[0]["acc_id"].ToString();
            txtVendorNote.Text = dtVendor.Rows[0]["vendornote"].ToString();

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
            if (txtVendorNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم المورد");
                txtVendorNo.Focus();
                return false;
            }
            if (txtVendorName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المورد");
                txtVendorName.Focus();
                return false;
            }





            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from vendors b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into vendors " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtVendorNo.Text.Trim() + "'" +
                          ",'" + txtVendorName.Text.Trim() + "'" +
                           ",'" + txtAddress1.Text.Trim() + "'" +
                           ",'" + txtAddress2.Text.Trim() + "'" +
                            ",'" + txtTel1.Text.Trim() + "'" +
                           ",'" + txtTel2.Text.Trim() + "'" +

                          "," + (lstAccNo.SelectedIndex == -1 ? "null" : lstAccNo.SelectedValue.ToString()) +
                           ",'" + txtVendorNote.Text.Trim() + "'" +
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

            int icheck = cnnSave.TranDataToDB("update vendors set " +

                          " created_user=" + glb_function.glb_strUserId +
                          ",vendorno='" + txtVendorNo.Text.Trim() + "'" +
                          ",vendorname='" + txtVendorName.Text.Trim() + "'" +
                           ",addess1='" + txtAddress1.Text.Trim() + "'" +
                           ",addess2='" + txtAddress2.Text.Trim() + "'" +
                            ",tel1='" + txtTel1.Text.Trim() + "'" +
                           ",tel2='" + txtTel2.Text.Trim() + "'" +
                           ",acc_id=" + (lstAccNo.SelectedIndex == -1 ? "null" : lstAccNo.SelectedValue.ToString()) +
                           ",vendornote'" + txtVendorNote.Text.Trim() + "'" +
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
