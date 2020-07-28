using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmFindProfitCenter : OilStationW.myForm
    {
        public string strAccName = "";
        public frmFindProfitCenter()
        {
            InitializeComponent();
        }

        private void frmFindProfitCenter_Load(object sender, EventArgs e)
        {
            GetAccounts();
        }
        private void GetAccounts()
        {
            dgvJournalData.Rows.Clear();



            ConnectionToMySQL cnn = new ConnectionToMySQL();
            System.Data.DataTable dtJournal = cnn.GetDataTable("select name from profitcenter");

            
            for (int i = 0; i < dtJournal.Rows.Count; i++)
            {

                dgvJournalData.Rows.Add();
                dgvJournalData[clmName.Index,i].Value = dtJournal.Rows[i]["name"].ToString();

            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtProfitCenter.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم مركز الربحية");
                txtProfitCenter.Focus();
                return;
            }
            for (int i = 0; i < dgvJournalData.Rows.Count; i++)
            {
                if (txtProfitCenter.Text.Trim() ==dgvJournalData[clmName.Index,i].Value.ToString())
                {
                    glb_function.MsgBox("مركز الربحية مدخل من قبل");
                    txtProfitCenter.Focus();
                    return;
                }
            }
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("insert into profitcenter values(" +
                "(select ifnull(max(b.pkid),0)+1 from profitcenter b)" +
                ",'" + txtProfitCenter.Text.Trim() + "'" +
                ")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت الاضافة بنجاح");

            GetAccounts();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvJournalData.CurrentRow.Index >= 0)
            {

                strAccName = dgvJournalData[clmName.Index, dgvJournalData.CurrentRow.Index].Value.ToString();
                this.Close();
            }
            else
            {

                strAccName = "";
            }
        }

        private void dgvJournalData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
