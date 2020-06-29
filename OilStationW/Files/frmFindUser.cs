using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmFindUser : OilStationW.myForm
    {
        public string strPKid;
        public frmFindUser()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetUsersData();
        }
        private void GetUsersData()
        {
            dgvUser.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtUsers = cnn.GetDataTable("select pkid,UserFullName,UserLoginName from users " +
                                " where concat(UserLoginName,UserFullName) like '%" + txtSearchField.Text.Trim() + "%' order  by UserFullName");

            
            for (int i = 0; i < dtUsers.Rows.Count; i++)
            {
                dgvUser.Rows.Add();

               
               dgvUser[clmPkid.Index,dgvUser.Rows.Count -1].Value  = dtUsers.Rows[i]["pkid"].ToString();
                dgvUser[clmUserName.Index, dgvUser.Rows.Count - 1].Value = dtUsers.Rows[i]["UserFullName"].ToString();
                dgvUser[clmLoginName.Index, dgvUser.Rows.Count - 1].Value = dtUsers.Rows[i]["UserLoginName"].ToString();

                
               
            }
           

        }
        private void frmFindUser_Load(object sender, EventArgs e)
        {
            strPKid = "";
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow.Index >= 0)
            {
                strPKid = dgvUser[0, dgvUser.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strPKid = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
