using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmFreeList : OilStationW.myForm
    {

        public string strFreeListName;
        private string strtemp;
        public frmFreeList()
        {
            InitializeComponent();
        }

        private void frmFreeList_Load(object sender, EventArgs e)
        {
            strtemp = "";
            FillListName();
            new glb_function().clearItems(this);
            lstLIST_NAME.Enabled = true;
        }
        private void FillListName()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtListName = cnn.GetDataTable("select pkid,list_name from free_list order by pkid");
            lstLIST_NAME.DataSource = dtListName;
            lstLIST_NAME.ValueMember = "pkid";
            lstLIST_NAME.DisplayMember = "list_name";

            lstLIST_NAME.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVALUE_MEMBER.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم التعريف");
                txtVALUE_MEMBER.Focus();
                return;
            }


            if (txtDISPLAY_MEMBER.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال القيمة");
                txtDISPLAY_MEMBER.Focus();
                return;
            }




            dgFreeList.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtGetid = cnn.GetDataTable("select ifnull(max(b.pkid),0)+1 from FREE_LIST b");
            txtPkId.Text = dtGetid.Rows[0][0].ToString();
            int icheck = cnn.TranDataToDB("insert into FREE_LIST values(" + txtPkId.Text + ",'" + lstLIST_NAME.Text + "','" + txtDISPLAY_MEMBER.Text + "','" + txtVALUE_MEMBER.Text + "')");

            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }
            cnn.glb_commitTransaction();
            GetData(lstLIST_NAME.Text);
            glb_function.MsgBox("تمت العملية بنجاح.");
        }

        private void GetData(string strListName)
        {

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtGetFreeListData = cnn.GetDataTable("select swid,list_name,display_member,value_member from FREE_LIST t" +
                            " where list_name = '" + strListName + "'");
            dgFreeList.Rows.Clear();
            lstLIST_NAME.Text = strListName;

            for (int i = 0; i < dtGetFreeListData.Rows.Count; i++)
            {
                dgFreeList.Rows.Add();
                dgFreeList[0, dgFreeList.Rows.Count - 1].Value = dtGetFreeListData.Rows[i]["swid"].ToString();
                dgFreeList[1, dgFreeList.Rows.Count - 1].Value = dtGetFreeListData.Rows[i]["value_member"].ToString();
                dgFreeList[2, dgFreeList.Rows.Count - 1].Value = dtGetFreeListData.Rows[i]["display_member"].ToString();


            }


        }

        private void lstLIST_NAME_TextChanged(object sender, EventArgs e)
        {
            strFreeListName = "";
            if (lstLIST_NAME.Text == null)
                return;



            if (lstLIST_NAME.Text != "")
            {
                if (strtemp == "")
                {
                    strtemp = lstLIST_NAME.Text.ToString();
                    new glb_function().clearItems(this);
                    lstLIST_NAME.Text = strtemp;
                    GetData(lstLIST_NAME.Text);
                    strtemp = "";

                }


            }
            else
                new glb_function().clearItems(this);

            strFreeListName = lstLIST_NAME.Text;
        }
    }
}
