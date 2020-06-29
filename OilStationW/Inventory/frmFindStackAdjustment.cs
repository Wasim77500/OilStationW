using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmFindStackAdjustment : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindStackAdjustment()
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
            System.Data.DataTable dtJournal = cnn.GetDataTable("SELECT h.pkid,h.stockadj_no,h.stackadj_note,w.warehouse_name " +
                                       "  FROM stockadjust_header h " +
                                        " join warehouse w on(w.pkid = h.warehosue_id) " +

                                       " where concat( concat(warehouse_name,  ifnull(stockadj_no, '')), ifnull(stackadj_note,''))  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere +
                                       "");

          
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {
                dgvJournalData.Rows.Add();

               dgvJournalData[clmPkid.Index,i].Value = dtJournal.Rows[i]["pkid"].ToString();

                dgvJournalData[clmSANo.Index, i].Value = dtJournal.Rows[i]["stockadj_no"].ToString();
                dgvJournalData[clmSAName.Index, i].Value = dtJournal.Rows[i]["warehouse_name"].ToString();

                dgvJournalData[clmSANote.Index, i].Value = dtJournal.Rows[i]["stackadj_note"].ToString();


                

            }
        }
    }
}
