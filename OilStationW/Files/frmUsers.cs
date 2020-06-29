using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace OilStationW.Files
{
    public partial class frmUsers : OilStationW.myForm
    {
        private DataTable dtUserData;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
            PrepareForm();
        }
        private void PrepareForm()
        {
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled  = true;


            FillTempletTree();

            
            btnUpdate.Enabled = false;
            txtPassword.Text = "123";
          
            FillBranches();
        }
        private void FillTempletTree()
        {



            tvTempletTree.Nodes.Clear();

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplet = cnn.GetDataTable("select distinct t.form_type_ar,t.form_type_en  " +
                    " from TEMPLET_HEADER t ");
            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv node = new TreeNodeAdv();
                node.Text = row["form_type_ar"].ToString();
                tvTempletTree.Nodes.Add(node);
                AddFormNode((string)row["form_type_en"], node);
            }

        }
        private void AddFormNode(string strform_type, TreeNodeAdv node)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplet = cnn.GetDataTable("select distinct t.form_arabic_name,t.form_eng_name " +
                           " from TEMPLET_HEADER t " +
                           " where form_type_en = '" + strform_type + "'");

            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv childNode = new TreeNodeAdv();
                childNode.Text = row["form_arabic_name"].ToString();
                node.Nodes.Add(childNode);
                AddChildNodes((string)row["form_eng_name"], childNode, strform_type);
            }
        }

        private void AddChildNodes(string strFormName, TreeNodeAdv node, string strFormType)
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplet = cnn.GetDataTable("select pkid, templet_name,multi_form_for_user  " +
                       " from TEMPLET_HEADER t " +
                       " where form_eng_name = '" + strFormName + "'");

            foreach (DataRow row in dtTemplet.Rows)
            {
                TreeNodeAdv childNode = new TreeNodeAdv();
                childNode.Text = row["templet_name"].ToString();

                node.Nodes.Add(childNode);
                childNode.ShowCheckBox = true;
                childNode.Tag = row["pkid"].ToString();
                childNode.HelpText = "";
                childNode.TagObject = row["multi_form_for_user"].ToString();
                childNode.Checked = false;
            }
        }

        private void FillBranches()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,Branch_name FROM branches ");
            lstBranches.DataSource = dtBrnch.DefaultView;
            lstBranches.ValueMember = "pkid";
            lstBranches.DisplayMember = "Branch_name";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
           
            PrepareForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnUpdate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار مستخدم");
                return;
            }

            glb_function.MsgBox("سيتم مسح عمل اعادة تعيين لكلمة السر" + "\n" + "كلمة السر الجديدة :" + "123");
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            int icheck = cnn.TranDataToDB("update users set PASSWORD='" +  glb_function.Encrypt("123", true) + "'" +
                                            " where pkid=" + txtPkid.Text.Trim() + "");

            if (icheck >= 0)
            {
                cnn.glb_commitTransaction();
                glb_function.MsgBox("تمت عملية تغيير كلمة السر بنجاح");

            }
            else
                glb_function.MsgBox("حدث خطأ اثناء تغير كلمة السر");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindUser frm = new frmFindUser();
            frm.ShowDialog();

            if (frm.strPKid != "")
            {
                GetData(frm.strPKid);
            }


        }

        private void GetData(string strId)
        {
            new glb_function().clearItems(this);

            PrepareForm();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtUserData = cnn.GetDataTable("SELECT pkid,userloginname,userLoginEncry,UserFullName,notes,branch_id  FROM users" +
                                  " where pkid='" + strId + "'");

            if (dtUserData != null && dtUserData.Rows.Count > 0)
            {
                txtPkid.Text = dtUserData.Rows[0]["pkid"].ToString();

                txtUserName.Text = dtUserData.Rows[0]["UserFullName"].ToString();

                txtUserLogin.Text = dtUserData.Rows[0]["userloginname"].ToString();

                txtNote.Text = dtUserData.Rows[0]["notes"].ToString();

                if (dtUserData.Rows[0]["branch_id"].ToString() == "")
                {
                    glb_function.MsgBox("لايمكن تعديل بيانات المطور");
                    btnNew_Click(null, null);
                    return;
                }
                lstBranches.SelectedValue = Convert.ToInt32(dtUserData.Rows[0]["branch_id"].ToString());

                DataTable dtTemplet = cnn.GetDataTable("select * from USER_TEMPLET where user_id=" + txtPkid.Text);

                for (int i = 0; i < dtTemplet.Rows.Count; i++)
                {
                    foreach (TreeNodeAdv item1 in tvTempletTree.Nodes)
                        foreach (TreeNodeAdv item in item1.Nodes)
                        {

                            {
                                foreach (TreeNodeAdv subItem in item.Nodes)
                                {



                                    if (subItem.Tag.ToString() == dtTemplet.Rows[i]["templet_id"].ToString())
                                        subItem.Checked = true;

                                }
                            }
                        }
                }



                if (UserTemplate.HasPrivilege("btnUpdate"))
                    btnUpdate.Enabled = true;
                btnSave.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المستخدم");
                txtUserName.Focus();
                return;
            }
            if (txtUserLogin.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رمز الدخول");
                txtUserLogin.Focus();
                return;
            }
            if (lstBranches.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الفرع");
                lstBranches.Focus();
                return;
            }

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from users b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into users " +
                          " values(" + txtPkid.Text + ",'فعال',SYSDATE() ," + glb_function.glb_strUserId +
                          ",'" + txtUserLogin.Text.Trim() + "','" +  glb_function.Encrypt(txtUserLogin.Text.Trim(), true) + "','" + txtUserName.Text.Trim() +
                          "','" +  glb_function.Encrypt(txtPassword.Text.Trim(), true) + "','" + txtNote.Text.Trim() + "'," + lstBranches.SelectedValue.ToString() + ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات المستخدم");
                return;
            }


            icheck = cnnSave.TranDataToDB("delete from USER_TEMPLET where user_id=" + txtPkid.Text);
            if (icheck < 0)
            {
                cnnSave.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات المستخدم");
                return;
            }
            GetTempletToSave();

            while (strSelectedTemp != "")
            {
                string strTemp = strSelectedTemp.Substring(0, strSelectedTemp.IndexOf(';'));
                icheck = cnnSave.TranDataToDB("insert into USER_TEMPLET values ((select ifnull(max(b.pkid),0)+1 from USER_TEMPLET b), " + txtPkid.Text + "," + strTemp + ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات المستخدم");
                    return;
                }

                strSelectedTemp = strSelectedTemp.Substring(strSelectedTemp.IndexOf(';') + 1);
            }

            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        string strSelectedTemp = "";

        private void GetTempletToSave()
        {
            strSelectedTemp = "";


            foreach (TreeNodeAdv item in tvTempletTree.Nodes)
            {
                if (item.HasChildren == true)
                    SaveTemplet(item);
            }



        }

        private void SaveTemplet(TreeNodeAdv root)
        {

            foreach (TreeNodeAdv ctrl in root.Nodes)
            {
                if (ctrl.HasChildren == true)
                    SaveTemplet(ctrl);
                else
                {
                    if (ctrl.Checked == true)
                        strSelectedTemp += ctrl.Tag.ToString() + ";";


                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء اختيار مستخدم");
                return;
            }

            if (txtUserName.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال اسم المستخدم");
                txtUserName.Focus();
                return;
            }
            if (txtUserLogin.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رمز الدخول");
                txtUserLogin.Focus();
                return;
            }
            if (lstBranches.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الفرع");
                lstBranches.Focus();
                return;
            }



            ConnectionToMySQL cnnSave = new ConnectionToMySQL();

            int icheck = cnnSave.TranDataToDB("update users " +
                          " set UserLoginName='" + txtUserLogin.Text.Trim() + "',userLoginEncry='" +  glb_function.Encrypt(txtUserLogin.Text.Trim(), true) + "',UserFullName='" + txtUserName.Text.Trim() +
                          "',Notes='" + txtNote.Text.Trim() + "',branch_id=" + lstBranches.SelectedValue.ToString() + " where pkid=" + txtPkid.Text);

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات المستخدم");
                return;
            }


            icheck = cnnSave.TranDataToDB("delete from USER_TEMPLET where user_id=" + txtPkid.Text);
            if (icheck < 0)
            {
                cnnSave.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات المستخدم");
                return;
            }
            GetTempletToSave();

            while (strSelectedTemp != "")
            {
                string strTemp = strSelectedTemp.Substring(0, strSelectedTemp.IndexOf(';'));
                icheck = cnnSave.TranDataToDB("insert into USER_TEMPLET values ((select ifnull(max(b.pkid),0)+1 from USER_TEMPLET b), " + txtPkid.Text + "," + strTemp + ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية تعديل بيانات المستخدم");
                    return;
                }

                strSelectedTemp = strSelectedTemp.Substring(strSelectedTemp.IndexOf(';') + 1);
            }

            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");

            UpdateHistory();

            GetData(txtPkid.Text);
        }

        private void UpdateHistory()
        {


            if (txtPkid.Text != dtUserData.Rows[0]["pkid"].ToString())
            {
                glb_function.MsgBox("الرجاء التأكد من عملية التحديث");
                return;
            }
            bool bCheckUpdateHistory = true;
            // insert into USER_TEMPLET values((select ifnull(max(b.pkid),0)+1 from USER_TEMPLET b),
            if (txtUserName.Text.Trim() != dtUserData.Rows[0]["UserFullName"].ToString().Trim())
                if (!glb_function.UpdateHistory("users", "UserFullName", txtPkid.Text, dtUserData.Rows[0]["UserFullName"].ToString().Trim(), txtUserName.Text.Trim(), "اسم المستخدم"))
                    bCheckUpdateHistory = false;



            if (txtUserLogin.Text.Trim() != dtUserData.Rows[0]["userloginname"].ToString().Trim())
                if (!glb_function.UpdateHistory("users", "userloginname", txtPkid.Text, dtUserData.Rows[0]["userloginname"].ToString().Trim(), txtUserLogin.Text.Trim(), "اسم الدخول"))
                    bCheckUpdateHistory = false;

            if (txtNote.Text.Trim() != dtUserData.Rows[0]["notes"].ToString())
                if (!glb_function.UpdateHistory("users", "notes", txtPkid.Text, dtUserData.Rows[0]["notes"].ToString().Trim(), txtNote.Text.Trim(), "ملاحظات"))
                    bCheckUpdateHistory = false;

            if (lstBranches.SelectedValue.ToString() != dtUserData.Rows[0]["branch_id"].ToString())
                if (!glb_function.UpdateHistory("users", "branch_id", txtPkid.Text, dtUserData.Rows[0]["branch_id"].ToString().Trim(), lstBranches.SelectedValue.ToString().Trim(), "الفرع"))
                    bCheckUpdateHistory = false;



            if (bCheckUpdateHistory == false)
                glb_function.MsgBox("حدث خطأ عند ادخال التعديل الى بيانات التتبع");

        }
    }
}
