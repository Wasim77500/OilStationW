using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmPumps : OilStationW.myForm
    {
        public frmPumps()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPumps_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();
            lstPumpStat.Text = "متاحة";
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnUpdate.Enabled = false;
        }
        private void FillData()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,warehouse_name FROM warehouse where branch_id= " + glb_function.glb_strBranchPkid);
            lstWareHouse.DataSource = dtBrnch.DefaultView;
            lstWareHouse.ValueMember = "pkid";
            lstWareHouse.DisplayMember = "warehouse_name";


            DataTable dtItem = cnn.GetDataTable("select pkid,itemname from items");
            lstItems.DataSource = dtItem.DefaultView;
            lstItems.ValueMember = "pkid";
            lstItems.DisplayMember = "itemname";




        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);


            PrepareForm();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindPump frm = new frmFindPump();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPk)
        {

            btnNew_Click(null, null);
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtWarehouse = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                     "PumpName, PumpNo, PumpCounter, warehouse_id, PumpNote,item_id " +
                                        " from pumps " +
                                       "where pkid= " + strPk);


            txtPkid.Text = dtWarehouse.Rows[0]["pkid"].ToString();
            txtPumpNo.Text = dtWarehouse.Rows[0]["PumpNo"].ToString();
            txtPumpName.Text = dtWarehouse.Rows[0]["PumpName"].ToString();
            lstPumpStat.Text = dtWarehouse.Rows[0]["stat"].ToString();
            nmbPumpCounter.Value = Convert.ToDecimal(dtWarehouse.Rows[0]["PumpCounter"].ToString());
            lstWareHouse.SelectedValue = dtWarehouse.Rows[0]["warehouse_id"].ToString();
            lstItems.SelectedValue = dtWarehouse.Rows[0]["item_id"].ToString();
            txtPumpNote.Text = dtWarehouse.Rows[0]["PumpNote"].ToString();


            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            btnSave.Enabled = false;

        }
        private bool CheckEntries()
        {
            if (txtPumpNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الطرمبة");
                txtPumpNo.Focus();
                return false;
            }
            if (txtPumpName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الطرمبة");
                txtPumpName.Focus();
                return false;
            }

            if (lstWareHouse.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWareHouse.Focus();
                return false;
            }

            if (lstItems.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الصنف");
                lstItems.Focus();
                return false;
            }


            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from pumps b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            string str = nmbPumpCounter.Value.ToString();
            int icheck = cnnSave.TranDataToDB("insert into pumps " +
                          " values(" + txtPkid.Text + "" +
                          ",'" + lstPumpStat.Text.Trim() + "'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtPumpNo.Text.Trim() + "'" +
                          ",'" + txtPumpName.Text.Trim() + "'" +
                         "," + nmbPumpCounter.Value.ToString() +
                           "," + lstWareHouse.SelectedValue.ToString() +
                          ",'" + txtPumpNote.Text.Trim() + "'" +
                            "," + lstItems.SelectedValue.ToString() +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الصنف");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();

            string str = nmbPumpCounter.Value.ToString();
            int icheck = cnnSave.TranDataToDB("update pumps set " +

                          " created_user=" + glb_function.glb_strUserId +
                          ",PumpNo='" + txtPumpNo.Text.Trim() + "'" +
                          ",PumpName='" + txtPumpName.Text.Trim() + "'" +
                           ",stat='" + lstPumpStat.Text.Trim() + "'" +
                           ",PumpCounter=" + nmbPumpCounter.Value.ToString() + "" +
                           ",warehouse_id=" + lstWareHouse.SelectedValue.ToString() +
                             ",item_id=" + lstItems.SelectedValue.ToString() +
                          ",PumpNote='" + txtPumpNote.Text.Trim() + "'" +

                         " where pkid=" + txtPkid.Text);

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات الصنف");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }
    }
}
