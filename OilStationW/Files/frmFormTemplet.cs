using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Files
{
    public partial class frmFormTemplet : OilStationW.myForm
    {
        public frmFormTemplet()
        {
            InitializeComponent();
        }

        private void frmFormTemplet_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);

            PrepareForm();
        }
        private void PrepareForm()
        {

            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            lstListType.Visible = false;
            FillListType();
            FillFormType();
        }
        private void FillListType()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtFill = cnn.GetDataTable("select pkid, list_name from LIST_TYPE");
            lstListType.DataSource = dtFill.DefaultView;
            lstListType.ValueMember = "pkid";
            lstListType.DisplayMember = "list_name";

            lstListType.SelectedIndex = -1;
        }
        class FormType
        {
            public string strArabicName { get; set; }
            public string strEnglishName { get; set; }
        }

        private void FillFormType()
        {
            List<FormType> lst = new List<FormType>();

            FormType newRow = new FormType();
            newRow.strArabicName = "ملف";
            newRow.strEnglishName = "File";
            lst.Add(newRow);

            newRow = new FormType();
            newRow.strArabicName = "الحسابات";
            newRow.strEnglishName = "Accounts";
            lst.Add(newRow);

            newRow = new FormType();
            newRow.strArabicName = "إدارة المخزون";
            newRow.strEnglishName = "Inventory";
            lst.Add(newRow);

            newRow = new FormType();
            newRow.strArabicName = "المشتريات";
            newRow.strEnglishName = "Purchases";
            lst.Add(newRow);

            newRow = new FormType();
            newRow.strArabicName = "المبيعات";
            newRow.strEnglishName = "Sales";
            lst.Add(newRow);

            newRow = new FormType();
            newRow.strArabicName = "التقارير";
            newRow.strEnglishName = "Reports";
            lst.Add(newRow);



            lstFormType.DataSource = lst;
            lstFormType.ValueMember = "strEnglishName";
            lstFormType.DisplayMember = "strArabicName";

        }

        private void lstControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstControlType.Text == "")
            {
                lstListType.Visible = false;
                return;
            }

            lstListType.Visible = false;
            if (lstControlType.Text == "Free List" || lstControlType.Text == "Free MultiChoices")
            {
                frmFreeList frm = new frmFreeList();
                frm.ShowDialog();
                txtFreeListId.Text = frm.strFreeListName;

                if (txtFreeListId.Text == "")
                    lstControlType.SelectedIndex = -1;
            }
            else if (lstControlType.Text == "List" || lstControlType.Text == "MultiChoices")
            {
                lstListType.Visible = true;
            }
        }
        private bool CheckDetailsEntries()
        {




            if (lstControlType.Text == "")
            {

                glb_function.MsgBox("الرجاء اختيار نوع الحقل");
                lstControlType.Focus();
                return false;
            }


            if (lstControlType.Text == "List")
            {
                if (lstListType.Text == "")
                {
                    glb_function.MsgBox("الرجاء اختيار القائمة");
                    lstListType.Focus();
                    return false;
                }
            }
            else if (lstControlType.Text == "Free List")
            {

                if (txtFreeListId.Text == "")
                {
                    glb_function.MsgBox("الرجاء ادخال القائمة الحرة");
                    lstControlType.Focus();
                    return false;
                }
            }
            //txtArName
            if (txtArName.Text == "")
            {

                glb_function.MsgBox("الرجاء ادخال الاسم بالعربي");
                txtArName.Focus();
                return false;
            }

            //txtEnName
            if (txtEnName.Text == "")
            {

                glb_function.MsgBox("الرجاء ادخال الاسم بالانجليزي");
                txtEnName.Focus();
                return false;
            }




            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDetailsEntries())
                return;

            dgvProperities.Rows.Add();
            dgvProperities[0, dgvProperities.Rows.Count - 1].Value = "";
            dgvProperities[1, dgvProperities.Rows.Count - 1].Value = lstControlType.Text;
            dgvProperities[2, dgvProperities.Rows.Count - 1].Value = txtArName.Text;
            dgvProperities[3, dgvProperities.Rows.Count - 1].Value = txtEnName.Text;
            dgvProperities[4, dgvProperities.Rows.Count - 1].Value = txtPROPERITY_NOTE.Text;
            dgvProperities[5, dgvProperities.Rows.Count - 1].Value = (lstListType.SelectedIndex == -1 ? "" : lstListType.SelectedValue.ToString());
            dgvProperities[6, dgvProperities.Rows.Count - 1].Value = lstListType.Text;
            dgvProperities[7, dgvProperities.Rows.Count - 1].Value = txtFreeListId.Text;

            txtArName.Text = "";
            txtEnName.Text = "";
            txtPROPERITY_NOTE.Text = "";
            lstListType.SelectedIndex = -1;
            lstListType.Text = "";
            txtFreeListId.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }
        private bool CheckEntries()
        {




            if (txtAR_NAME.Text == "")
            {

                glb_function.MsgBox("الرجاء ادخال اسم الشاشة بالعربي");
                txtAR_NAME.Focus();
                return false;
            }


            //txtFormInProgram
            if (txtEN_NAME.Text == "")
            {

                glb_function.MsgBox("الرجاء ادخال اسم الشاشة في البرنامج");
                txtEN_NAME.Focus();
                return false;
            }







            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplte = cnn.GetDataTable("select ifnull(max(b.pkid),0)+1 from FORMS_hd b");

            txtPkid.Text = dtTemplte.Rows[0][0].ToString();






            int icheck = cnn.TranDataToDB("insert into FORMS_hd values(" + txtPkid.Text + ",'" + txtAR_NAME.Text + "','" + txtEN_NAME.Text + "','" + (ckbMULTI_FORM_FOR_USER.Checked == true ? "1" : "0") + "','" +lstFormType.SelectedValue.ToString()+ "','" + lstFormType.Text.Trim() + "')");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية");
                return;
            }




            for (int i = 0; i < dgvProperities.Rows.Count; i++)
            {
                if (dgvProperities[clmPkid.Index,i].Value.ToString() == "")
                {


                    icheck = cnn.TranDataToDB("insert into FORMs_de values((select ifnull(max(b.pkid),0)+1 from FORMs_de b)," + txtPkid.Text + ",'" + dgvProperities[clmFieldType.Index, i].Value.ToString()  + "','" + dgvProperities[clmFieldNameEn.Index, i].Value.ToString()  + "','" + dgvProperities[clmFieldNameAr.Index, i].Value.ToString()  + "'," + (dgvProperities[clmListTypeId.Index, i].Value.ToString()==""?"null": dgvProperities[clmListTypeId.Index, i].Value.ToString())  + ",'" + dgvProperities[clmFreeList.Index, i].Value.ToString()  + "','" + dgvProperities[clmNote.Index, i].Value.ToString() + "')");

                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء العملية");
                        return;
                    }
                }
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text.Trim());
        }

        private void GetData(string strPkid)
        {
            new glb_function().clearItems(this);
            PrepareForm();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtLocation = cnn.GetDataTable("select * from forms_hd where pkid=" + strPkid);

            txtPkid.Text = strPkid;
            txtAR_NAME.Text = dtLocation.Rows[0]["AR_NAME"].ToString();


            txtEN_NAME.Text = dtLocation.Rows[0]["EN_NAME"].ToString();


            ckbMULTI_FORM_FOR_USER.Checked = (dtLocation.Rows[0]["MULTI_FORM_FOR_USER"].ToString() == "1" ? true : false);

            lstFormType.Text = dtLocation.Rows[0]["form_type_AR"].ToString();

            GetProperitiesData();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void GetProperitiesData()
        {
            dgvProperities.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtPorp = cnn.GetDataTable("select pkid, control_type, en_name, ar_name, " +
                       "  list_id, (select l.list_name from list_type l where l.pkid = list_id) listtype, " +
                         " free_list_name, properity_note " +
                         " from forms_de " +
                        "  where header_id = " + txtPkid.Text);

          
            for (int i = 0; i < dtPorp.Rows.Count; i++)
            {
                

              
                dgvProperities.Rows.Add();
                dgvProperities[clmPkid.Index, i].Value = dtPorp.Rows[i]["pkid"].ToString();
                dgvProperities[clmFieldType.Index, i].Value = dtPorp.Rows[i]["control_type"].ToString();
                dgvProperities[clmFieldNameEn.Index, i].Value = dtPorp.Rows[i]["en_name"].ToString();
                dgvProperities[clmFieldNameAr.Index, i].Value = dtPorp.Rows[i]["ar_name"].ToString();
                dgvProperities[clmNote.Index, i].Value = dtPorp.Rows[i]["properity_note"].ToString();
                dgvProperities[clmListTypeId.Index, i].Value = dtPorp.Rows[i]["list_id"].ToString();
                dgvProperities[clmListType.Index, i].Value = dtPorp.Rows[i]["listtype"].ToString();
                dgvProperities[clmFreeList.Index, i].Value = dtPorp.Rows[i]["free_list_name"].ToString();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;
            DataTable dtTemplte = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();







            int icheck = cnn.TranDataToDB("update FORMS_hd set AR_NAME='" + txtAR_NAME.Text + "',EN_NAME='" + txtEN_NAME.Text + "',MULTI_FORM_FOR_USER='" + (ckbMULTI_FORM_FOR_USER.Checked == true ? "1" : "0") + "',form_type_en='" + lstFormType.SelectedValue.ToString() + "',form_type_ar='" + lstFormType.Text.Trim() + "' where pkid=" + txtPkid.Text);
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء العملية");
                return;
            }
            for (int i = 0; i < dgvProperities.Rows.Count; i++)
            {
                if (dgvProperities[clmPkid.Index, i].Value.ToString() == "")
                {


                    icheck = cnn.TranDataToDB("insert into FORMs_de values((select ifnull(max(b.pkid),0)+1 from FORMs_de b)," + txtPkid.Text + ",'" + dgvProperities[clmFieldType.Index, i].Value.ToString() + "','" + dgvProperities[clmFieldNameEn.Index, i].Value.ToString() + "','" + dgvProperities[clmFieldNameAr.Index, i].Value.ToString() + "'," + dgvProperities[clmListTypeId.Index, i].Value.ToString() + ",'" + dgvProperities[clmFreeList.Index, i].Value.ToString() + "','" + dgvProperities[clmNote.Index, i].Value.ToString() + "')");

                    if (icheck <= 0)
                    {
                        cnn.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء العملية");
                        return;
                    }
                }
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");



            GetData(txtPkid.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindForms frm = new frmFindForms();

            frm.ShowDialog();

            if (frm.strPkid.Trim() != "")
            {

                txtPkid.Text = frm.strPkid;
                GetData(txtPkid.Text);
            }
        }

        private void dgvProperities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (glb_function.MsgBox("هل تريد الحذف بالفعل؟", "", true) == false)
                    return;

                if (dgvProperities[clmPkid.Index, e.RowIndex].Value.ToString() == "")
                    dgvProperities.Rows.Remove(dgvProperities.CurrentRow);

                else
                {
                    ConnectionToMySQL cnn = new ConnectionToMySQL();
                    int icheck = cnn.TranDataToDB("delete from forms_de where pkid=" + dgvProperities[0, e.RowIndex].Value.ToString());

                    if (icheck <= 0)
                    {
                        glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                        return;
                    }
                    cnn.glb_commitTransaction();
                    dgvProperities.Rows.Remove(dgvProperities.CurrentRow);
                }

                glb_function.MsgBox("تمت العملية بنجاح");



            }
        }
    }
}
