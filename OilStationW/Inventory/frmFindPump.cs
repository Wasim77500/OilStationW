using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmFindPump : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindPump()
        {
            InitializeComponent();
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid, stat, created_date, PumpNo, created_user, PumpName, warehouse_id, PumpNote, PumpCounter  " +
                                       "  from pumps " +
                                       " where concat(concat( concat(PumpNo,  ifnull(PumpNote, '')), ifnull(stat,'')), PumpName)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

           
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
                dgvJournalData[clmPkid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmPumpNo.Index, i].Value = dtJournal.Rows[i]["PumpNo"].ToString();
                dgvJournalData[clmPumpName.Index, i].Value = dtJournal.Rows[i]["PumpName"].ToString();
                dgvJournalData[clmStat.Index, i].Value = dtJournal.Rows[i]["stat"].ToString();
                dgvJournalData[clmPumpNote.Index, i].Value = dtJournal.Rows[i]["PumpNote"].ToString();


               

            }
        }
    }
}
