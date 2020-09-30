using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationW
{
    public partial class frmMain : Form
    {
        private DataTable dtUserForm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void rbAddUser_Click(object sender, EventArgs e)
        {
            new Files.frmUsers().ShowDialog();

        }

        private void rbAddBranch_Click(object sender, EventArgs e)
        {
            new Files.frmBranches().ShowDialog();
        }

        private void rbDefineTemplet_Click(object sender, EventArgs e)
        {
            new Files.frmFormTemplet().ShowDialog();
        }

        private void rbDefineForms_Click(object sender, EventArgs e)
        {
            new Files.frmTempletManagement().ShowDialog();
        }

        private void rbChangePassword_Click(object sender, EventArgs e)
        {
            new Files.frmChangePassword().ShowDialog();
        }

        private void rbLogout_Click(object sender, EventArgs e)
        {
            glb_function.strDbCnnString = "";
            glb_function.glb_strUserName = "";
            
            frmMain_Load(null, null);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (RibbonTab ribonTab in tbrStatProp.Tabs)
                ribonTab.Visible = false;

            frmLogin myform = new frmLogin();

            myform.ShowDialog();
            this.Text = "البرنامج المحاسبي الفرع: " + glb_function.glb_strBranchName;
            if (glb_function.glb_strUserName == "وسيم الأغبري")
            {
                foreach (RibbonTab ribonTab in tbrStatProp.Tabs)
                {
                    ribonTab.Visible = true;
                    foreach (RibbonPanel panl in ribonTab.Panels)
                    {
                        panl.Visible = true;
                        for (int i = 0; i < panl.Items.Count; i++)
                        {
                            panl.Items[i].Visible = true ;
                        }
                    }
                        
                }
                   

                return;
            }

            if (glb_function.glb_strUserName == "")
                return;


            ConnectionToMySQL cnn = new ConnectionToMySQL();


            dtUserForm = cnn.GetDataTable(" select u.pkid,m.form_arabic_name,m.form_eng_name,m.form_type_en from templet_header m,user_templet u " +
                                            " where m.pkid = u.templet_id and u.user_id= " + glb_function.glb_strUserId);
            CreateToolIcons(this);

        }

        private void CreateToolIcons(Control myControl)
        {

            Ribbon rpt = new Ribbon();
            RibbonTab rr = new RibbonTab();
            //rr.Panels[0].Items[1].Tag 
            int iCheckCount = 0;
            foreach (RibbonTab ribonTab in tbrStatProp.Tabs)
            {


                foreach (RibbonPanel panl in ribonTab.Panels)
                {
                    iCheckCount = 0;
                    for (int i = 0; i < panl.Items.Count; i++)
                    {
                        if (panl.Items[i].Tag == null)
                            panl.Items[i].Tag = "";
                        if (panl.Items[i].Tag.ToString() == "")
                            panl.Items[i].Visible = true;
                        else if (IsUserHasThisForm(panl.Items[i].Tag.ToString(), ribonTab.Tag.ToString()) == true)
                            panl.Items[i].Visible = true;
                        else
                        {
                            panl.Items[i].Visible = false;
                            iCheckCount = iCheckCount + 1;
                        }

                    }
                    if (panl.Items.Count == iCheckCount)
                    {
                        panl.Visible = false;
                        ribonTab.Visible = false;
                    }
                    else
                    {
                        panl.Visible = true;
                        ribonTab.Visible = true;
                    }



                }
            }


        }

        private bool IsUserHasThisForm(string strFormName, string strTab)
        {
            for (int i = 0; i < dtUserForm.Rows.Count; i++)
            {
                if (dtUserForm.Rows[i]["form_eng_name"].ToString() == strFormName && dtUserForm.Rows[i]["form_type_en"].ToString() == strTab)
                    return true;
            }
            return false;
        }

        private void rbAccountTree_Click(object sender, EventArgs e)
        {
            new Accounts.frmAccountTree().ShowDialog();
        }

        private void rbBeginingEntry_Click(object sender, EventArgs e)
        {
            new Accounts.frmBeginingEntry().ShowDialog();
        }

        private void rbPurchaseInvoice_Click(object sender, EventArgs e)
        {
            new Purchases.frmPurchaseInvoice().ShowDialog();
        }

        private void rbCurrency_Click(object sender, EventArgs e)
        {
            new Accounts.frmCurrency().ShowDialog();
        }

        private void rbJournal_Click(object sender, EventArgs e)
        {
            new Accounts.frmJournal().ShowDialog();

        }

        private void rbCashReceipts_Click(object sender, EventArgs e)
        {
            new Accounts.frmCashReceipts().ShowDialog();
        }

        private void rbCashPayments_Click(object sender, EventArgs e)
        {
            new Accounts.frmCashPayments().ShowDialog();

        }

        private void rbReverseEntry_Click(object sender, EventArgs e)
        {
            new Accounts.frmReverseEntry().ShowDialog();
        }

        private void rbPosting_Click(object sender, EventArgs e)
        {
            new Accounts.frmPosting().ShowDialog();
        }

        private void rbWareHouse_Click(object sender, EventArgs e)
        {
            new Inventory.frmAddWarehouse().ShowDialog();

        }

        private void rbUnits_Click(object sender, EventArgs e)
        {
            new Inventory.frmUnits().ShowDialog();
        }

        private void rbItems_Click(object sender, EventArgs e)
        {
            new Inventory.frmItems().ShowDialog() ;
        }

        private void rbEmp_Click(object sender, EventArgs e)
        {
            new Inventory.frmEmp().ShowDialog();
        }

        private void rbPumps_Click(object sender, EventArgs e)
        {
            new Inventory.frmPumps().ShowDialog();
        }

        private void rbPumpToEmp_Click(object sender, EventArgs e)
        {
            new Inventory.frmPumpToEmp().ShowDialog();

        }

        private void rbStockAdjustmentOut_Click(object sender, EventArgs e)
        {
            Inventory.frmStackAdjustment frm = new Inventory.frmStackAdjustment();
            frm.Text = "امر صرف مخزني";
            frm.Titel = "امر صرف مخزني";
            frm.strStackadj_type = "امر صرف";
            frm.Tag = "frmStockAdjustmentOut";
            frm.ShowDialog();
        }

        private void rbStockAdjustmentAdd_Click(object sender, EventArgs e)
        {
            Inventory.frmStackAdjustment frm = new Inventory.frmStackAdjustment();
            frm.Text = "امر توريد مخزني";
            frm.Titel = "امر توريد مخزني";
            frm.strStackadj_type = "امر توريد";
            frm.nmbUnitCost.Enabled = true;
            frm.Tag = "frmStockAdjustmentIn";
            frm.ShowDialog();
        }

        private void rbVendors_Click(object sender, EventArgs e)
        {
            new Purchases.frmVendors().ShowDialog();
        }

        private void rbPurchaseExpensses_Click(object sender, EventArgs e)
        {
            new Purchases.frmPurchaseExpensses().ShowDialog();
        }

        private void rbCustomer_Click(object sender, EventArgs e)
        {
            new Sales.frmCustomers().ShowDialog();
        }

        private void rbSalesInvoice_Click(object sender, EventArgs e)
        {
            new Sales.frmInvoices().ShowDialog();
        }

        private void rbAccountSheet_Click(object sender, EventArgs e)
        {
            new Reports.frmAccountSheet().ShowDialog();
        }

        private void rbJournalsRep_Click(object sender, EventArgs e)
        {
            new Reports.frmJournalsRep().ShowDialog();
        }

        private void rbTrialBalance_Click(object sender, EventArgs e)
        {
            new Reports.frmTrialBalance().ShowDialog();
        }

        private void rbItemTrans_Click(object sender, EventArgs e)
        {
            new Reports.frmItemTrans().ShowDialog();
        }

        private void rbSalesInvoiceRep_Click(object sender, EventArgs e)
        {
            new Reports.frmSalesInvoiceRep().ShowDialog();
        }

        private void rbDialyActivity_Click(object sender, EventArgs e)
        {
            new Reports.frmDialyActivityRep().ShowDialog();
        }

        private void rbOtherBranchExp_Click(object sender, EventArgs e)
        {
            new Accounts.frmOtherBranchExpenss().ShowDialog();
        }

        private void rbTamplateAcc_Click(object sender, EventArgs e)
        {
            new Reports.frmTemplateReport().ShowDialog();
        }
    }
}
