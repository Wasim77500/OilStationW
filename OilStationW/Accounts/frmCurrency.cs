using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmCurrency : OilStationW.myForm
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            GetCurrency();
        }
        private void GetCurrency()
        {
            dgvCurrencies.Rows.Clear();

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtCurrData = cnn.GetDataTable("SELECT pkid,curr_name,curr_smpl,curr_decimal,curr_change_rate,curr_note,IsMainCurr,IsStockCurr " +
                " FROM currency order by pkid");
           
            for (int i = 0; i < dtCurrData.Rows.Count; i++)
            {
                dgvCurrencies.Rows.Add();
                if (dtCurrData.Rows[i]["IsMainCurr"].ToString() == "1")
                    ckbIsMainCurr.Enabled = false;
                if (dtCurrData.Rows[i]["IsStockCurr"].ToString() == "1")
                    ckbIsInvCurr.Enabled = false;

               
               dgvCurrencies[clmPkid.Index,i].Value   = dtCurrData.Rows[i]["pkid"].ToString();
                dgvCurrencies[clmCurrName.Index, i].Value = dtCurrData.Rows[i]["curr_name"].ToString();
                dgvCurrencies[clmCurrSample.Index, i].Value = dtCurrData.Rows[i]["curr_smpl"].ToString();
                dgvCurrencies[clmCurrDecimal.Index, i].Value = dtCurrData.Rows[i]["curr_decimal"].ToString();
                dgvCurrencies[clmExchangeRate.Index, i].Value = dtCurrData.Rows[i]["curr_change_rate"].ToString();
                dgvCurrencies[clmCurrNotes.Index, i].Value = dtCurrData.Rows[i]["curr_note"].ToString();
                dgvCurrencies[clmMainCurr.Index, i].Value = dtCurrData.Rows[i]["IsMainCurr"].ToString();
                dgvCurrencies[clmInvCurr.Index, i].Value = dtCurrData.Rows[i]["IsStockCurr"].ToString();

               

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("insert into currency values(" +
                "(SELECT ifnull(max(b.pkid),0)+1 FROM currency b)" +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                ",'" + txtCurr_name.Text.Trim() + "'" +
                ",'" + txtCURR_SMPL.Text.Trim() + "'" +
                ",'" + numCURR_DECIMAL.Value.ToString() + "'" +
                ",'" + numCURR_CHANGE_Rate.Value.ToString() + "'" +
                ",'" + txtCURR_NOTE.Text.Trim() + "'" +
                ",'" + (ckbIsMainCurr.Checked == true ? "1" : "0") + "'" +
                ",'" + (ckbIsInvCurr.Checked == true ? "1" : "0") + "'" +
                ")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء الإضافة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الإضافة بنجاح");

            txtCurr_name.Text = "";
            txtCURR_SMPL.Text = "";
            txtCURR_NOTE.Text = "";
            numCURR_DECIMAL.Value = 0;
            numCURR_CHANGE_Rate.Value = 0;
            ckbIsMainCurr.Checked = false;
            ckbIsInvCurr.Checked = false;
            GetCurrency();
        }

        private void dgvCurrencies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == clmUpdateCurrency.Index)
            {

                string strPkid = dgvCurrencies[clmPkid.Index, e.RowIndex].Value.ToString();
                string strIsMainCurr = dgvCurrencies[clmMainCurr.Index, e.RowIndex].Value.ToString();
                string strExhangeRate = dgvCurrencies[clmExchangeRate.Index, e.RowIndex].Value.ToString();

                if (strIsMainCurr.Trim() == "1")
                {
                    glb_function.MsgBox("لايمكن تغيير سعر صرف العملة الرئيسية");
                    GetCurrency();
                    return;
                }

                ConnectionToMySQL cnn = new ConnectionToMySQL();
                int icheck = cnn.TranDataToDB("update currency set curr_change_rate=" + strExhangeRate + " where pkid=" + strPkid);

                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء عملية التعديل");
                    return;
                }
                cnn.glb_commitTransaction();
                glb_function.MsgBox("تمت عملية التعديل بنجاح");
            }
            else if(clmExchangeRate.Index ==e.ColumnIndex )
            {
                
                DataGridViewCell abc = dgvCurrencies.CurrentCell;
                Rectangle RECT = dgvCurrencies.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                


                nmbEditor.W_ColumnName = e.ColumnIndex.ToString();
               
                nmbEditor.Tag = e.RowIndex.ToString();

              
                    if (dgvCurrencies[clmExchangeRate.Index, e.RowIndex].Value == null || dgvCurrencies[clmExchangeRate.Index, e.RowIndex].Value.ToString() == "")
                        dgvCurrencies[clmExchangeRate.Index, e.RowIndex].Value = "0";

                    nmbEditor.Value = Convert.ToDecimal(dgvCurrencies[clmExchangeRate.Index, e.RowIndex].Value.ToString());

                    CtlLocation(RECT, nmbEditor);

                
            }

        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {

          
            ctrl.Top = dgvCurrencies.Location.Y + rect.Y;
            ctrl.Left = dgvCurrencies.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;

                dgvCurrencies[Convert.ToUInt16(nmbEditor.W_ColumnName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();


            }
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
