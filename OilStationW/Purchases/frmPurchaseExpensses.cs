using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Purchases
{
    public partial class frmPurchaseExpensses : OilStationW.myForm
    {
        bool strDataFromDataSource = false;
        public frmPurchaseExpensses()
        {
            InitializeComponent();
        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
            }
        }

        private void frmPurchaseExpensses_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();
            GetData();
            if (UserTemplate.HasPrivilege("btnAdd"))
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }
        private void FillData()
        {
            strDataFromDataSource = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();



            DataTable dtAcc = cnn.GetDataTable("SELECT pkid,acc_no,acc_name FROM accounts where level=5 and stat='فعال' order by acc_no");
            lstAccNo.DataSource = dtAcc.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAcc.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;

            strDataFromDataSource = false;



        }

        private void GetData()
        {
            dgvExpensses.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtExp = cnn.GetDataTable("SELECT p.pkid,p.exp_name,p.acc_id,p.calc_Method,p.exp_value ,a.acc_no,a.acc_name " +
                       " FROM purchase_expensses p " +
                        "join accounts a on(p.acc_id = a.pkid)");
          

            for (int i = 0; i < dtExp.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[clmExpPKid.Index,i].Value= dtExp.Rows[i]["pkid"].ToString();
                dgvExpensses[clmAccId.Index, i].Value = dtExp.Rows[i]["acc_id"].ToString();
                dgvExpensses[clmAccNo.Index, i].Value = dtExp.Rows[i]["acc_no"].ToString();
                dgvExpensses[clmAccName.Index, i].Value = dtExp.Rows[i]["acc_name"].ToString();
                dgvExpensses[clmExpName.Index, i].Value = dtExp.Rows[i]["exp_name"].ToString();
                dgvExpensses[clmCalcMethod.Index, i].Value = dtExp.Rows[i]["calc_Method"].ToString();
                dgvExpensses[clmExpValue.Index, i].Value = dtExp.Rows[i]["exp_value"].ToString();
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtExpName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المصروف");
                txtExpName.Focus();
                return;
            }
            if (lstAccNo.SelectedIndex == -1 || lstAccName.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الحساب");
                lstAccNo.Focus();
                return;
            }


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("insert into purchase_expensses " +
                         " values((select ifnull(max(b.pkid),0)+1 from purchase_expensses b)" +
                         ",'" + txtExpName.Text.Trim() + "'" +
                          "," + lstAccNo.SelectedValue.ToString() +
                          ",'" + lstCalcType.Text.Trim() + "'" +
                           "," + nmbExpValue.Value.ToString() +
                        ")");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء اضافة المصروف");
                return;
            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت اضافة المصروف بنجاح");
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            txtExpName.Text = "";
            lstCalcType.Text = "مبلغ";
            nmbExpValue.Value = 0;
            GetData();
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExpensses.Rows.Count; i++)
            {
                if (ckbAll.Checked)
                    dgvExpensses[clmSelect.Index, i].Value = true;
                else
                    dgvExpensses[clmSelect.Index, i].Value = false;


            }
        }
    }
}
