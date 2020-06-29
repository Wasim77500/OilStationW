using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmAddWarehouse : OilStationW.myForm
    {
        public frmAddWarehouse()
        {
            InitializeComponent();
        }

        private void frmAddWarehouse_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnUpdate.Enabled = false;
        }
        private void FillData()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtCurr = cnn.GetDataTable("SELECT pkid,branch_name FROM branches order by pkid");
            lstBranches.DataSource = dtCurr.DefaultView;
            lstBranches.ValueMember = "pkid";
            lstBranches.DisplayMember = "branch_name";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }

        private void txtWareHouseNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectionToMySQL cnn = new ConnectionToMySQL();
                DataTable dtWarehouse = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                           " warehouse_no, warehouse_name, branch_id, warehouse_note " +
                                           " from warehouse " +
                                           "where warehouse_no= " + txtWareHouseNo.Text.Trim() +
                                           " and branch_id=" + lstBranches.SelectedValue.ToString());

                if (dtWarehouse == null || dtWarehouse.Rows.Count <= 0)
                {
                    glb_function.MsgBox("هذا المخزن غير موجود");
                    PrepareForm();
                    return;

                }
                txtPkid.Text = dtWarehouse.Rows[0]["pkid"].ToString();
                txtWareHouseNo.Text = dtWarehouse.Rows[0]["warehouse_no"].ToString();
                txtWareHouseName.Text = dtWarehouse.Rows[0]["warehouse_name"].ToString();
                lstBranches.SelectedValue = dtWarehouse.Rows[0]["branch_id"].ToString();
                txtWarehouseNote.Text = dtWarehouse.Rows[0]["warehouse_note"].ToString();

                if (UserTemplate.HasPrivilege("btnUpdate"))
                    btnUpdate.Enabled = true;

                btnSave.Enabled = false;
            }
        }
        private bool CheckEntries()
        {
            if (lstBranches.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الفرع");
                lstBranches.Focus();
                return false;
            }
            if (txtWareHouseNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم المخزن");
                txtWareHouseNo.Focus();
                return false;
            }
            if (txtWareHouseName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المخزن");
                txtWareHouseName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from warehouse b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into warehouse " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtWareHouseNo.Text.Trim() + "'" +
                         ",'" + txtWareHouseName.Text.Trim() + "'" +
                           "," + lstBranches.SelectedValue.ToString() +
                          ",'" + txtWarehouseNote.Text.Trim() + "'" +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات المستخدم");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }
        private void GetData(string strPk)
        {
            //PrepareForm();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtWarehouse = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                       " warehouse_no, warehouse_name, branch_id, warehouse_note " +
                                       " from warehouse " +
                                       "where pkid= " + strPk);


            txtPkid.Text = dtWarehouse.Rows[0]["pkid"].ToString();
            txtWareHouseNo.Text = dtWarehouse.Rows[0]["warehouse_no"].ToString();
            txtWareHouseName.Text = dtWarehouse.Rows[0]["warehouse_name"].ToString();
            lstBranches.SelectedValue = dtWarehouse.Rows[0]["branch_id"].ToString();
            txtWarehouseNote.Text = dtWarehouse.Rows[0]["warehouse_note"].ToString();

            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            btnSave.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();


            int icheck = cnnSave.TranDataToDB("update warehouse " +
                          " set " +
                          " created_user=" + glb_function.glb_strUserId +
                          ",warehouse_no='" + txtWareHouseNo.Text.Trim() + "'" +
                         ",warehouse_name='" + txtWareHouseName.Text.Trim() + "'" +
                           ",branch_id=" + lstBranches.SelectedValue.ToString() +
                          ",warehouse_note='" + txtWarehouseNote.Text.Trim() + "'" +
                         " where pkid=" + txtPkid.Text.Trim());

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات المستخدم");
                return;
            }





            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void lstBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPkid.Text = "";
            txtWareHouseNo.Text = "";
            txtWareHouseName.Text = "";
            txtWarehouseNote.Text = "";
        }
    }
}
