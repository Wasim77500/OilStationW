using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmAccount : OilStationW.myForm
    {
        string strAccShortNo = "";
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            if (txtPkid.Text.Trim() == "")
            {
                GetAccNo();

            }


            txtAccName.Focus();
        }

        private void GetAccNo()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            if (txtParentId.Text.Trim() == "")
                txtParentId.Text = "0";

            DataTable dtAcc = cnn.GetDataTable("SELECT ifnull(max(a.acc_short_no),0)+1 FROM accounts a where parent_id=" + txtParentId.Text);
            strAccShortNo = dtAcc.Rows[0][0].ToString();
            txtAccNo.Text = "";
            if (txtLevel.Text == "1")
            {
                txtAccNo.Text = strAccShortNo.PadLeft(1, '0');
            }
            else if (txtLevel.Text == "2")
            {
                txtAccNo.Text = txtParentAccNo.Text.Trim() + strAccShortNo.PadLeft(1, '0');
            }
            else if (txtLevel.Text == "3")
            {
                txtAccNo.Text = txtParentAccNo.Text.Trim() + strAccShortNo.PadLeft(1, '0');
            }
            else if (txtLevel.Text == "4")
            {
                txtAccNo.Text = txtParentAccNo.Text.Trim() + strAccShortNo.PadLeft(2, '0');
            }
            else if (txtLevel.Text == "5")
            {
                txtAccNo.Text = txtParentAccNo.Text.Trim() + strAccShortNo.PadLeft(5, '0');
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            if (txtPkid.Text.Trim() == "")

                AddAccount();
            else
                UpdateAccount();
        }

        private bool CheckEntries()
        {

            if (txtAccName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الحساب");
                txtAccName.Focus();
                return false;
            }


            return true;
        }

        private void AddAccount()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("insert into accounts values(" +
                "(SELECT ifnull(max(b.pkid),0)+1 FROM accounts b)" +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                ",'" + txtAccNo.Text + "'" +
                ",'" + txtAccName.Text.Trim() + "'" +
                ",'" + txtParentId.Text.Trim() + "'" +
                ",'" + txtAccNote.Text.Trim() + "'" +
                ",'" + txtLevel.Text.Trim() + "'" +
                ",'" + strAccShortNo.Trim() + "'" +
                ",'" + lstReportType.Text.Trim() + "'" +
                ",'" + lstSubAccount.Text.Trim() + "'" +
                ",'" + lstAccountNature.Text.Trim() + "'" +
                ")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء الإضافة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الإضافة بنجاح");

            txtAccNo.Text = "";
            txtAccName.Text = "";
            txtAccNote.Text = "";
            GetAccNo();
        }
        private void UpdateAccount()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("update accounts set " +
                  " Acc_Name='" + txtAccName.Text.Trim() + "'" +
                   ",ReportType='" + lstReportType.Text.Trim() + "'" +
                  ",subAccount='" + lstSubAccount.Text.Trim() + "'" +
                  ",AccountNature='" + lstAccountNature.Text.Trim() + "'" +
                  ",notes='" + txtAccNote.Text.Trim() + "'" +
                  " where pkid=" + txtPkid.Text);

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية التعديل");
                return;

            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية التعديل بنجاح");





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
