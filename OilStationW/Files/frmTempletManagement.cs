using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OilStationW.Files
{
    public partial class frmTempletManagement : OilStationW.myForm
    {
        public frmTempletManagement()
        {
            InitializeComponent();
        }

        private void frmTempletManagement_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgProperities.Rows.Clear();
            dgvForms.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();


            DataTable dtLocationData = cnn.GetDataTable("select pkid,ar_name,en_name,multi_form_for_user,form_type_ar,form_type_En from forms_hd where ar_name like '%" +
                                 txtFormArName.Text + "%'  ");

            for (int i = 0; i < dtLocationData.Rows.Count; i++)
            {
                dgvForms.Rows.Add();

                dgvForms[clmPkid.Index, i].Value = dtLocationData.Rows[i]["pkid"].ToString();
                dgvForms[clmFormArName.Index, i].Value = dtLocationData.Rows[i]["ar_name"].ToString();
                dgvForms[clmFormEnName.Index, i].Value = dtLocationData.Rows[i]["en_name"].ToString();
                dgvForms[clmMultiForm.Index, i].Value = dtLocationData.Rows[i]["multi_form_for_user"].ToString();
                dgvForms[clmFormTypeAr.Index, i].Value = dtLocationData.Rows[i]["form_type_ar"].ToString();
                dgvForms[clmFormTypeEn.Index, i].Value = dtLocationData.Rows[i]["form_type_En"].ToString();



            }
        }

        private void dgvForms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;
            if (e.ColumnIndex == clmShow.Index)
            {
                frmViewEditTemplet frm = new frmViewEditTemplet();
                frm.txtFormName.Text = dgvForms[clmFormArName.Index, e.RowIndex].Value.ToString();
                frm.txtFormEnName.Text = dgvForms[clmFormEnName.Index, e.RowIndex].Value.ToString();
                frm.txtFormId.Text = dgvForms[0, e.RowIndex].Value.ToString();
                frm.txtForm_type.Text = dgvForms[clmFormTypeAr.Index, e.RowIndex].Value.ToString();
                frm.ShowDialog();
                return;
            }

            GetDetailData(dgvForms[clmPkid.Index, e.RowIndex].Value.ToString());
        }
        private void GetDetailData(string strHeaderPkid)
        {
            dgProperities.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtProp = cnn.GetDataTable("select pkid,control_type,en_name,ar_name,list_id,free_list_name from forms_de t " +
                      " where t.header_id = " + strHeaderPkid + " order by pkid");


            for (int i = 0; i < dtProp.Rows.Count; i++)
            {
                dgProperities.Rows.Add();
                dgProperities[clmDetailPkId.Index, i].Value = dtProp.Rows[i]["pkid"].ToString();
                dgProperities[clmPropertyName.Index, i].Value = dtProp.Rows[i]["ar_name"].ToString();
                dgProperities[clmPropertyValue.Index, i].Value = "";
                dgProperities[clmcontrol_type.Index, i].Value = dtProp.Rows[i]["control_type"].ToString();
                dgProperities[clmListId.Index, i].Value = dtProp.Rows[i]["list_id"].ToString();
                dgProperities[clmFreeListName.Index, i].Value = dtProp.Rows[i]["free_list_name"].ToString();
                dgProperities[clmen_name.Index, i].Value = dtProp.Rows[i]["en_name"].ToString();



            }

        }

        private void dgProperities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    lstEditor.DataSource = null;
                    lstEditor.Items.Clear();
                    lstMultiEditor.Items.Clear();

                    if (dgProperities[3, e.RowIndex].Value.ToString() == "Enability")
                    {
                        lstEditor.Items.Add("تفعيل");
                        lstEditor.Items.Add("اغلاق");
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Visability")
                    {
                        lstEditor.Items.Add("اظهار");
                        lstEditor.Items.Add("اخفاء");
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Text")
                    {
                        return;
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Free List")
                    {
                        ConnectionToMySQL cnn = new ConnectionToMySQL();
                        DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                        " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                        lstEditor.DataSource = dtFreeList;
                        lstEditor.ValueMember = "value_member";
                        lstEditor.DisplayMember = "display_member";



                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "Free MultiChoices")
                    {
                        ConnectionToMySQL cnn = new ConnectionToMySQL();
                        DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                        " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                        for (int i = 0; i < dtFreeList.Rows.Count; i++)
                        {
                            lstMultiEditor.Items.Add(dtFreeList.Rows[i][0].ToString());


                        }

                        DataGridViewCell abc1 = dgProperities.CurrentCell;

                        Rectangle RECT1 = dgProperities.GetCellDisplayRectangle(abc1.ColumnIndex, abc1.RowIndex, true);

                        if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        {

                            for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                lstMultiEditor.SetItemChecked(i, false);


                            string strMult = dgProperities[2, e.RowIndex].Value.ToString();

                            string iindexx = "";

                            while (strMult != "")
                            {


                                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                                for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                {

                                    if (lstMultiEditor.Items[i].ToString() == iindexx)
                                        lstMultiEditor.SetItemChecked(i, true);
                                }


                            }
                            //***************************
                        }

                        lstMultiEditor.Tag = e.RowIndex.ToString();
                        CtlLocation(RECT1, lstMultiEditor);
                        return;


                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "List")
                    {
                        ConnectionToMySQL cnn = new ConnectionToMySQL();
                        DataTable dtListTable = cnn.GetDataTable("select  select_statement from LIST_TYPE t " +
                             " where pkid =  '" + dgProperities[4, e.RowIndex].Value.ToString() + "'");

                        DataTable dtGetList = cnn.GetDataTable(dtListTable.Rows[0][0].ToString());


                        lstEditor.DataSource = dtGetList;
                        lstEditor.ValueMember = "pkid";
                        lstEditor.DisplayMember = "name";


                        if (dgProperities[5, e.RowIndex].Value.ToString() != "")

                        {
                            DataTable dtFreeList = cnn.GetDataTable("select display_member,value_member from free_list " +
                       " where list_name = '" + dgProperities[5, e.RowIndex].Value.ToString() + "'");

                            DataRow dr;

                            for (int i = 0; i < dtFreeList.Rows.Count; i++)
                            {
                                dr = dtGetList.NewRow();
                                dr["name"] = dtFreeList.Rows[i]["display_member"].ToString();
                                dr["id"] = Convert.ToInt16(dtFreeList.Rows[i]["value_member"].ToString());
                                dtGetList.Rows.InsertAt(dr, 0);
                            }


                            //MyDataTable.Rows.InsertAt(dr, 0);


                            //dr = MyDataTable.NewRow();
                            //dr["BRANCHE_ANAME"] = "فرع المستخدم";
                            //dr["swid"] = glb_function.glb_strUserId;
                            //MyDataTable.Rows.InsertAt(dr, 0);
                        }
                    }
                    else if (dgProperities[3, e.RowIndex].Value.ToString() == "MultiChoices")
                    {
                        ConnectionToMySQL cnn = new ConnectionToMySQL();
                        DataTable dtListTable = cnn.GetDataTable("select  select_statement from LIST_TYPE t " +
                            " where pkid =  '" + dgProperities[4, e.RowIndex].Value.ToString() + "'");

                        DataTable dtGetList = cnn.GetDataTable(dtListTable.Rows[0][0].ToString());

                        for (int i = 0; i < dtGetList.Rows.Count; i++)
                        {
                            lstMultiEditor.Items.Add(dtGetList.Rows[i][1].ToString());


                        }




                        DataGridViewCell abc1 = dgProperities.CurrentCell;

                        Rectangle RECT1 = dgProperities.GetCellDisplayRectangle(abc1.ColumnIndex, abc1.RowIndex, true);

                        if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        {
                            //lstMultiEditor
                            //lstEditor.Text = dgProperities[2, e.RowIndex].Value.ToString();

                            //***************************
                            for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                lstMultiEditor.SetItemChecked(i, false);


                            string strMult = dgProperities[2, e.RowIndex].Value.ToString();

                            string iindexx = "";

                            while (strMult != "")
                            {


                                iindexx = (strMult.Substring(0, strMult.IndexOf(";")));
                                strMult = strMult.Substring(strMult.IndexOf(";") + 1);

                                for (int i = 0; i < lstMultiEditor.Items.Count; i++)
                                {

                                    if (lstMultiEditor.Items[i].ToString() == iindexx)
                                        lstMultiEditor.SetItemChecked(i, true);
                                }


                            }
                            //***************************
                        }

                        lstMultiEditor.Tag = e.RowIndex.ToString();
                        CtlLocation(RECT1, lstMultiEditor);
                        return;

                    }
                    else
                    {
                        glb_function.MsgBox("قيمة غير معروفة");
                        txtFormArName.Focus();
                        return;
                    }
                    //dgProperities.RightToLeft = RightToLeft.No;
                    DataGridViewCell abc = dgProperities.CurrentCell;

                    Rectangle RECT = dgProperities.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
                    //dgProperities.RightToLeft = RightToLeft.Yes;
                    if (dgProperities[2, e.RowIndex].Value.ToString() != "")
                        lstEditor.Text = dgProperities[2, e.RowIndex].Value.ToString();
                    lstEditor.Tag = e.RowIndex.ToString();
                    CtlLocation(RECT, lstEditor);
                }
            }
        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {


            ctrl.Top = dgProperities.Location.Y + rect.Y;
            ctrl.Left = dgProperities.Location.X + rect.X;
            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;
            ctrl.Focus();
            if (ctrl.GetType() == typeof(CheckedListBox))
                ctrl.Height = rect.Height * 5;


        }

        private void lstMultiEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void lstEditor_Leave(object sender, EventArgs e)
        {
            if (lstEditor.Visible == true)
            {
                lstEditor.Visible = false;

                dgProperities[2, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;

                if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Enability")
                {

                    if (lstEditor.Text == "تفعيل")
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "1";
                    else
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "0";



                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Visability")
                {
                    if (lstEditor.Text == "اظهار")
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "1";
                    else
                        dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = "0";


                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Text")
                {
                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;
                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "Free List")
                {

                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.Text;


                }
                else if (dgProperities[3, Convert.ToUInt16(lstEditor.Tag.ToString())].Value.ToString() == "List")
                {
                    dgProperities[7, Convert.ToUInt16(lstEditor.Tag.ToString())].Value = lstEditor.SelectedValue.ToString();

                }
                else
                {
                    glb_function.MsgBox("قيمة غير معروفة");
                    txtFormArName.Focus();
                    return;
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplte = cnn.GetDataTable("select ifnull(max(pkid),0)+1 from TEMPLET_HEADER");

            txtPkId.Text = dtTemplte.Rows[0][0].ToString();

            int icheck = cnn.TranDataToDB("insert into TEMPLET_HEADER values(" + txtPkId.Text + "," +
                        glb_function.glb_strUserId + ",sysdate(),'" + txtTempletName.Text + "','" +
                        dgvForms[clmFormEnName.Index, dgvForms.CurrentRow.Index].Value.ToString() + "','" +
                        dgvForms[clmFormArName.Index, dgvForms.CurrentRow.Index].Value.ToString() + "','" +
                        dgvForms[clmMultiForm.Index, dgvForms.CurrentRow.Index].Value.ToString() + "','" +
                       dgvForms[clmFormTypeEn.Index, dgvForms.CurrentRow.Index].Value.ToString() + "','" +
                        dgvForms[clmFormTypeAr.Index, dgvForms.CurrentRow.Index].Value.ToString() + "')");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                return;
            }
            int iProSwid = 0;
            dtTemplte.Clear();
            dtTemplte = cnn.GetDataTable("select ifnull(max(pkid),0)+1 from TEMPLET_DETAILS");
            iProSwid = Convert.ToInt16(dtTemplte.Rows[0][0].ToString());

            for (int i = 0; i < dgProperities.Rows.Count; i++)
            {



                icheck = cnn.TranDataToDB("insert into TEMPLET_DETAILS values(" + iProSwid.ToString() +
                         "," + txtPkId.Text +
                         ",'" +
                         dgProperities[clmcontrol_type.Index, i].Value.ToString() + "','" +
                        dgProperities[clmen_name.Index, i].Value.ToString() + "','" +
                         dgProperities[clmPropertyName.Index, i].Value.ToString() + "','" +
                       dgProperities[clmPropertyValue.Index, i].Value.ToString() + "'," +
                         glb_function.glb_strUserId + ",sysdate(),'" +
                         (dgProperities[clmRealValue.Index, i].Value.ToString() == "" ? dgProperities[clmPropertyValue.Index, i].Value.ToString() : dgProperities[clmRealValue.Index, i].Value.ToString()) + "')");
                iProSwid++;

                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية الحفظ");
                    return;
                }

            }
            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الحفظ بنجاح");




            dgProperities.Rows.Clear();
            txtTempletName.Text = "";
        }

        private bool CheckEntries()
        {



            int iError = 0;
            if (txtTempletName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم النموذج");
                txtTempletName.Focus();
                return false;
            }




            for (int i = 0; i < dgProperities.Rows.Count; i++)
            {
                if (dgProperities[clmPropertyValue.Index, i].Value.ToString() == "")
                {
                    glb_function.MsgBox("الرجاء اختيار قيمة لكل الخصائص");
                    return false;
                }
            }



            if (iError == 1)
                return false;

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
