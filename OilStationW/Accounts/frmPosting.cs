using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmPosting : OilStationW.myForm
    {
        public frmPosting()
        {
            InitializeComponent();
        }

        private void frmPosting_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }
        private void PrepareForm()
        {
            GetOperation();
            GetUnPostingData();
        }
        private void GetUnPostingData()
        {
            dgvEntries.Rows.Clear();
            string strCheckDate = "";
            if (ckbSelectDate.Checked == true)
                strCheckDate = " and jour_date between str_to_date('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y') and str_to_date('" + dtpTo.Value.ToString("dd/MM/yyyy") + "', '%d/%m/%Y')";
            if (lstOperatoin.Text.Trim() != "")
                strCheckDate = strCheckDate + " and trans_name='" + lstOperatoin.Text.Trim() + "'";

            if (txtOperationNo.Text.Trim() != "")
                strCheckDate = strCheckDate + " and jour_no='" + txtOperationNo.Text.Trim() + "'";

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtUnPosting = cnn.GetDataTable("SELECT h.PKID,h.trans_name,h.jour_no,date_format(jour_date,'%d/%m/%Y') jour_date " +
                                   " FROM journal_header h " +
                                    " where h.stat = 'فعال' " + strCheckDate);

          
            for (int i = 0; i < dtUnPosting.Rows.Count; i++)
            {
                dgvEntries.Rows.Add();
             
              dgvEntries[clmPKid.Index,i].Value = dtUnPosting.Rows[i]["pkid"].ToString();
                dgvEntries[clmJurNo.Index, i].Value = dtUnPosting.Rows[i]["jour_no"].ToString();
                dgvEntries[clmJurType.Index, i].Value = dtUnPosting.Rows[i]["trans_name"].ToString();
                dgvEntries[clmJurDate.Index, i].Value = dtUnPosting.Rows[i]["jour_date"].ToString();


               

            }



        }
        private void GetOperation()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtoperation = cnn.GetDataTable("select distinct trans_name from journal_header");

            lstOperatoin.DataSource = dtoperation.DefaultView;
            lstOperatoin.DisplayMember = "trans_name";

            lstOperatoin.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetUnPostingData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosting_Click(object sender, EventArgs e)
        {
            if (dgvEntries.Rows.Count > 0)
            {
                ConnectionToMySQL cnn = new ConnectionToMySQL();
                int icheck = 0;
                int iCount = 0;
                for (int i = 0; i < dgvEntries.Rows.Count; i++)
                {
                    if (dgvEntries[clmSelect.Index, i].Value ==null || dgvEntries[clmSelect.Index, i].Value.ToString() == "False")
                        continue;
                        

                   
                        string strPkid = dgvEntries[clmPKid.Index, i].Value.ToString();
                        icheck = cnn.TranDataToDB("update journal_header set stat='مرحل' where pkid=" + strPkid);
                        iCount++;
                        if (icheck <= 0)
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ اثناء عملية الترحيل");
                            return;
                        }

                        if (!glb_function.UpdateHistory("journal_header", "stat", strPkid, "فعال", "مرحل", "الحالة"))
                        {
                            cnn.glb_RollbackTransaction();
                            glb_function.MsgBox("حدث خطأ عند ادخال التعديل الى بيانات التتبع");
                            return;
                        }


                    
                }

                if (iCount == 0)
                {
                    glb_function.MsgBox("لم يتم تحديد اي مستند للترحيل");


                }
                else
                {
                    cnn.glb_commitTransaction();
                    glb_function.MsgBox("تمت عملية الترحيل بنجاح");
                    GetUnPostingData();
                    ckbAll.Checked = false;
                }
            }
            else
            {
                glb_function.MsgBox("لا توجد بيانات للترحيل");

            }
        }

        private void ckbSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectDate.Checked)
                gbDate.Enabled = true;
            else
                gbDate.Enabled = false;
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEntries.Rows.Count; i++)
            {
                if(ckbAll.Checked )
                dgvEntries[clmSelect.Index,i].Value  = true;
                else
                    dgvEntries[clmSelect.Index, i].Value = false;


            }
        }

        private void lstOperatoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUnPostingData();
        }
    }
}
