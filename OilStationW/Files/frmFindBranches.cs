using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmFindBranches : OilStationW.myForm
    {
        public string strPKid;

        public frmFindBranches()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetBranchData();
        }
        private void GetBranchData()
        {
            dgvBranches.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtUsers = cnn.GetDataTable("select pkid,Branch_no,branch_Name from branches " +
                                " where concat(Branch_no,branch_Name) like '%" + txtSearchField.Text.Trim() + "%'  order  by branch_no");


            for (int i = 0; i < dtUsers.Rows.Count; i++)
            {
                dgvBranches.Rows.Add();


                dgvBranches[clmPkid.Index, dgvBranches.Rows.Count - 1].Value = dtUsers.Rows[i]["pkid"].ToString();
                dgvBranches[clmBranchNo.Index, dgvBranches.Rows.Count - 1].Value = dtUsers.Rows[i]["Branch_no"].ToString();
                dgvBranches[clmBranchName.Index, dgvBranches.Rows.Count - 1].Value = dtUsers.Rows[i]["branch_Name"].ToString();



            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow.Index >= 0)
            {
                strPKid = dgvBranches[0, dgvBranches.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strPKid = "";
        }

        private void dgvBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void frmFindBranches_Load(object sender, EventArgs e)
        {

        }
    }
}
