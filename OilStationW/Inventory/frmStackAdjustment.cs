using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmStackAdjustment : OilStationW.myForm
    {
        public string strStackadj_type = "";
        private string strInventoryAccId;
        bool strDataFromDataSource = false;
        public frmStackAdjustment()
        {
            InitializeComponent();
        }

        private void frmStackAdjustment_Load(object sender, EventArgs e)
        {
            new UserTemplate().GetPrivForThisForm(this);
            strInventoryAccId = txtAccNo.Text.Trim();
            if (strInventoryAccId == null || strInventoryAccId == "")
            {
                glb_function.MsgBox("لايوجد حساب مخزون محدد لهذا النموذج");
                this.Close();
            }
            PrepareForm();
        }
        private void PrepareForm()
        {
            FillData();
            nmbTotal.DecimalPlaces = glb_function.glb_iMainCurrDecimal;
            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnPrint.Enabled = false;

        }
        private void FillData()
        {
            strDataFromDataSource = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtWarehouse = cnn.GetDataTable("SELECT pkid,warehouse_name FROM warehouse where branch_id=" + glb_function.glb_strBranchPkid);

            lstWarehouses.DataSource = dtWarehouse.DefaultView;
            lstWarehouses.ValueMember = "pkid";
            lstWarehouses.DisplayMember = "warehouse_name";

            DataTable dtAcc = cnn.GetDataTable("SELECT pkid,acc_no,acc_name FROM accounts where level=5 and stat='فعال' order by acc_no");
            lstAccNo.DataSource = dtAcc.DefaultView;
            lstAccNo.ValueMember = "pkid";
            lstAccNo.DisplayMember = "acc_no";

            lstAccName.DataSource = dtAcc.DefaultView;
            lstAccName.ValueMember = "pkid";
            lstAccName.DisplayMember = "acc_name";
            lstAccNo.SelectedIndex = -1;
            lstAccName.SelectedIndex = -1;
            strDataFromDataSource = false;

        }

        private void lstAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList lstParent = sender as myList;

            if (lstParent.SelectedValue == null || strDataFromDataSource == true)
                return;



            if (lstParent.SelectedValue.ToString() != "System.Data.DataRowView" && lstParent.SelectedValue.ToString() != "")
            {
                lstAccNo.SelectedValue = lstAccName.SelectedValue = lstParent.SelectedValue;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindStackAdjustment frm = new frmFindStackAdjustment();
            frm.strWhere = " and h.stackadj_type='" + strStackadj_type + "'";
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }
        private void GetData(string strPkid)
        {
            new glb_function().clearItems(this);
            PrepareForm();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtStockAdj = cnn.GetDataTable("SELECT h.pkid,h.stockadj_no,h.warehosue_id,h.stackadj_note,d.pkid dpkid,d.itemid,i.itemno,i.itemname,i.UnitSellingPrice,d.qty,h.acc_id ,i.unitCost " +
                       " FROM stockadjust_header h " +
                       " join stockadjust_details d on(h.pkid = d.header_id) " +
                       " join items i on(d.itemid = i.pkid) " +
                       " and h.pkid = " + strPkid);

            txtPkid.Text = dtStockAdj.Rows[0]["pkid"].ToString();
            txtStockAdjNo.Text = dtStockAdj.Rows[0]["stockadj_no"].ToString();
            txtStockAdjNote.Text = dtStockAdj.Rows[0]["stackadj_note"].ToString();
            lstWarehouses.SelectedValue = dtStockAdj.Rows[0]["warehosue_id"].ToString();
            lstAccNo.SelectedValue = dtStockAdj.Rows[0]["acc_id"].ToString();
            lstAccName.SelectedValue = dtStockAdj.Rows[0]["acc_id"].ToString();
           
            for (int i = 0; i < dtStockAdj.Rows.Count; i++)
            {
                dgvStockAdjustment.Rows.Add();
                
               dgvStockAdjustment[clmPKid.Index,i].Value = dtStockAdj.Rows[i]["dpkid"].ToString();
                dgvStockAdjustment[clmItemId.Index, i].Value = dtStockAdj.Rows[i]["itemid"].ToString();
                dgvStockAdjustment[clmItemNo.Index, i].Value = dtStockAdj.Rows[i]["itemno"].ToString();
                dgvStockAdjustment[clmItemName.Index, i].Value = dtStockAdj.Rows[i]["itemname"].ToString(); ;
                dgvStockAdjustment[clmRequiredQty.Index, i].Value = dtStockAdj.Rows[i]["qty"].ToString();
                dgvStockAdjustment[clmUnitCost.Index, i].Value = dtStockAdj.Rows[i]["unitCost"].ToString();
                dgvStockAdjustment[clmQtyOnhand.Index, i].Value = glb_function.GetQty(dtStockAdj.Rows[i]["itemid"].ToString(), dtStockAdj.Rows[0]["warehosue_id"].ToString()) + "";
                dgvStockAdjustment[clmOldUnitCost.Index, i].Value = dtStockAdj.Rows[i]["unitCost"].ToString();
                dgvStockAdjustment[clmTotalCost.Index, i].Value = (Convert.ToDouble(dgvStockAdjustment[clmRequiredQty.Index, i].Value) * Convert.ToDouble(dgvStockAdjustment[clmUnitCost.Index, i].Value)).ToString();
                nmbTotal.Value += Convert.ToDecimal(dgvStockAdjustment[clmTotalCost.Index, i].Value);

                
            }

            if (UserTemplate.HasPrivilege("btnPrint"))
                btnPrint.Enabled = true;

            btnSave.Enabled = false;
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if (lstWarehouses.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWarehouses.Focus();
                return;
            }
            Inventory.frmFindItem frm = new frmFindItem();
            frm.ShowDialog();
            if (frm.strPKid != "")
                GetItemData(frm.strPKid);
        }
        private void GetItemData(string strItemPkId)
        {


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtItem = cnn.GetDataTable("select pkid,itemno,itemname,unitcost," +
                "(select ifnull(sum(qty) ,0) from item_trans where item_id=i.pkid and warehouse_id=" + lstWarehouses.SelectedValue.ToString() + ") qty " +
                "from items i where pkid=" + strItemPkId);
            txtItemId.Text = strItemPkId;
            txtItemNo.Text = dtItem.Rows[0]["itemno"].ToString();
            txtItemName.Text = dtItem.Rows[0]["itemname"].ToString();
            nmbQtyOnHand.Value = Convert.ToDecimal(dtItem.Rows[0]["qty"].ToString());
            nmbUnitCost.Value = Convert.ToDecimal(dtItem.Rows[0]["unitcost"].ToString());
            nmbOldUnitCost.Value = Convert.ToDecimal(dtItem.Rows[0]["unitcost"].ToString());


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار الصنف");
                return;
            }
            if (nmbQty.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال الكمية");
                return;
            }
            if (strStackadj_type == "امر صرف")
                if (-nmbQty.Value + nmbQtyOnHand.Value < 0)
                {
                    glb_function.MsgBox("لايمكن ادخال كمية اقل من المخزون");
                    return;
                }
            for (int i = 0; i < dgvStockAdjustment.Rows.Count; i++)
            {
                if (txtItemId.Text ==dgvStockAdjustment[clmItemId.Index,i].Value .ToString())
                {
                    glb_function.MsgBox("تمت ادخال هذا الصنف من قبل");
                    return;
                }
            }
            dgvStockAdjustment.Rows.Add();
            dgvStockAdjustment[clmPKid.Index,dgvStockAdjustment.Rows.Count -1].Value  = "";
            dgvStockAdjustment[clmItemId.Index, dgvStockAdjustment.Rows.Count - 1].Value = txtItemId.Text;
            dgvStockAdjustment[clmItemNo.Index, dgvStockAdjustment.Rows.Count - 1].Value = txtItemNo.Text;
            dgvStockAdjustment[clmItemName.Index, dgvStockAdjustment.Rows.Count - 1].Value = txtItemName.Text;
            dgvStockAdjustment[clmQtyOnhand.Index, dgvStockAdjustment.Rows.Count - 1].Value = nmbQtyOnHand.Value.ToString();

            dgvStockAdjustment[clmRequiredQty.Index, dgvStockAdjustment.Rows.Count - 1].Value = nmbQty.Value.ToString();
            dgvStockAdjustment[clmUnitCost.Index, dgvStockAdjustment.Rows.Count - 1].Value = nmbUnitCost.Value.ToString();
            dgvStockAdjustment[clmTotalCost.Index, dgvStockAdjustment.Rows.Count - 1].Value = (nmbQty.Value * nmbUnitCost.Value).ToString();
            dgvStockAdjustment[clmOldUnitCost.Index, dgvStockAdjustment.Rows.Count - 1].Value = nmbOldUnitCost.Value.ToString();

           
            nmbTotal.Value += nmbQty.Value * nmbUnitCost.Value;

            txtItemId.Text = "";
            txtItemNo.Text = "";
            txtItemName.Text = "";
            nmbQty.Value = 0;
            nmbQtyOnHand.Value = 0;
            nmbUnitCost.Value = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }
        private bool CheckEntries()
        {
            if(lstAccNo.SelectedIndex ==-1)
            {
                glb_function.MsgBox("الرجاء اختيار الحساب");
                lstAccNo.Focus();
                return false;
            }

            if (lstWarehouses.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWarehouses.Focus();
                return false;
            }

            if (dgvStockAdjustment.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال صنف واحد على الاقل للتعديل");
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEntries())
                return;

            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from stockadjust_header b)");
            txtPkid.Text = dt.Rows[0][0].ToString();
            dt = cnnSave.GetDataTable("select warehouse_no from warehouse where pkid=" + lstWarehouses.SelectedValue.ToString());
            string strWarehouseNo = dt.Rows[0][0].ToString();
            // dt = cnnSave.GetDataTable("(select ifnull(max(b.stockadj_no),0)+1 from stockadjust_header b where branch_id="+glb_function.glb_strBranchPkid+" and warehosue_id="+lstWarehouses.SelectedValue.ToString()+ " and stackadj_type='"+strStackadj_type+"')");
            dt = cnnSave.GetDataTable("(select ifnull(max(convert(substring( substring(stockadj_no,instr(stockadj_no, '-')+1),instr( substring(stockadj_no,instr(stockadj_no, '-')+1),'-')+1), signed)), 0) + 1 from stockadjust_header b where branch_id=" + glb_function.glb_strBranchPkid + " and warehosue_id=" + lstWarehouses.SelectedValue.ToString() + " and stackadj_type='" + strStackadj_type + "')");
            txtStockAdjNo.Text = glb_function.glb_strBranchPkid + "-" + strWarehouseNo + "-" + dt.Rows[0][0].ToString();
            int icheck = cnnSave.TranDataToDB("insert into stockadjust_header " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtStockAdjNo.Text + "'" +
                            ",'" + strStackadj_type + "'" +
                        "," + glb_function.glb_strBranchPkid +
                           "," + lstWarehouses.SelectedValue.ToString() +
                          ",'" + txtStockAdjNote.Text.Trim() + "'" +
                        "," + lstAccNo.SelectedValue.ToString() +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات التعديل المخزني");
                return;
            }

            for (int i = 0; i < dgvStockAdjustment.Rows.Count; i++)
            {
                icheck = cnnSave.TranDataToDB("insert into stockadjust_details values ((select ifnull(max(b.pkid),0)+1 from stockadjust_details b)" +
                    "," + txtPkid.Text +
                    "," +dgvStockAdjustment[clmItemId.Index,i].Value.ToString()  +
                     "," + dgvStockAdjustment[clmRequiredQty.Index, i].Value.ToString()  +
                    ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الصنف");
                    return;
                }
                double dQty = 0;

                if (strStackadj_type == "امر توريد")
                {
                    dQty = Convert.ToDouble(dgvStockAdjustment[clmRequiredQty.Index, i].Value.ToString() );

                    double dOldunitCost = Convert.ToDouble(dgvStockAdjustment[clmOldUnitCost.Index, i].Value.ToString() );
                    double dQtyonhand = Convert.ToDouble(dgvStockAdjustment[clmQtyOnhand.Index, i].Value.ToString() );
                    double dRequiredQty = Convert.ToDouble(dgvStockAdjustment[clmRequiredQty.Index, i].Value.ToString());
                    double dUnitCost = Convert.ToDouble(dgvStockAdjustment[clmUnitCost.Index, i].Value.ToString() );
                    double dNewCost;
                    if (dQtyonhand + dRequiredQty == 0)
                        dNewCost = dUnitCost;
                    else
                     dNewCost = ((dOldunitCost * dQtyonhand) + (dRequiredQty * dUnitCost)) / (dQtyonhand + dRequiredQty);


                    icheck = cnnSave.TranDataToDB("update items set unitcost=" + dNewCost.ToString() + " where pkid=" + dgvStockAdjustment[clmItemId.Index, i].Value.ToString() );
                    if (icheck <= 0)
                    {
                        cnnSave.glb_RollbackTransaction();
                        glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات حركة الاصناف");
                        return;
                    }
                }

                else
                    dQty = -1 * Convert.ToDouble(dgvStockAdjustment[clmRequiredQty.Index, i].Value.ToString() );


                //اضافة الكمية الى المخزون
                icheck = cnnSave.TranDataToDB("insert into item_trans values ((select ifnull(max(b.pkid),0)+1 from item_trans b)" +
                  ",sysdate()" +
                   "," + glb_function.glb_strUserId +
                    "," + dgvStockAdjustment[clmItemId.Index, i].Value.ToString()  +
                     "," + lstWarehouses.SelectedValue.ToString() +
                       "," + dQty +
                   "," + txtPkid.Text +
                   ",'" + strStackadj_type + "'" +
                   ",''" +
                   ",'" + txtStockAdjNo.Text.Trim() + "'" +
                    ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                   ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات حركة الاصناف");
                    return;
                }

            }

            if (strStackadj_type == "امر توريد")
            {
                //تقييد عملية امر التوريد المخزني في الحسابات

                #region InventoryOrderIn
                DataTable dtKeys = cnnSave.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='امر توريد') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
                string strJPkid = dtKeys.Rows[0]["pkid"].ToString();

                // string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();

                string strJourNo = glb_function.glb_strBranchPkid + "-" + strJPkid;

                icheck = 0;

                icheck = cnnSave.TranDataToDB("insert into journal_header values (" + strJPkid +
                    ",'فعال'" +
                   ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                    "," + glb_function.glb_strUserId +
                    "," + glb_function.glb_strBranchPkid +
                    ",'" + strJourNo.Trim() + "'" +
                    ",'امر توريد'" +
                    "," + txtPkid.Text +
                    ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                    ",'قيدت من امر التوريد المخزني'" +
                     ",''" +
                       ",'" + txtStockAdjNo.Text + "'" +
                    ")");
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                    return;
                }

                //حفظ بيانات المدين 
                //يكون المخزون مدين في امر التوريد ويميزه انه اكبر من الصفر
                double dMainValue = (double)nmbTotal.Value;
                double dCurrValue = (double)nmbTotal.Value;
                icheck = cnnSave.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
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
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }

                //حفظ بيانات الدائن 
                //
                dMainValue = (double)nmbTotal.Value * -1;
                dCurrValue = (double)nmbTotal.Value * -1;
                icheck = cnnSave.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + strJPkid +
                "," + glb_function.glb_iMainCurrId +
                "," + lstAccNo.SelectedValue.ToString() +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",''" +
                  ",''" +
               ")");
                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }
                #endregion

            }
            else
            {
                //تقييد عملية امر الصرف المخزني في الحسابات
                #region InventoryOrderOut

                DataTable dtKeys = cnnSave.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " and trans_name='امر صرف') IssueNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
                string strJPkid = dtKeys.Rows[0]["pkid"].ToString();

                //string strIssueNo = dtKeys.Rows[0]["IssueNo"].ToString();

                string strJournalNo = glb_function.glb_strBranchPkid + "-" + strJPkid;

                icheck = 0;

                icheck = cnnSave.TranDataToDB("insert into journal_header values (" + strJPkid +
                    ",'فعال'" +
                    ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                    "," + glb_function.glb_strUserId +
                    "," + glb_function.glb_strBranchPkid +
                    ",'" + strJournalNo.Trim() + "'" +
                    ",'امر صرف'" +
                    "," + txtPkid.Text +
                   ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                    ",'قيدت من امر الصرف المخزني'" +
                     ",''" +
                      ",'" + txtStockAdjNo.Text + "'" +
                    ")");
                if (icheck <= 0)
                {
                    glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                    return;
                }

                //حفظ بيانات المدين 
                //
                double dMainValue = (double)nmbTotal.Value;
                double dCurrValue = (double)nmbTotal.Value;
                icheck = cnnSave.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + strJPkid +
                "," + glb_function.glb_iMainCurrId +
                "," + lstAccNo.SelectedValue.ToString() +
                "," + dMainValue +
                "," + dCurrValue +
                ",1" +
                ",''" +
                 ",''" +
               ")");
                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }


                //حفظ بيانات الدائن 
                //يكون الصندوق دائن في سند الصرف ويميزه انه اصغر من الصفر
                dMainValue = (double)nmbTotal.Value * -1;
                dCurrValue = (double)nmbTotal.Value * -1;
                icheck = cnnSave.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
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
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء حفظ التفاصيل");
                    return;
                }
                #endregion

            }

            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء اختيار الأمر");
                return;
            }
            string strTitel = "";
            if (strStackadj_type == "امر توريد")
                strTitel = "أمر توريد مخزني";
            else
                strTitel = "أمر صرف مخزني";



            cryRepInventoryIn report = new cryRepInventoryIn();
            frmReportContainer frm = new frmReportContainer();
            DataTable dtReport = new DataTable();
            TextObject txtCurrency = (TextObject)report.ReportDefinition.ReportObjects["txtReportTitel"];
            txtCurrency.Text = strTitel;

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            dtReport = cnn.GetDataTable("SELECT h.pkid,h.stockadj_no,h.warehosue_id,h.stackadj_note,date_format(h.created_date,'%d/%m/%Y') created_date, " +
                       " d.pkid dpkid, d.itemid, d.qty, " +
                       " i.itemno, i.itemname, i.UnitSellingPrice, i.unitCost, " +
                       " a.pkid acc_id, a.Acc_no, a.acc_name, " +
                       " w.warehouse_name " +
                       " FROM stockadjust_header h " +
                       " join stockadjust_details d on(h.pkid = d.header_id) " +
                       " join items i on(d.itemid = i.pkid) " +
                       " join accounts a on(a.pkid = h.acc_id) " +
                       " join warehouse w on(w.pkid = h.warehosue_id) " +
                      " and h.pkid =   " + txtPkid.Text);




            report.SetDataSource(dtReport);
            frm.CrystalReportsViewer1.ReportSource = report;




            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
