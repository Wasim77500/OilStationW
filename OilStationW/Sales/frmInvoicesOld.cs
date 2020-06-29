using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Sales
{
    public partial class frmInvoicesOld : OilStationW.myForm
    {
        string strInventoryAccId = "";
        string strSalesAccId = "";
        string strCostGoodSoldAccId = "";
        public frmInvoicesOld()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            bLoad = true;
            new UserTemplate().GetPrivForThisForm(this);

            strInventoryAccId = txtInventoryAccId.Text.Trim();
            if (strInventoryAccId == "" || strInventoryAccId == null)
            {
                glb_function.MsgBox("لايوجد حساب مخزون محدد لهذا النموذج");
                this.Close();
            }

            strSalesAccId = txtSalesAccId.Text.Trim();
            if (strSalesAccId == "" || strSalesAccId == null)
            {
                glb_function.MsgBox("لايوجد حساب مبيعات محدد لهذا النموذج");
                this.Close();
            }


            strCostGoodSoldAccId = txtCostGoodSoldAccId.Text.Trim();
            if (strCostGoodSoldAccId == "" || strCostGoodSoldAccId == null)
            {
                glb_function.MsgBox("لايوجد حساب تكلفة بضاعة مباعة محدد لهذا النموذج");
                this.Close();
            }

            PrepareForm();
            bLoad = false;
        }
        private void PrepareForm()
        {
            FillData();

            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnPrint.Enabled = false;
        }

        private void FillData()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,warehouse_name FROM warehouse where branch_id= " + glb_function.glb_strBranchPkid);
            lstWareHouse.DataSource = dtBrnch.DefaultView;
            lstWareHouse.ValueMember = "pkid";
            lstWareHouse.DisplayMember = "warehouse_name";

            lstWareHouse.SelectedIndex = -1;

        }

        private void lstWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad)
                return;
            lstPumps.DataSource = null;
            if (lstWareHouse.SelectedIndex == -1)
                return;



            if (lstWareHouse.SelectedValue.ToString() != "System.Data.DataRowView" && lstWareHouse.SelectedValue.ToString() != "")
            {
                bLoad = true;
                ConnectionToMySQL cnn = new ConnectionToMySQL();
                DataTable dtPump = cnn.GetDataTable("SELECT p.pkid,p.PumpName " +
                                   " FROM pumps p " +
                                   " where warehouse_id =  " + lstWareHouse.SelectedValue.ToString() +
                                   " and p.stat = 'شغالة'");

                lstPumps.DataSource = dtPump.DefaultView;
                lstPumps.ValueMember = "pkid";
                lstPumps.DisplayMember = "PumpName";
                lstPumps.SelectedIndex = -1;
                bLoad = false;

            }
                
        }
        bool bLoad = false;
        private void lstPumps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad)
                return;
            if (lstPumps.SelectedValue == null || lstPumps.SelectedIndex == -1 ||  lstWareHouse.SelectedValue.ToString() == "System.Data.DataRowView" || lstWareHouse.SelectedValue.ToString() == "")
                return;

            if (lstWareHouse.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWareHouse.Focus();
                return;
            }


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtPumpItem = cnn.GetDataTable("SELECT p.pkid,p.stat,p.pumpno,p.PumpName,p.PumpCounter," +
                                                    "p.warehouse_id,p.pumpnote,p.item_id," +
                                                    "emp.pkid empid,emp.empname,emp.acc_id," +
                                                    "i.itemno,i.itemName,i.UnitSellingPrice,i.unitCost, " +
                                                    "pe.pkid pumpempid" +
                                                    " FROM pumps p " +
                                                    " join pump_emp pe on(p.pkid = pe.pump_id) " +
                                                    " join emp on(pe.emp_id = emp.pkid) " +
                                                    " join items i on(p.item_id = i.pkid) " +
                                                    " where pe.stat='فعال' and p.pkid = " + lstPumps.SelectedValue.ToString());


            if (dtPumpItem == null || dtPumpItem.Rows.Count <= 0)
            {
                glb_function.MsgBox("لا توجد بيانات لهذه الطرمبة");
                return;
            }
            if (dtPumpItem.Rows.Count > 1)
            {
                glb_function.MsgBox("عدد العمال او الاصناف اكثر من المسموح به");
                return;
            }


            txtEmpId.Text = dtPumpItem.Rows[0]["empid"].ToString();
            txtEmpAccId.Text = dtPumpItem.Rows[0]["acc_id"].ToString();
            txtEmpName.Text = dtPumpItem.Rows[0]["empname"].ToString();
            txtItemPkid.Text = dtPumpItem.Rows[0]["item_id"].ToString();
            txtItemNo.Text = dtPumpItem.Rows[0]["itemno"].ToString();
            txtItemName.Text = dtPumpItem.Rows[0]["itemName"].ToString();
            txtPumpEmpId.Text = dtPumpItem.Rows[0]["pumpempid"].ToString();
            nmbOnhandQty.Value =(decimal) glb_function.GetQty(txtItemPkid.Text, lstWareHouse.SelectedValue.ToString());
            nmbUnitSellingPrice.Value = Convert.ToDecimal(dtPumpItem.Rows[0]["UnitSellingPrice"].ToString());
            nmbUnitCost.Value = Convert.ToDecimal(dtPumpItem.Rows[0]["unitCost"].ToString());
            nmbPreviousCounter.Value = Convert.ToDecimal(dtPumpItem.Rows[0]["PumpCounter"].ToString());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindSalesInvoice frm = new frmFindSalesInvoice();

            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strInvoicePkid)
        {
            btnNew_Click(null, null);
            lstPumps.Items.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtInvoice = cnn.GetDataTable("select h.pkid, h.stat, h.invoice_no, h.warehouse_id, " +
                " h.pump_emp, h.pump_id, h.emp_id, " +
               " h.old_counter, h.new_counter, h.invoice_note, h.item_id, h.qty, h.unitsellingPrice, " +
                " h.TotalSellingPrice, h.Branch_id, p.PumpName, i.itemno, i.itemname, emp.empname " +
               " from invoice_header h " +
               " join items i on (i.pkid = h.item_id) " +
               " join pumps p on (p.pkid = h.pump_id) " +
               " join emp on (emp.pkid = h.emp_id)" +
               " where h.pkid=" + strInvoicePkid);
            bLoad = true;
            txtPkid.Text = strInvoicePkid;
            txtInvoiceNo.Text = dtInvoice.Rows[0]["invoice_no"].ToString();
            lstWareHouse.SelectedValue = dtInvoice.Rows[0]["warehouse_id"].ToString();
           
            lstPumps.Items.Add(dtInvoice.Rows[0]["PumpName"].ToString());
            lstPumps.Text = dtInvoice.Rows[0]["PumpName"].ToString();
            bLoad = false;

            txtEmpName.Text = dtInvoice.Rows[0]["empname"].ToString();
            txtItemNo.Text = dtInvoice.Rows[0]["itemno"].ToString();
            txtItemName.Text = dtInvoice.Rows[0]["itemname"].ToString();
            nmbOnhandQty.Value =(decimal) glb_function.GetQty(dtInvoice.Rows[0]["item_id"].ToString(), lstWareHouse.SelectedValue.ToString());
            nmbUnitSellingPrice.Value = Convert.ToDecimal(dtInvoice.Rows[0]["unitsellingPrice"].ToString());
            nmbPreviousCounter.Value = Convert.ToDecimal(dtInvoice.Rows[0]["old_counter"].ToString());
            nmbCurrentCounter.Value = Convert.ToDecimal(dtInvoice.Rows[0]["new_counter"].ToString());
            nmbRequiredQty.Value = Convert.ToDecimal(dtInvoice.Rows[0]["qty"].ToString());
            nmbTotalSellingPrice.Value = Convert.ToDecimal(dtInvoice.Rows[0]["TotalSellingPrice"].ToString());
            txtInvoiceNote.Text = dtInvoice.Rows[0]["invoice_note"].ToString();





            if (UserTemplate.HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;
            else
                btnPrint.Enabled = false;

            btnSave.Enabled = false;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }

        private void nmbCurrentCounter_Leave(object sender, EventArgs e)
        {
            if (nmbCurrentCounter.Value <= nmbPreviousCounter.Value)
            {
                glb_function.MsgBox("الرجاء ادخال العداد بشكل صحيح");
                return;
            }

            nmbRequiredQty.Value = nmbCurrentCounter.Value - nmbPreviousCounter.Value;
            nmbTotalSellingPrice.Value = nmbRequiredQty.Value * nmbUnitSellingPrice.Value;
        }

        private void nmbCurrentCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                btnSave.Focus();
        }

        private bool CheckEntries()
        {
            if (lstWareHouse.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWareHouse.Focus();
                return false;

            }

            if (lstPumps.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الطرمبة");
                lstPumps.Focus();
                return false;

            }
            if (txtEmpAccId.Text.Trim() == "")
            {
                glb_function.MsgBox("لايوجد حساب للعامل");

                return false;
            }
            if (txtItemPkid.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء تحديد الصنف");
                return false;
            }

            if (nmbUnitSellingPrice.Value <= 0)
            {
                glb_function.MsgBox("لايوجد سعر بيع لهذا الصنف");
                return false;
            }
            if (nmbCurrentCounter.Value < nmbPreviousCounter.Value)
            {
                glb_function.MsgBox("الرجاء ادخال قراءة العداد بشكل صحيح");
                return false;
            }





            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtSales = cnn.GetDataTable("select(select  ifnull(max(convert(substring(invoice_no, instr(invoice_no, '-') + 1), signed)), 0) + 1 FROM invoice_header where Branch_id = " + glb_function.glb_strBranchPkid + " ) Invoice_no, (select ifnull(max(pkid), 0) + 1 from invoice_header) pkid");
            txtPkid.Text = dtSales.Rows[0]["pkid"].ToString();
            txtInvoiceNo.Text = glb_function.glb_strBranchPkid + "-" + dtSales.Rows[0]["Invoice_no"].ToString();
            int icheck = cnn.TranDataToDB("insert into invoice_header " +
                         " values(" + txtPkid.Text + "" +
                         ",'فعال'" +
                        ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                         "," + glb_function.glb_strUserId +
                         ",'" + txtInvoiceNo.Text.Trim() + "'" +
                         "," + lstWareHouse.SelectedValue.ToString() +
                           "," + txtPumpEmpId.Text.Trim() +
                            "," + lstPumps.SelectedValue.ToString() +
                            "," + txtEmpId.Text.Trim() +
                            "," + nmbPreviousCounter.Value.ToString() +
                              "," + nmbCurrentCounter.Value.ToString() +
                         ",'" + txtInvoiceNote.Text.Trim() + "'" +
                          "," + txtItemPkid.Text.Trim() +
                           "," + nmbRequiredQty.Value.ToString() +
                            "," + nmbUnitSellingPrice.Value.ToString() +
                             "," + nmbTotalSellingPrice.Value.ToString() +
                             "," + glb_function.glb_strBranchPkid +
                        ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة");
                return;
            }


            icheck = cnn.TranDataToDB("update pumps set PumpCounter=" + nmbCurrentCounter.Value + " ,stat='متاحة' where pkid=" + lstPumps.SelectedValue.ToString());
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة ");
                return;
            }
            icheck = cnn.TranDataToDB("update pump_emp set stat='مقفل' where pkid=" + txtPumpEmpId.Text);
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة ");
                return;
            }
            //خفض الكمية في المخزون
            icheck = cnn.TranDataToDB("insert into item_trans values ((select ifnull(max(b.pkid),0)+1 from item_trans b)" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + txtItemPkid.Text +
                 "," + lstWareHouse.SelectedValue.ToString() +
                   ",-" + nmbRequiredQty.Value.ToString() +
               "," + txtPkid.Text +
               ",'فاتورة مبيعات'" +
               ",''" +
                ",'" + txtInvoiceNo.Text.Trim() + "'" +
                ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
               ")");

            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات حركة الاصناف");
                return;
            }


            #region AccountEntry
            //القيد المحاسبي *********************
            //حفظ بيانات الراس
            DataTable dtKeys = cnn.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='فاتورة بيع') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
            string strJPkid = dtKeys.Rows[0]["pkid"].ToString();

            //  string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();

            string strJourNo = glb_function.glb_strBranchPkid + "-" + strJPkid;

            icheck = 0;

            icheck = cnn.TranDataToDB("insert into journal_header values (" + strJPkid +
                ",'فعال'" +
               ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                "," + glb_function.glb_strUserId +
                "," + glb_function.glb_strBranchPkid +
                ",'" + strJourNo.Trim() + "'" +
                ",'فاتورة بيع'" +
                "," + txtPkid.Text +
                ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                ",'قيدت من فاتورة المبيعات'" +
                 ",''" +
                 ",'" + txtInvoiceNo.Text.Trim() + "'" +
                ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                return;
            }




            #region FirstEntry
            //القيد الاول
            // الى حـ المخزون
            // من حـ تكلفة البضاعة المباعة



            //حفظ بيانات الدائن 
            //يكون المخزون دائن في فاتورة المبيعات ويميزه انه اصغر من الصفر
            double dMainValue = (double)(nmbRequiredQty.Value * nmbUnitCost.Value * -1);
            double dCurrValue = dMainValue;
            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + strJPkid +
            "," + glb_function.glb_iMainCurrId +
            "," + strInventoryAccId +
            "," + dMainValue +
            "," + dCurrValue +
            ",1" +
            ",''" +
            ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }

            //حفظ بيانات المدين 
            //
            dMainValue = dMainValue * -1; //تضرب في سالب لتحويلها لموجب
            dCurrValue = dMainValue;
            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + strJPkid +
            "," + glb_function.glb_iMainCurrId +
            "," + strCostGoodSoldAccId +
            "," + dMainValue +
            "," + dCurrValue +
            ",1" +
            ",''" +
              ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }
            #endregion


            #region SecondEntry
            // القيد الثاني
            // من حـ العميل او العامل او الصندوق
            // الى حـ المبيعات



            //حفظ بيانات الدائن 
            //تكون المبيعات دائن في فاتورة المبيعات ويميزه انه اصغر من الصفر
            double dMainValue2 = (double)(nmbTotalSellingPrice.Value * -1);
            double dCurrValue2 = dMainValue2;
            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + strJPkid +
            "," + glb_function.glb_iMainCurrId +
            "," + strSalesAccId +
            "," + dMainValue2 +
            "," + dCurrValue2 +
            ",1" +
            ",''" +
            ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }

            //حفظ بيانات المدين 
            //
            dMainValue2 = dMainValue2 * -1; //تضرب في سالب لتحويلها لموجب
            dCurrValue2 = dMainValue2;
            icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
           ",'فعال'" +
           ",sysdate()" +
           "," + glb_function.glb_strUserId +
            "," + strJPkid +
            "," + glb_function.glb_iMainCurrId +
            "," + txtEmpAccId.Text +
            "," + dMainValue2 +
            "," + dCurrValue2 +
            ",1" +
            ",''" +
              ",''" +
           ")");
            if (icheck <= 0)
            {
                cnn.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                return;
            }

            #endregion //القيد الثاني للمبيعات


            #endregion // قيد الحسابات بالكامل



            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");


            GetData(txtPkid.Text);

            btnPrint.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار الفاتورة");
                return;
            }


            cryRepSalesInvoice report = new cryRepSalesInvoice();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtReport = cnn.GetDataTable("select h.pkid, h.stat,date_format(h.created_date,'%d/%m/%Y') created_date, h.created_user, h.invoice_no, h.warehouse_id, " +
                                        " h.pump_emp, h.pump_id, h.emp_id, h.old_counter, h.new_counter, " +
                                        " h.invoice_note, h.item_id, h.qty, h.unitsellingPrice, h.TotalSellingPrice, " +
                                        " i.itemno, i.itemname, " +
                                        " w.warehouse_name, " +
                                        " emp.empname " +
                                       "  from invoice_header h " +
                                       " join items i on (i.pkid = h.item_id) " +
                                       " join warehouse w on (w.pkid = h.warehouse_id) " +
                                       " join emp on (emp.pkid = h.emp_id) " +
                                       " where h.pkid = " + txtPkid.Text);


            report.SetDataSource(dtReport);
            frm.CrystalReportsViewer1.ReportSource = report;

            frm.ShowDialog();
        }
    }
}
