using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Sales
{
    public partial class frmInvoices : OilStationW.myForm
    {
        string strInventoryAccId = "";
        string strSalesAccId = "";
        string strCostGoodSoldAccId = "";
        public frmInvoices()
        {
            InitializeComponent();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
           
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
         
        }
        private void PrepareForm()
        {

            GetValidPumps();
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnPrint.Enabled = false;

            
        }
        private void GetValidPumps()
        {
            dgvInvoices.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtPumps = cnn.GetDataTable("select p.warehouse_id,pe.emp_id,e.acc_id,e.empname,pe.pkid," +
                   " pump_id, pumpno, pumpname, pumpcounter, "+
                   " item_id, i.itemname, UnitSellingPrice, UnitCost"+
                   " from pump_emp pe"+
                   " join pumps p on (p.pkid = pe.pump_id)"+
                   " join emp e on (e.pkid = pe.emp_id)"+
                   " join warehouse w on (w.pkid = p.warehouse_id)"+
                   " join items i on (i.pkid = p.item_id)"+
                   " where w.branch_id = "+glb_function.glb_strBranchPkid +
                   " and p.stat = 'شغالة'  and pe.stat='فعال'");

            for (int i = 0; i < dtPumps.Rows.Count; i++)
            {
                dgvInvoices.Rows.Add();
                dgvInvoices[clmWarehouseId.Index, i].Value = dtPumps.Rows[i]["warehouse_id"].ToString();
                dgvInvoices[clmEmpId.Index, i].Value = dtPumps.Rows[i]["emp_id"].ToString();
                dgvInvoices[clmEmpAccId.Index, i].Value = dtPumps.Rows[i]["acc_id"].ToString();
                dgvInvoices[clmEmpName.Index, i].Value = dtPumps.Rows[i]["empname"].ToString();
                dgvInvoices[clmPump_empId.Index, i].Value = dtPumps.Rows[i]["pkid"].ToString();
                dgvInvoices[clmPumpId.Index, i].Value = dtPumps.Rows[i]["pump_id"].ToString();
                dgvInvoices[clmPumpNo.Index, i].Value = dtPumps.Rows[i]["pumpno"].ToString();
                dgvInvoices[clmPumpName.Index, i].Value = dtPumps.Rows[i]["pumpname"].ToString();
                dgvInvoices[clmOldCounter.Index, i].Value =Convert.ToDouble( dtPumps.Rows[i]["pumpcounter"].ToString()).ToString("###,###,###,##0.##");
                dgvInvoices[clmItemId.Index, i].Value = dtPumps.Rows[i]["item_id"].ToString();
                dgvInvoices[clmItemName.Index, i].Value = dtPumps.Rows[i]["itemname"].ToString();
                dgvInvoices[clmUnitSellingPrice.Index, i].Value = dtPumps.Rows[i]["UnitSellingPrice"].ToString();
                dgvInvoices[clmUnitCost.Index, i].Value = dtPumps.Rows[i]["UnitCost"].ToString();
                dgvInvoices[clmNewCounter.Index, i].Value = "0";
                dgvInvoices[clmQty.Index, i].Value = "0";
                dgvInvoices[clmTotalSellingPrice.Index, i].Value = "0";


            }
        }

        private void nmbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditor_Leave(object sender, EventArgs e)
        {
            if (nmbEditor.Visible == true)
            {
                nmbEditor.Visible = false;
                if (nmbEditor.Value <=Convert.ToDecimal( dgvInvoices[clmOldCounter.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value))
                {
                    glb_function.MsgBox("الرجاء ادخال العداد بشكل صحيح");
                    dgvInvoices[Convert.ToUInt16(nmbEditor.W_ColumnName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = "0";
                    return;
                }

                dgvInvoices[clmQty.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = (nmbEditor.Value - Convert.ToDecimal( dgvInvoices[clmOldCounter.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value)).ToString("###,###,###,##0.##");
                dgvInvoices[clmTotalSellingPrice.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value =(Math.Round( Convert.ToDecimal(dgvInvoices[clmQty.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value) * Convert.ToDecimal(dgvInvoices[clmUnitSellingPrice.Index, Convert.ToUInt16(nmbEditor.Tag.ToString())].Value),glb_function.glb_iMainCurrDecimal)).ToString("###,###,###,##0.##");
                dgvInvoices[Convert.ToUInt16(nmbEditor.W_ColumnName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString("###,###,###,##0.##");


                GetTotal();
            }
        }
        private void GetTotal()
        {
            nmbTotalSellingPrice.Value = 0;
            for (int i = 0; i < dgvInvoices.Rows.Count; i++)
            {
               
                nmbTotalSellingPrice.Value += Convert.ToDecimal(dgvInvoices[clmTotalSellingPrice.Index, i].Value);
            }
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // dgvJourDetails.RightToLeft = RightToLeft.No;
            DataGridViewCell abc = dgvInvoices.CurrentCell;
            Rectangle RECT = dgvInvoices.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
            // dgvJourDetails.RightToLeft = RightToLeft.Yes;


            nmbEditor.W_ColumnName = e.ColumnIndex.ToString();
            nmbEditor.DecimalPlaces = glb_function.glb_iMainCurrDecimal;
            nmbEditor.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == clmNewCounter.Index)
            {
                if (dgvInvoices[clmNewCounter.Index, e.RowIndex].Value == null || dgvInvoices[clmNewCounter.Index, e.RowIndex].Value.ToString() == "")
                    dgvInvoices[clmNewCounter.Index, e.RowIndex].Value = "0";

                nmbEditor.Value = Convert.ToDecimal(dgvInvoices[clmNewCounter.Index, e.RowIndex].Value.ToString());

                CtlLocation(RECT, nmbEditor);

            }

        }
        private void CtlLocation(Rectangle rect, Control ctrl)
        {

            // ctrl.Location = dgvPurQuotDetail.PointToScreen(dgvPurQuotDetail.GetCellDisplayRectangle(icolumnindex, irowindex, true ).Location);
            ctrl.Top = dgvInvoices.Location.Y + rect.Y;
            ctrl.Left = dgvInvoices.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);

            PrepareForm();
        }
        private bool CheckEntries()
        {
            if(nmbTotalSellingPrice.Value <=0)
            {
                glb_function.MsgBox("الرجاء ادخال بيانات طرمبة واحدة على الاقل");
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
                        ",sysdate()"  +
                         "," + glb_function.glb_strUserId +
                         ",'" + txtInvoiceNo.Text.Trim() + "'" +
                         ",'" + txtInvoiceNote.Text.Trim() + "'" +
                         "," + glb_function.glb_strBranchPkid +
                         ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                         "," + nmbTotalSellingPrice.Value.ToString() +                                   
                        ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة الرئيسية");
                return;
            }

            double dTotalUnitCost = 0;
            for (int i = 0; i < dgvInvoices.Rows.Count; i++)
            {
                if (dgvInvoices[clmTotalSellingPrice.Index, i].Value == null || dgvInvoices[clmTotalSellingPrice.Index, i].Value.ToString() == "0" || dgvInvoices[clmTotalSellingPrice.Index, i].Value.ToString() == "")
                    continue;


                 dTotalUnitCost += Convert.ToDouble(dgvInvoices[clmQty.Index ,i].Value.ToString()) * Convert.ToDouble(dgvInvoices[clmUnitCost.Index,i].Value.ToString());

                icheck = cnn.TranDataToDB("insert into invoice_details values ((select ifnull(max(b.pkid),0)+1 from invoice_details b)" +
                    ",'فعال'" +
                    ",sysdate()" +
                   "," + glb_function.glb_strUserId +
                    "," + txtPkid.Text  +
                     "," + dgvInvoices[clmWarehouseId.Index, i].Value.ToString() +
                       "," +(dgvInvoices[clmPump_empId.Index, i].Value.ToString()) +
                       "," + (dgvInvoices[clmPumpId.Index, i].Value.ToString()) +
                       "," + (dgvInvoices[clmEmpId.Index, i].Value.ToString()) +
                       "," + Convert.ToDouble (dgvInvoices[clmOldCounter.Index, i].Value.ToString()) +
                       "," + Convert.ToDouble(dgvInvoices[clmNewCounter.Index, i].Value.ToString()) +
                       "," + (dgvInvoices[clmItemId.Index, i].Value.ToString()) +
                         "," + Convert.ToDouble(dgvInvoices[clmQty.Index, i].Value.ToString()) +
                          "," + Convert.ToDouble(dgvInvoices[clmUnitSellingPrice.Index, i].Value.ToString()) +
                           "," + Convert.ToDouble(dgvInvoices[clmTotalSellingPrice.Index, i].Value.ToString()) +                                      
                   ")");

                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة التفصيلية");
                    return;
                }
                icheck = cnn.TranDataToDB("update pumps set PumpCounter=" +Convert.ToDecimal( dgvInvoices[clmNewCounter.Index,i].Value.ToString()) + " ,stat='متاحة' where pkid=" + dgvInvoices[clmPumpId.Index,i].Value.ToString());
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الفاتورة ");
                    return;
                }
                icheck = cnn.TranDataToDB("update pump_emp set stat='مقفل' where pkid=" + dgvInvoices[clmPump_empId.Index, i].Value.ToString() );
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
                    "," +  dgvInvoices[clmItemId.Index, i].Value.ToString() +
                     "," + dgvInvoices[clmWarehouseId.Index, i].Value.ToString() +
                       ",-" + Convert.ToDecimal(dgvInvoices[clmQty.Index, i].Value.ToString()) +
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

            }


            dTotalUnitCost = Math.Round(dTotalUnitCost, glb_function.glb_iMainCurrDecimal);
            #region AccountEntry
            //القيد المحاسبي *********************
            //حفظ بيانات الراس
            DataTable dtKeys = cnn.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " ) JourNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
            string strJPkid = dtKeys.Rows[0]["pkid"].ToString();

            //  string strIssueNo = dtKeys.Rows[0]["JourNo"].ToString();

            string strJourNo = glb_function.glb_strBranchPkid + "-" + dtKeys.Rows[0]["JourNo"].ToString();

            icheck = 0;

            icheck = cnn.TranDataToDB("insert into journal_header values (" + strJPkid +
                ",'فعال'" +
               ",sysdate()" +
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
            double dMainValue = (double)(dTotalUnitCost * -1);
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
            dMainValue = dTotalUnitCost;
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
            //dMainValue2 = dMainValue2 * -1; //تضرب في سالب لتحويلها لموجب
            //dCurrValue2 = dMainValue2;

            for (int i = 0; i < dgvInvoices.Rows.Count; i++)
            {
                if (dgvInvoices[clmTotalSellingPrice.Index, i].Value == null || dgvInvoices[clmTotalSellingPrice.Index, i].Value.ToString() == "")
                    continue;

                icheck = cnn.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
          ",'فعال'" +
          ",sysdate()" +
          "," + glb_function.glb_strUserId +
           "," + strJPkid +
           "," + glb_function.glb_iMainCurrId +
           "," + dgvInvoices[clmEmpAccId.Index,i].Value.ToString() +
           "," + Convert.ToDecimal(dgvInvoices[clmTotalSellingPrice.Index,i].Value.ToString()) +
           "," + Convert.ToDecimal(dgvInvoices[clmTotalSellingPrice.Index, i].Value.ToString()) +
           ",1" +
           ",'حساب " + dgvInvoices[clmPumpNo.Index, i].Value.ToString() + " ليوم " +dtpJourDate.Value.ToString("dd/MM/yyyy")+"'"+
             ",''" +
              ",''" +
          ")");
                if (icheck <= 0)
                {
                    cnn.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }
            }
           

            #endregion //القيد الثاني للمبيعات


            #endregion // قيد الحسابات بالكامل



            cnn.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");


            GetData(txtPkid.Text);

            btnPrint.Focus();
        }
        private void GetData(string strInvoicePkid)
        {
            new glb_function().clearItems(this);
           
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtInvoice = cnn.GetDataTable("SELECT h.pkid pkheader,h.invoice_no,h.invoice_note,h.invoice_value,date_format(h.invoice_date,'%d/%m/%Y') invoice_date , " +
                           " d.warehouse_id, d.pump_emp, d.pump_id, p.PumpNo, p.PumpName, d.emp_id, e.empname, d.old_counter, d.new_counter, " +
                           " d.item_id, i.itemname, d.qty, d.unitsellingPrice, d.TotalSellingPrice " +
                            " FROM invoice_header h " +
                           "  join invoice_details d on(h.pkid = d.header_id) " +
                           "  join pumps p on(p.pkid = d.pump_id) " +
                           "  join emp e on(e.pkid = d.emp_id) " +
                           "  join items i on(i.pkid = d.item_id) " +
                           "  where h.pkid=" + strInvoicePkid);
           
            txtPkid.Text = strInvoicePkid;
            txtInvoiceNo.Text = dtInvoice.Rows[0]["invoice_no"].ToString();
           
            nmbTotalSellingPrice.Value = Convert.ToDecimal(dtInvoice.Rows[0]["TotalSellingPrice"].ToString());
            txtInvoiceNote.Text = dtInvoice.Rows[0]["invoice_note"].ToString();
            dtpJourDate.Value = DateTime.ParseExact(dtInvoice.Rows[0]["invoice_date"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            for (int i = 0; i < dtInvoice.Rows.Count; i++)
            {
                dgvInvoices.Rows.Add();
                dgvInvoices[clmPumpNo.Index, i].Value = dtInvoice.Rows[i]["PumpNo"].ToString();
                dgvInvoices[clmPumpName.Index, i].Value = dtInvoice.Rows[i]["PumpName"].ToString();
                dgvInvoices[clmItemName.Index, i].Value = dtInvoice.Rows[i]["itemname"].ToString();
                dgvInvoices[clmEmpName.Index, i].Value = dtInvoice.Rows[i]["empname"].ToString();
                dgvInvoices[clmUnitSellingPrice.Index, i].Value = dtInvoice.Rows[i]["unitsellingPrice"].ToString();
                dgvInvoices[clmOldCounter.Index, i].Value = dtInvoice.Rows[i]["old_counter"].ToString();
                dgvInvoices[clmNewCounter.Index, i].Value = dtInvoice.Rows[i]["new_counter"].ToString();
                dgvInvoices[clmQty.Index, i].Value = dtInvoice.Rows[i]["qty"].ToString();
                dgvInvoices[clmTotalSellingPrice.Index, i].Value = Convert.ToDouble(dtInvoice.Rows[i]["qty"].ToString()) * Convert.ToDouble(dtInvoice.Rows[i]["unitsellingPrice"].ToString());
            }


            if (UserTemplate.HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;
            else
                btnPrint.Enabled = false;

            btnSave.Enabled = false;


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
            dtReport = cnn.GetDataTable("SELECT h.pkid pkheader,h.invoice_no,h.invoice_note,h.invoice_value,date_format(h.invoice_date,'%d/%m/%Y') invoice_date , "+
                                       " d.warehouse_id, d.pump_emp, d.pump_id, p.PumpNo, p.PumpName, d.emp_id, e.empname, d.old_counter, d.new_counter, "+
                                       " d.item_id, i.itemname, d.qty, d.unitsellingPrice, d.TotalSellingPrice "+
                                       "  FROM invoice_header h "+
                                        " join invoice_details d on(h.pkid = d.header_id) "+
                                       "  join pumps p on(p.pkid = d.pump_id) "+
                                        " join emp e on(e.pkid = d.emp_id) "+
                                       "  join items i on(i.pkid = d.item_id) "+
                                        " where h.pkid = " + txtPkid.Text);


            report.SetDataSource(dtReport);
            frm.CrystalReportsViewer1.ReportSource = report;

            frm.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindSalesInvoice frm = new frmFindSalesInvoice();

            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
    }
}
