using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmFindItem : OilStationW.myForm
    {
        public string strPKid = "";
        public string strItemNo = "";
        public string strItemName = "";
        public string strUnitCost = "";
        public string strWhere = "";
        public frmFindItem()
        {
            InitializeComponent();
        }

        private void frmFindItem_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            strPKid = "";
            strItemNo = "";
            strItemName = "";
            strUnitCost = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strPKid = dgvJournalData[clmPkid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                strItemNo = dgvJournalData[clmItemNo.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                strItemName = dgvJournalData[clmItemName.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                strUnitCost = dgvJournalData[clmUnitCost.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
            {
                strPKid = "";
                strItemNo = "";
                strItemName = "";
                strUnitCost = "";
                

            }
        }

        private void dgvJournalData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                       "   itemno, itemname, itemtype,unitcost, " +
                                       "  itemnote  " +
                                       "  from items " +
                                       " where concat(concat( concat(itemno,  ifnull(itemnote, '')), itemtype), itemname)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
                dgvJournalData[clmPkid.Index,i].Value  = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmItemNo.Index, i].Value = dtJournal.Rows[i]["itemno"].ToString();
                dgvJournalData[clmItemName.Index, i].Value = dtJournal.Rows[i]["itemname"].ToString();
                dgvJournalData[clmItemType.Index, i].Value = dtJournal.Rows[i]["itemtype"].ToString();
                dgvJournalData[clmItemNote.Index, i].Value = dtJournal.Rows[i]["itemnote"].ToString();

                dgvJournalData[clmUnitCost.Index, i].Value = dtJournal.Rows[i]["unitcost"].ToString();
               

            }

        }
    }
}
