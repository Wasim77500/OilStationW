using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmUnits : OilStationW.myForm
    {
        public frmUnits()
        {
            InitializeComponent();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);


            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();

        }
        private void FillData()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtCurr = cnn.GetDataTable("select pkid,su_name from standard_unit order by pkid");
            lstStandardUnit.DataSource = dtCurr.DefaultView;
            lstStandardUnit.ValueMember = "pkid";
            lstStandardUnit.DisplayMember = "su_name";
        }
        string strtemp = "";
        private void lstStandardUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStandardUnit.SelectedValue == null)
                return;



            if (lstStandardUnit.SelectedValue.ToString() != "System.Data.DataRowView" && lstStandardUnit.SelectedValue.ToString() != "")
            {
                if (strtemp == "")
                {
                    strtemp = lstStandardUnit.SelectedValue.ToString();
                    new glb_function().clearItems(this);


                    GetData(strtemp);
                    strtemp = "";



                }


            }
        }
        private void GetData(string strSU_Pkid)
        {
            new glb_function().clearItems(this);
           
            PrepareForm();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtUnit = cnn.GetDataTable("SELECT pkid,unitname,unitvalue,ismainunit,unitnote,IsPurchaseUnit FROM units where header_id= " + strSU_Pkid);

            lstStandardUnit.SelectedValue = strSU_Pkid;

            dgvUnits.Rows.Clear();
            for (int i = 0; i < dtUnit.Rows.Count; i++)
            {
                dgvUnits.Rows.Add();
                dgvUnits[clmPkid.Index,i].Value  = dtUnit.Rows[i]["pkid"].ToString();
                dgvUnits[clmUnitName.Index, i].Value = dtUnit.Rows[i]["unitname"].ToString();
                dgvUnits[clmUnitValue.Index, i].Value = dtUnit.Rows[i]["unitvalue"].ToString();
                dgvUnits[clmIsMainCurr.Index, i].Value = (dtUnit.Rows[i]["ismainunit"].ToString() == "1" ? "نعم" : "لا");
                dgvUnits[clmUnitNote.Index, i].Value = dtUnit.Rows[i]["unitnote"].ToString();
                dgvUnits[clmIsPurchaseUnit.Index, i].Value = (dtUnit.Rows[i]["IsPurchaseUnit"].ToString() == "1" ? "نعم" : "لا");
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtSU;
            int icheck = 0;
            string strSU_Pkid = "";
            if (lstStandardUnit.SelectedIndex == -1)
            {
                dtSU = cnn.GetDataTable("select ifnull(max(b.pkid),0)+1 from standard_unit b");
                strSU_Pkid = dtSU.Rows[0][0].ToString();
                icheck = cnn.TranDataToDB("insert into standard_unit values(" +
                    "(" + strSU_Pkid + ")" +
                    ",'" + lstStandardUnit.Text.Trim() + "'" +

                    ")");

                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                    return;
                }
            }
            else
                strSU_Pkid = lstStandardUnit.SelectedValue.ToString();

            icheck = cnn.TranDataToDB("insert into units values (" +
                "(select ifnull(max(b.pkid),0)+1 from units b)" +
                ",''" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                "," + strSU_Pkid +
                ",'" + txtUnitName.Text.Trim() + "'" +
                "," + nmbUnitValue.Value.ToString() +
                ",'" + (ckbIsMainUnit.Checked == true ? "1" : "0") + "'" +
                 ",'" + txtUnitNote.Text.Trim() + "'" +
                 ",'" + (ckbIsPurchaseUnit.Checked == true ? "1" : "0") + "'" +
                ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية الاضافة");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الاضافة بنجاح");
            GetData(strSU_Pkid);
        }
    }
}
