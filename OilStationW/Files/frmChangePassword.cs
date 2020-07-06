using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmChangePassword : OilStationW.myForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionToMySQL conn = new ConnectionToMySQL();
            System.Data.DataTable dtLogin = conn.GetDataTable("select pkid from users " +
                " where UserFullName='" + glb_function.glb_strUserName.Trim() + "' and PASSWORD='" +  glb_function.Encrypt(txtOldPassword.Text.Trim(), true) + "'");

            if (dtLogin != null && dtLogin.Rows.Count != 0)
            {

                if (txtPassword.Text.Trim() != txtConfirmPass.Text.Trim())
                {
                    glb_function.MsgBox("كلمة السر غير متطابقة");
                    return;
                }

                int icheck = conn.TranDataToDB("update  users set PASSWORD='" +  glb_function.Encrypt(txtPassword.Text.Trim(), true) + "' where pkid=" + glb_function.glb_strUserId);
                if (icheck <= 0)
                {

                    conn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ عند تغير كلمة السر");
                    return;
                }

                conn.glb_commitTransaction();
                glb_function.MsgBox("تمت عملية تغير كلمة السر بنجاح" + "\n" + "الرجاء تسجيل الدخول للتاكد");

                this.Close();
            }
            else
            {
                glb_function.MsgBox("الرجاء التاكد من كلمة السر السابقة", "رسالة نظام");
                return;
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
