using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Accounts
{
    public partial class frmAccountTree : OilStationW.myForm
    {
        DataTable dtPrepareAccTree;
        public frmAccountTree()
        {
            InitializeComponent();
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
            PrepareForm();
        }
        private void PrepareForm()
        {
            FillAccountTree();
            txtLevel.Text = "0";
            txtParentId.Text = "0";
            txtNodeName.Focus();
        }
        private void FillAccountTree()
        {

            dtPrepareAccTree = new DataTable();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
           
            dtPrepareAccTree.Rows.Clear();

         
            dtPrepareAccTree = cnn.GetDataTable("SELECT pkid,stat,created_date,created_user,acc_no,acc_name" +
                ",ifnull(parent_id,0) parent_id ,notes,level,Acc_short_no,ReportType,subAccount,AccountNature " +
                                " FROM accounts order by acc_no");

            //tvAccTreeMain.Nodes.Clear();
            tvAccounts.Nodes.Clear();
            PopulateTreeViewMain(0, null);



        }

        private void PopulateTreeViewMain(int parentId, TreeNode parentNode)

        {


            TreeNode childNode;


            foreach (DataRow dr in dtPrepareAccTree.Select("[parent_id]=" + parentId))

            {


                TreeNode t = new TreeNode();
                t.Text = dr["acc_no"].ToString() + " - " + dr["acc_name"].ToString();
                // t.Name = dr["acc_no"].ToString();
                t.Tag = dr["acc_name"].ToString();
                t.ToolTipText = dr["pkid"].ToString();

                t.Tag = dtPrepareAccTree.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tvAccounts.Nodes.Add(t);
                    childNode = t;

                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }
               
                PopulateTreeViewMain(Convert.ToInt32(dr["pkid"].ToString()), childNode);

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();

            // ClearTreeSelection. ClearTreeViewSelection(tvAccounts);
            FillAccountTree();
        }

        private void tvAccounts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var item = (e.Node as TreeNode  );
            if (item == null)
                return;

            string str = item.ToolTipText.ToString();

            // txtAccName.Text = item.Tag.ToString();

            foreach (DataRow dr in dtPrepareAccTree.Select("[pkid]=" + str))

            {


                txtPkid.Text = str;
                txtAccNo.Text = dr["acc_no"].ToString();
                txtAccName.Text = dr["acc_name"].ToString();
                txtAccNote.Text = dr["notes"].ToString();
                txtParentId.Text = dr["parent_id"].ToString();
                txtLevel.Text = dr["level"].ToString();
                lstReportType.Text = dr["ReportType"].ToString();
                lstSubAccount.Text = dr["subAccount"].ToString();
                lstAccountNature.Text = dr["AccountNature"].ToString();
                txtAccShoreNo.Text = dr["Acc_short_no"].ToString();

                if (txtParentId.Text != "0")
                    foreach (DataRow drParent in dtPrepareAccTree.Select("[pkid]=" + txtParentId.Text))
                    {
                        txtParentAccNo.Text = drParent["acc_no"].ToString();
                        txtAccParentName.Text = drParent["acc_name"].ToString();
                    }



            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int icheckFind = 0;
        private void btnFind_Click(object sender, EventArgs e)
        {

            tvAccounts.CollapseAll();
            if(txtNodeName.Text.Trim()=="")
            {
                glb_function.MsgBox("الرجاء ادخال اسم او رقم الحساب او جزء منه");
                return;
            }
            SearchTree(tvAccounts.Nodes, txtNodeName.Text);

            if (icheckFind == 0)
                glb_function.MsgBox("لم يتم العثور على اسم مطابق");


            icheckFind = 0;
        }

        private TreeNodeAdv SearchTree(TreeNodeCollection nodes, string searchtext)
        {
            foreach (TreeNode node in nodes)
            {

                //if (node.Text == searchtext)
                if (node.Text.Contains(searchtext))
                {


                    // node.TextColor = System.Drawing.Color.Red;
                    node.ForeColor = System.Drawing.Color.Red;

                    tvAccounts.SelectedNode = node;
                    icheckFind++;

                    // return node;

                }
                else

                    node.ForeColor = System.Drawing.Color.Black;
                SearchTree(node.Nodes, searchtext);
            }

            return null;
        }

        private void txtNodeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();

            frm.txtPkid.Text = "";
            if (txtLevel.Text != "5")
            {
                frm.txtLevel.Text = (Convert.ToInt32(txtLevel.Text) + 1).ToString();
                frm.txtParentId.Text = txtPkid.Text;
                frm.txtParentAccName.Text = txtAccName.Text;
                frm.txtParentAccNo.Text = txtAccNo.Text;
            }
            else
            {
                frm.txtLevel.Text = (Convert.ToInt32(txtLevel.Text)).ToString();
                frm.txtParentId.Text = txtParentId.Text;
                frm.txtParentAccName.Text = txtAccParentName.Text;
                frm.txtParentAccNo.Text = txtParentAccNo.Text;
            }


            frm.ShowDialog();
            btnNew_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء تحديد الحساب");
                return;
            }


            frmAccount frm = new frmAccount();
            frm.txtPkid.Text = txtPkid.Text;
            frm.txtAccNo.Text = txtAccNo.Text;
            frm.txtAccName.Text = txtAccName.Text;
            frm.txtAccNote.Text = txtAccNote.Text;
            frm.txtLevel.Text = (Convert.ToInt32(txtLevel.Text)).ToString();
            frm.txtParentId.Text = txtParentId.Text;
            frm.txtParentAccName.Text = txtAccParentName.Text;
            frm.txtParentAccNo.Text = txtParentAccNo.Text;
            frm.lstReportType.Text = lstReportType.Text;
            frm.lstSubAccount.Text = lstSubAccount.Text;
            frm.lstAccountNature.Text = lstAccountNature.Text;
            frm.ShowDialog();
            FillAccountTree();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء تحديد الحساب");
                return;
            }



            //if (txtLevel.Text.Trim() != "5")
            //{
            //    glb_function.MsgBox("لايمكن حذف حساب رئيسي");
            //    return;
            //}
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtAcc = cnn.GetDataTable("SELECT d.pkid " +
                                               " FROM journal_details d " +
                                               " join accounts a on(d.acc_id = a.pkid) " +
                                               " where a.Acc_no like '"+txtAccNo.Text.Trim()+"%'"  );

            if (dtAcc != null && dtAcc.Rows.Count > 0)
            {
                glb_function.MsgBox("لايمكن حذف الحساب لارتباطه بعمليات في اليومية");
                return;
            }

            dtAcc.Clear();
            dtAcc = cnn.GetDataTable("SELECT pkid FROM accounts " +
                                      "  where parent_id = " + txtParentId.Text  +
                                      "  and Acc_short_no > " + txtAccShoreNo.Text);

            if (dtAcc != null && dtAcc.Rows.Count > 0)
            {
                glb_function.MsgBox("يوجد حساب بعد هذا الحساب" + "\n" + "لايمكن الحذف");
                return;
            }

            if (glb_function.MsgBox("هل انت متاكد من اتمام عملية الحذف", "تنبية", true) == false)
                return;

            int icheck = cnn.TranDataToDB("delete from accounts where Acc_no like '" + txtAccNo.Text.Trim() + "%'");
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء عملية الحذف");
                return;
            }

            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت عملية الحذف بنجاح");
            tvAccounts.Nodes.Remove(tvAccounts.SelectedNode);
            //FillAccountTree();
        }
    }
}
