using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmFindEmp : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindEmp()
        {
            InitializeComponent();
        }

        private void frmFindEmp_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid, stat, created_date, created_user, empno, empname, address, tel, branch_id, empNote" +
                                       "  from emp " +
                                       " where concat(concat( concat(empno,  ifnull(empNote, '')), ifnull(tel,'')), empname)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {
                dgvJournalData.Rows.Add();

               dgvJournalData[clmPkid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmEmpNo.Index, i].Value = dtJournal.Rows[i]["empno"].ToString();
                dgvJournalData[clmEmpName.Index, i].Value = dtJournal.Rows[i]["empname"].ToString();
                dgvJournalData[clmTel.Index, i].Value = dtJournal.Rows[i]["tel"].ToString();
                dgvJournalData[clmEmpNote.Index, i].Value = dtJournal.Rows[i]["empNote"].ToString();


               

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strPKid = dgvJournalData[clmPkid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();

                this.Close();
            }
            else
            {
                strPKid = "";

            }
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }
    }
}
