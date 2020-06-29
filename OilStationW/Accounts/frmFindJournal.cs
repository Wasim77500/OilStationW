using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmFindJournal : OilStationW.myForm
    {
        public string strPKid = "";
        public string strWhere = "";
        public frmFindJournal()
        {
            InitializeComponent();
        }

        private void frmFindJournal_Load(object sender, EventArgs e)
        {

        }

        private void ckbSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectDate.Checked)
                gbDate.Enabled = true;
            else
                gbDate.Enabled = false;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvJournalData.Rows.Clear();
            string strCheckDate = "";
            if (ckbSelectDate.Checked == true)
                strCheckDate = " and jour_date between str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpTo.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("SELECT h.pkid,Branch_id, jour_no, trans_name, trans_id, date_format(jour_date,'%d/%m/%Y') jour_date, jour_note, Person,trans_no, " +
                                       " curr_id, acc_id, main_value, jour_value, exchange_Rate, jour_details, " +
                                       " a.acc_no, a.acc_name " +
                                       "  FROM journal_header h " +
                                       " join journal_details d on(h.Pkid = d.header_id) " +
                                       " join accounts a on(a.pkid = d.acc_id) " +
                                       " where concat(concat(concat(jour_no, concat(d.jour_details, concat(ifnull(jour_note, ''), ifnull(Person, '')))), a.acc_no), a.acc_name)  like '%" + txtSearchField.Text.Trim() + "%' " +
                                         strWhere + strCheckDate +
                                       "");

           
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
                dgvJournalData[clmPKid.Index,i].Value = dtJournal.Rows[i]["pkid"].ToString();
                dgvJournalData[clmTransNo.Index, i].Value = dtJournal.Rows[i]["trans_no"].ToString();
                dgvJournalData[clmJourDate.Index, i].Value = dtJournal.Rows[i]["jour_date"].ToString();
                dgvJournalData[clmCurrValue.Index, i].Value = (Convert.ToDouble(dtJournal.Rows[i]["jour_value"].ToString()) > 0 ? dtJournal.Rows[i]["jour_value"].ToString() : (Convert.ToDouble(dtJournal.Rows[i]["jour_value"].ToString()) * -1).ToString());
                dgvJournalData[clmAccNo.Index, i].Value = dtJournal.Rows[i]["acc_no"].ToString();
                dgvJournalData[clmAccName.Index, i].Value = dtJournal.Rows[i]["acc_name"].ToString();
                dgvJournalData[clmJourNote.Index, i].Value = dtJournal.Rows[i]["jour_note"].ToString();

                

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

                strPKid = dgvJournalData[clmPKid.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
               
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

        private void txtSearchField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(null, null);
        }
    }
}
