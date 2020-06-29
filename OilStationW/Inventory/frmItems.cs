using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmItems : OilStationW.myForm
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItems_Load(object sender, EventArgs e)
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

            DataTable dtUnit = cnn.GetDataTable("select pkid,su_name from standard_unit");
            lstUnits.DataSource = dtUnit.DefaultView;
            lstUnits.ValueMember = "pkid";
            lstUnits.DisplayMember = "su_name";


            DataTable dtType = cnn.GetDataTable("SELECT distinct itemtype FROM items");

            lstItemType.DataSource = dtType.DefaultView;

            lstItemType.DisplayMember = "itemtype";



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindItem frm = new frmFindItem();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPk)
        {

            btnNew_Click(null, null);
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtWarehouse = cnn.GetDataTable("select pkid, stat, created_date, created_user, " +
                                        " itemno, itemname, itemtype, Standard_Unit_id, UnitCost, " +
                                        " UnitSellingPrice, itemnote " +
                                        " from items " +
                                       "where pkid= " + strPk);


            txtPkid.Text = dtWarehouse.Rows[0]["pkid"].ToString();

            txtItemNo.Text = dtWarehouse.Rows[0]["itemno"].ToString();
            txtItemName.Text = dtWarehouse.Rows[0]["itemname"].ToString();
            lstItemType.Text = dtWarehouse.Rows[0]["itemtype"].ToString();
            lstUnits.SelectedValue = dtWarehouse.Rows[0]["Standard_Unit_id"].ToString();
            nmbCostValue.Value = Convert.ToDecimal(dtWarehouse.Rows[0]["UnitCost"].ToString());
            nmbSellingPriceValue.Value = Convert.ToDecimal(dtWarehouse.Rows[0]["UnitSellingPrice"].ToString());

            txtItemNote.Text = dtWarehouse.Rows[0]["itemnote"].ToString();


            if (UserTemplate.HasPrivilege("btnUpdate"))
                btnUpdate.Enabled = true;

            btnSave.Enabled = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }
        private bool CheckEntries()
        {
            if (txtItemNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الصنف");
                txtItemNo.Focus();
                return false;
            }
            if (txtItemName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم الصنف");
                txtItemName.Focus();
                return false;
            }

            if (lstItemType.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار نوع الصنف");
                lstItemType.Focus();
                return false;
            }

            if (lstUnits.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار وحدة القياس");
                lstUnits.Focus();
                return false;
            }



            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from Items b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into Items " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtItemNo.Text.Trim() + "'" +
                           ",'" + txtItemName.Text.Trim() + "'" +
                           ",'" + lstItemType.Text.Trim() + "'" +
                           "," + lstUnits.SelectedValue.ToString() +
                            "," + nmbCostValue.Value.ToString() +
                           "," + nmbSellingPriceValue.Value.ToString() +
                          ",'" + txtItemNote.Text.Trim() + "'" +
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


            int icheck = cnnSave.TranDataToDB("update Items set " +

                          " created_user=" + glb_function.glb_strUserId +

                          ",itemno='" + txtItemNo.Text.Trim() + "'" +
                           ",itemname='" + txtItemName.Text.Trim() + "'" +
                           ",itemtype='" + lstItemType.Text.Trim() + "'" +
                           ",Standard_Unit_id=" + lstUnits.SelectedValue.ToString() +
                            ",UnitCost=" + nmbCostValue.Value.ToString() +
                           ",UnitSellingPrice=" + nmbSellingPriceValue.Value.ToString() +
                          ",itemnote='" + txtItemNote.Text.Trim() + "'" +
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
