using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmFindForms : OilStationW.myForm
    {
        public string strPkid = "";
        public frmFindForms()
        {
            InitializeComponent();
        }

        private void frmFindForms_Load(object sender, EventArgs e)
        {
            GetFormData();
        }
        private void GetFormData()
        {
            dgvForms.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtUsers = cnn.GetDataTable("select pkid,ar_name,en_name from forms_hd  " +
                                " where ar_name like '%" + txtFormAr.Text + "%' and en_name like '%" + txtFormEn.Text + "%' ");


            for (int i = 0; i < dtUsers.Rows.Count; i++)
            {

                dgvForms.Rows.Add();

                dgvForms[clmPkid.Index, i].Value = dtUsers.Rows[i]["pkid"].ToString();
                dgvForms[clmFormAr.Index, i].Value = dtUsers.Rows[i]["ar_name"].ToString();
                dgvForms[clmFormEn.Index, i].Value = dtUsers.Rows[i]["en_name"].ToString();





            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvForms.CurrentRow.Index >= 0)
            {
                strPkid = dgvForms[0, dgvForms.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
                strPkid = "";
        }

        private void dgvForms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetFormData();
        }
    }
}
