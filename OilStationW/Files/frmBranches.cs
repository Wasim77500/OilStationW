using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmBranches : OilStationW.myForm
    {
        private DataTable dtUserData;

        public frmBranches()
        {
            InitializeComponent();
        }

        private void frmBranches_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
            PrepareForm();
        }
        private void PrepareForm()
        {
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;

            btnUpdate.Enabled = false;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBranchNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الفرع");
                txtBranchNo.Focus();
                return;
            }
            if (txtBranchName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الفرع");
                txtBranchName.Focus();
                return;
            }

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from branches b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into branches " +
                          " values(" + txtPkid.Text + ",'فعال',SYSDATE() ," + glb_function.glb_strUserId +
                          ",'" + txtBranchNo.Text.Trim() +
                          "','" + txtBranchName.Text.Trim() +
                          "','" + txtNote.Text.Trim() + "')");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفرع");
                return;
            }




            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void GetData(string strId)
        {
            new glb_function().clearItems(this);

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtUserData = cnn.GetDataTable("SELECT pkid,branch_no,branch_name,notes  FROM branches" +
                                  " where pkid='" + strId + "'");

            if (dtUserData != null && dtUserData.Rows.Count > 0)
            {
                txtPkid.Text = dtUserData.Rows[0]["pkid"].ToString();

                txtBranchNo.Text = dtUserData.Rows[0]["branch_no"].ToString();

                txtBranchName.Text = dtUserData.Rows[0]["branch_name"].ToString();

                txtNote.Text = dtUserData.Rows[0]["notes"].ToString();








                if (UserTemplate.HasPrivilege("btnUpdate"))
                    btnUpdate.Enabled = true;



                btnSave.Enabled = false;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار فرع");
                return;
            }

            if (txtBranchNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الفرع");
                txtBranchNo.Focus();
                return;
            }
            if (txtBranchName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الفرع");
                txtBranchName.Focus();
                return;
            }

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();

            int icheck = cnnSave.TranDataToDB("update branches " +
                          " set " +
                          " Branch_no='" + txtBranchNo.Text.Trim() + "'" +
                          ",Branch_name='" + txtBranchName.Text.Trim() + "'" +
                          ",notes='" + txtNote.Text.Trim() + "'" +
                          " where pkid=" + txtPkid.Text.Trim());
            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات الفرع");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");



            GetData(txtPkid.Text);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindBranches frm = new frmFindBranches();
            frm.ShowDialog();

            if (frm.strPKid != "")
            {
                GetData(frm.strPKid);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
