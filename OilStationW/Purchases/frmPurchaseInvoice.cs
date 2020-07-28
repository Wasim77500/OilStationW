using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Purchases
{
    public partial class frmPurchaseInvoice : OilStationW.myForm
    {
        private string strInventoryAccId;
        bool strDataFromDataSource = false;
        public frmPurchaseInvoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseInvoice_Load(object sender, EventArgs e)
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

            if (UserTemplate.HasPrivilege("btnSave"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            btnPrint.Enabled = false;

            nmbExpTotal.DecimalPlaces =  glb_function.glb_iMainCurrDecimal;
            nmbItemTotal.DecimalPlaces =  glb_function.glb_iMainCurrDecimal;
            
              
                dgvItems.Rows.Add(10);

               
                dgvExpensses.Rows.Add(10);

            
        }
        private void FillData()
        {
             strDataFromDataSource = true;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtBrnch = cnn.GetDataTable("SELECT pkid,warehouse_name FROM warehouse where branch_id= " + glb_function.glb_strBranchPkid);
            lstWarehouse.DataSource = dtBrnch.DefaultView;
            lstWarehouse.ValueMember = "pkid";
            lstWarehouse.DisplayMember = "warehouse_name";



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
            frmFindPurchaseInvoice frm = new frmFindPurchaseInvoice();

            frm.ShowDialog();
            if (frm.strPKid != "")
                GetData(frm.strPKid);
        }

        private void GetData(string strInvoiceId)
        {
            dgvExpensses.Rows.Clear();
            dgvItems.Rows.Clear();
            nmbExpTotal.Value = 0;
            nmbItemTotal.Value = 0;
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtPurchares = cnn.GetDataTable("SELECT pkid,invoice_no,warehosue_id,acc_id,pi_note " +
                       " FROM pi_header " +
                       " where pkid=" + strInvoiceId);

            txtPkid.Text = dtPurchares.Rows[0]["pkid"].ToString();
            txtInvoiceNo.Text = dtPurchares.Rows[0]["invoice_no"].ToString();
            lstWarehouse.SelectedValue = dtPurchares.Rows[0]["warehosue_id"].ToString();
            lstAccNo.SelectedValue = dtPurchares.Rows[0]["acc_id"].ToString();
            lstAccName.SelectedValue = dtPurchares.Rows[0]["acc_id"].ToString();
            txtInvoiceNote.Text = dtPurchares.Rows[0]["pi_note"].ToString();

            dtPurchares.Clear();

            dtPurchares = cnn.GetDataTable("select d.pkid,d.qty,d.unit_price,d.unit_cost,i.itemno,i.itemname " +
                           " from pi_details d " +
                           " join items i on (i.pkid = d.item_id) " +
                           " where d.header_id = " + strInvoiceId);

            
            for (int i = 0; i < dtPurchares.Rows.Count; i++)
            {
                dgvItems.Rows.Add();
                dgvItems[clmItemPKid.Index,i].Value  = dtPurchares.Rows[i]["pkid"].ToString();
                dgvItems[clmItemNo.Index, i].Value = dtPurchares.Rows[i]["itemno"].ToString();
                dgvItems[clmItemName.Index, i].Value = dtPurchares.Rows[i]["itemname"].ToString();
                dgvItems[clmItemQty.Index, i].Value = dtPurchares.Rows[i]["qty"].ToString();
                dgvItems[clmItemPrice.Index, i].Value = dtPurchares.Rows[i]["unit_price"].ToString();
                nmbItemTotal.Value += Convert.ToDecimal(dtPurchares.Rows[i]["qty"].ToString()) * Convert.ToDecimal(dtPurchares.Rows[i]["unit_price"].ToString());
               

            }


            dtPurchares.Clear();

            dtPurchares = cnn.GetDataTable("SELECT pie.pkid,expenss_name,pie.value,pie.acc_id,a.Acc_no,a.acc_name " +
                           " FROM pi_expensses pie " +
                           " join accounts a on(a.pkid = pie.acc_id) " +
                           " where pie.header_id = " + strInvoiceId);


           
            for (int i = 0; i < dtPurchares.Rows.Count; i++)
            {
                dgvExpensses.Rows.Add();
                dgvExpensses[clmAccId.Index,i].Value   = dtPurchares.Rows[i]["acc_id"].ToString();
                dgvExpensses[clmAccNo.Index, i].Value = dtPurchares.Rows[i]["Acc_no"].ToString();
                dgvExpensses[clmAccName.Index, i].Value = dtPurchares.Rows[i]["acc_name"].ToString();
                dgvExpensses[clmExpName.Index, i].Value = dtPurchares.Rows[i]["expenss_name"].ToString();
                dgvExpensses[clmExpValue.Index, i].Value = dtPurchares.Rows[i]["value"].ToString();
                

                nmbExpTotal.Value += Convert.ToDecimal(dtPurchares.Rows[i]["value"].ToString());
            }


            // if (UserTemplate.HasPrivilege("btnPrint"))
            btnPrint.Enabled = true;

            btnSave.Enabled = false;
        }

        private void btnInsertDoc_Click(object sender, EventArgs e)
        {
            if (txtPkid.Text == "")
            {
                glb_function.MsgBox("الرجاء ادخال او حفظ الفاتورة اولا");
                return;
            }



            frmPurchaseDocuments frm = new frmPurchaseDocuments();
            frm.strHeader_id = txtPkid.Text;
            frm.ShowDialog();
        }

        private void btnGetExpensses_Click(object sender, EventArgs e)
        {
            if (nmbItemTotal.Value <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال  بيانات الفاتورة و الاصناف اولا قبل المصاريف");
                return;
            }
            dgvExpensses.Rows.Clear();
            nmbExpTotal.Value = 0;
            frmPurchaseExpensses frm = new frmPurchaseExpensses();
            frm.ShowDialog();

            for (int i = 0; i < frm.dgvExpensses.Rows.Count; i++)
            {
              
                if (frm.dgvExpensses[frm.clmSelect.Index,i].Value.ToString()  == "True")
                {
                    dgvExpensses.Rows.Add();
                    dgvExpensses[clmExpPKid.Index, i].Value  = "";
                    dgvExpensses[clmAccId.Index, i].Value = frm.dgvExpensses[frm.clmAccId.Index, i].Value.ToString();
                    dgvExpensses[clmAccNo.Index, i].Value = frm.dgvExpensses[frm.clmAccNo.Index, i].Value.ToString() ;
                    dgvExpensses[clmAccName.Index, i].Value = frm.dgvExpensses[frm.clmAccName.Index, i].Value.ToString();
                    dgvExpensses[clmExpName.Index, i].Value = frm.dgvExpensses[frm.clmExpName.Index, i].Value.ToString() ;
                    string strCalcMethod = frm.dgvExpensses[frm.clmCalcMethod.Index, i].Value.ToString() ;
                    decimal dExpValue = Convert.ToDecimal(frm.dgvExpensses[frm.clmExpValue.Index, i].Value.ToString() );

                    decimal dExpPrice = 0;//يتم احتسابه بناء على طريقة الحساب اذا كانت نسبة او مبلغ
                    if (strCalcMethod == "مبلغ")
                        dExpPrice = Math.Round(dExpValue, glb_function.glb_iMainCurrDecimal);
                    else
                        dExpPrice = Math.Round(Convert.ToDecimal(nmbItemTotal.Value) * dExpValue / 100, glb_function.glb_iMainCurrDecimal);

                    dgvExpensses[clmExpValue.Index, i].Value = dExpPrice.ToString();
                   
                    

                }
            }

            GetExpTotal();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new glb_function().clearItems(this);
            PrepareForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text.Trim() == "")
            {
                glb_function.MsgBox("الرجاء ادخال رقم الفاتورة");
                txtInvoiceNo.Focus();
                return;
            }

            if (lstWarehouse.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار المخزن");
                lstWarehouse.Focus();
                return;
            }

            if (lstAccNo.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار رقم الحساب");
                lstAccNo.Focus();
                return;
            }

            if (lstAccName.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار اسم الحساب");
                lstAccName.Focus();
                return;
            }

            if (dgvItems.Rows.Count <= 0)
            {
                glb_function.MsgBox("الرجاء ادخال صنف واحد على الاقل");
                return;
            }

            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {

                if (dgvItems[clmItemId.Index,i].Value ==null || dgvItems[clmItemId.Index, i].Value.ToString() == "")
                    continue;

                if (nmbExpTotal.Value > 0)
                {
                    //صيب الريال الواحد = مصاريف الشحن / قيمة البضاعة
                    double dRY_share = (double)(nmbExpTotal.Value / nmbItemTotal.Value);

                    //إذن نصيب الوحدة الواحدة من   تكلفة الشحن

                    double dQty = Convert.ToDouble(dgvItems[clmItemQty.Index, i].Value.ToString());
                    double dUnitPrice = Convert.ToDouble(dgvItems[clmItemPrice.Index, i].Value.ToString() );
                    double UnitCostShare = dUnitPrice * dRY_share;

                    //تكلفة الصنف

                    double dUnitCost = UnitCostShare + dUnitPrice;
                    
                   dgvItems[clmItemCost.Index,i].Value = dUnitCost.ToString();
                    
                }
                else
                {
                    double dUnitPrice = Convert.ToDouble(dgvItems[clmItemPrice.Index, i].Value.ToString() );

                    dgvItems[clmItemCost.Index, i].Value = dUnitPrice.ToString();
                    
                }
            }




            ConnectionToMySQL cnnSave = new ConnectionToMySQL();
            DataTable dt = cnnSave.GetDataTable("(select ifnull(max(b.pkid),0)+1 from pi_header b)");
            txtPkid.Text = dt.Rows[0][0].ToString();

            int icheck = cnnSave.TranDataToDB("insert into pi_header " +
                          " values(" + txtPkid.Text + "" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",'" + txtInvoiceNo.Text.Trim() + "'" +
                           "," + lstWarehouse.SelectedValue.ToString() +
                            "," + lstAccNo.SelectedValue.ToString() +
                          ",'" + txtInvoiceNote.Text.Trim() + "'" +
                           ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات فاتورة الشراء");
                return;
            }

            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems[clmItemId.Index,i].Value==null || dgvItems[clmItemId.Index, i].Value.ToString() == "")
                    continue;

                icheck = cnnSave.TranDataToDB("insert into pi_details values ((select ifnull(max(b.pkid),0)+1 from pi_details b)" +
                   "," + txtPkid.Text +
                   "," + dgvItems[clmItemId.Index, i].Value.ToString()  +
                    "," + dgvItems[clmItemQty.Index, i].Value.ToString()  +
                    "," + dgvItems[clmItemPrice.Index, i].Value.ToString()  +
                    "," + dgvItems[clmItemCost.Index, i].Value.ToString()  +
                   ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الصنف");
                    return;
                }



                //تغيير تكلفة الصنف 
                double dQty = Convert.ToDouble(dgvItems[clmItemQty.Index, i].Value.ToString() );

                double dOldunitCost = Convert.ToDouble(dgvItems[clmOldUnitCost.Index, i].Value.ToString() );
                double dQtyonhand = Convert.ToDouble(dgvItems[clmQtyOnhand.Index, i].Value.ToString() );
                double dRequiredQty = Convert.ToDouble(dgvItems[clmItemQty.Index, i].Value.ToString() );
                double dUnitCost = Convert.ToDouble(dgvItems[clmItemCost.Index, i].Value.ToString() );


                double dNewCost = ((dOldunitCost * dQtyonhand) + (dRequiredQty * dUnitCost)) / (dQtyonhand + dRequiredQty);


                icheck = cnnSave.TranDataToDB("update items set unitcost=" + dNewCost.ToString() + " where pkid=" + dgvItems[clmItemId.Index, i].Value.ToString() );
                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات حركة الاصناف");
                    return;
                }



                //اضافة الكمية الى المخزون
                icheck = cnnSave.TranDataToDB("insert into item_trans values ((select ifnull(max(b.pkid),0)+1 from item_trans b)" +
                   ",SYSDATE() " +
                   "," + glb_function.glb_strUserId +
                    "," +dgvItems[clmItemId.Index,i].Value .ToString()  +
                     "," + lstWarehouse.SelectedValue.ToString() +
                       "," + dQty +
                   "," + txtPkid.Text +
                   ",'فاتورة شراء'" +
                   ",''" +
                    ",'" + txtInvoiceNo.Text.Trim() + "'" +
                     ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                   ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات حركة الاصناف");
                    return;
                }

            }//end item for loop

            //تقييد عملية الشراء في الحسابات

            #region InventoryOrderIn
            DataTable dtKeys = cnnSave.GetDataTable("select (select  ifnull(max( convert(  substring(jour_no,instr(jour_no,'-')+1),signed)),0)+1 FROM journal_header where Branch_id=" + glb_function.glb_strBranchPkid + " ) JourNo,(select ifnull(max(pkid),0)+1 from journal_header) pkid");
            string strJPkid = dtKeys.Rows[0]["pkid"].ToString();



            string strJourNo = glb_function.glb_strBranchPkid + "-" + dtKeys.Rows[0]["JourNo"].ToString();

            icheck = 0;

            icheck = cnnSave.TranDataToDB("insert into journal_header values (" + strJPkid +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                "," + glb_function.glb_strBranchPkid +
                ",'" + strJourNo.Trim() + "'" +
                ",'فاتورة شراء'" +
                "," + txtPkid.Text +
                 ",str_to_date('" + dtpJourDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                ",'قيدت من فاتورة المشتريات'" +
                 ",''" +
                  ",'" + txtInvoiceNo.Text.Trim() + "'" +
                ")");
            if (icheck <= 0)
            {
                cnnSave.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء حفظ البيانات الأساسية");
                return;
            }

            //حفظ بيانات المدين 
            //يكون المخزون مدين في فاتورة الشراء ويميزه انه اكبر من الصفر
            double dMainValue = (double)(nmbItemTotal.Value + nmbExpTotal.Value);
            double dCurrValue = dMainValue;
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
            dMainValue = (double)nmbItemTotal.Value * -1;
            dCurrValue = dMainValue;
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

            for (int j = 0; j < dgvExpensses.Rows.Count; j++)
            {
                if (dgvExpensses[clmAccId.Index,j].Value ==null || dgvExpensses[clmAccId.Index, j].Value.ToString()   == "")
                    continue;
                //حفظ قيد المصاريف على الحاسب المحدد للمصروف
                dMainValue = Convert.ToDouble(dgvExpensses[clmExpValue.Index, j].Value.ToString() ) * -1;
                dCurrValue = dMainValue;
                icheck = cnnSave.TranDataToDB("insert into journal_details values ((select ifnull(max(b.pkid),0)+1 from journal_details b )" +
               ",'فعال'" +
               ",sysdate()" +
               "," + glb_function.glb_strUserId +
                "," + strJPkid +
                "," + glb_function.glb_iMainCurrId +
                "," + dgvExpensses[clmAccId.Index, j].Value.ToString()  +
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

                //حفظ بيانات المصاريف في جدول المصاريف التابع لفاتورة الشراء
                //pi_expensses
                icheck = cnnSave.TranDataToDB("insert into pi_expensses values ((select ifnull(max(b.pkid),0)+1 from pi_expensses b)" +
                 "," + txtPkid.Text +
                 ",'" + dgvExpensses[clmExpName.Index, j].Value.ToString()  + "'" +
                  "," + dgvExpensses[clmExpValue.Index, j].Value.ToString()  +
                  "," + dgvExpensses[clmAccId.Index, j].Value.ToString()  +
                 ")");

                if (icheck <= 0)
                {
                    cnnSave.glb_RollbackTransaction();
                    glb_function.MsgBox("حدث خطأ اثناء عملية حفظ بيانات الصنف");
                    return;
                }



            }
            #endregion


            cnnSave.glb_commitTransaction();
            glb_function.MsgBox("تمت العملية بنجاح");
            GetData(txtPkid.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

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

                dgvItems[Convert.ToUInt16(nmbEditor.W_ColumnName), Convert.ToUInt16(nmbEditor.Tag.ToString())].Value = nmbEditor.Value.ToString();

                GetItemTotal();
               
            }
        }
        private void GetItemTotal()
        {
            decimal dTotal = 0;
            decimal dQty = 0;
            decimal dPrice = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems[clmItemId.Index, i].Value == null|| dgvItems[clmItemId.Index, i].Value.ToString() =="")
                    continue;

                if (dgvItems[clmItemPrice.Index, i].Value == null || dgvItems[clmItemPrice.Index, i].Value.ToString() == "")
                    dPrice = 0;
                else
                    dPrice = Convert.ToDecimal(dgvItems[clmItemPrice.Index, i].Value.ToString());
                if (dgvItems[clmItemQty.Index, i].Value == null || dgvItems[clmItemQty.Index, i].Value.ToString() == "")
                    dQty = 0;
                else
                    dQty = Convert.ToDecimal(dgvItems[clmItemQty.Index, i].Value.ToString());


                dTotal = dTotal+( dPrice * dQty);
            }

            nmbItemTotal.Value = dTotal;
        }
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
           


          
            DataGridViewCell abc = dgvItems.CurrentCell;
            Rectangle RECT = dgvItems.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);
            

            nmbEditor.W_ColumnName = e.ColumnIndex.ToString();
            // nmbEditor.DecimalPlaces = nmbUNIT_PRICE.DecimalPlaces;
            nmbEditor.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == clmItemQty.Index)
            {
                if (dgvItems[clmItemQty.Index, e.RowIndex].Value == null || dgvItems[clmItemQty.Index, e.RowIndex].Value.ToString() == "")
                    dgvItems[clmItemQty.Index, e.RowIndex].Value = "0";

                nmbEditor.Value = Convert.ToDecimal(dgvItems[clmItemQty.Index, e.RowIndex].Value.ToString());

                CtlLocationItem(RECT, nmbEditor);

            }
            else if (e.ColumnIndex == clmItemPrice.Index)
            {
                if (dgvItems[clmItemPrice.Index, e.RowIndex].Value == null || dgvItems[clmItemPrice.Index, e.RowIndex].Value.ToString() == "")
                    dgvItems[clmItemPrice.Index, e.RowIndex].Value = "0";
                nmbEditor.Value = Convert.ToDecimal(dgvItems[clmItemPrice.Index, e.RowIndex].Value.ToString());
                CtlLocationItem(RECT, nmbEditor);
            }
        }
        private void CtlLocationItem(Rectangle rect, Control ctrl)
        {

           
            ctrl.Top = dgvItems.Location.Y + rect.Y;
            ctrl.Left = dgvItems.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetItem(e.ColumnIndex,e.RowIndex);
        }
        private void GetItem(int iColumn,int iRow)
        {
            if (iColumn == clmItemNo.Index || iColumn == clmItemName.Index)
            {

                if (lstWarehouse.SelectedIndex == -1)
                {
                    glb_function.MsgBox("الرجاء اختيار المخزن اولا");
                    lstWarehouse.Focus();
                    return;
                }
                Inventory.frmFindItem frm = new Inventory.frmFindItem();
                frm.strWhere = " ";
                frm.ShowDialog();
                if (frm.strPKid != "")
                {
                   
                   dgvItems[clmItemPKid.Index,iRow].Value = "";
                    dgvItems[clmItemId.Index, iRow].Value = frm.strPKid;
                    dgvItems[clmItemNo.Index, iRow].Value = frm.strItemNo;
                    dgvItems[clmItemName.Index, iRow].Value = frm.strItemName;
                    dgvItems[clmOldUnitCost.Index, iRow].Value = frm.strUnitCost;
                    dgvItems[clmQtyOnhand.Index, iRow].Value = (glb_function.GetQty(frm.strPKid, lstWarehouse.SelectedValue.ToString())).ToString();
                   
                   
                }
            }

        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvItems.Rows.Count < 0)
                return;
         


            if (e.KeyCode == Keys.F9)
            {
                GetItem(dgvItems.CurrentCell.ColumnIndex,dgvItems.CurrentCell.RowIndex);
            }
            else if (e.KeyCode == Keys.F7)
            {
                
                dgvItems.Rows.Add();


            }
        }

        private void nmbEditorExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void nmbEditorExp_Leave(object sender, EventArgs e)
        {
            if (nmbEditorExp.Visible == true)
            {
                nmbEditorExp.Visible = false;

                dgvExpensses[Convert.ToUInt16(nmbEditorExp.W_ColumnName), Convert.ToUInt16(nmbEditorExp.Tag.ToString())].Value = nmbEditorExp.Value.ToString();

                GetExpTotal();

            }
        }
        private void GetExpTotal()
        {

            decimal dTotal = 0;
            decimal dValue = 0;
           
            for (int i = 0; i < dgvExpensses.Rows.Count; i++)
            {
                if (dgvExpensses[clmAccId.Index, i].Value == null || dgvExpensses[clmAccId.Index, i].Value.ToString() == "")
                    continue;

                if (dgvExpensses[clmExpValue.Index, i].Value == null || dgvExpensses[clmExpValue.Index, i].Value.ToString() == "")
                    dValue = 0;
                else
                    dValue = Convert.ToDecimal(dgvExpensses[clmExpValue.Index, i].Value.ToString());
               

                dTotal = dTotal + dValue;
            }

            nmbExpTotal.Value = dTotal;
        }

        private void dgvExpensses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;




            DataGridViewCell abc = dgvExpensses.CurrentCell;
            Rectangle RECT = dgvExpensses.GetCellDisplayRectangle(abc.ColumnIndex, abc.RowIndex, true);


            nmbEditorExp.W_ColumnName = e.ColumnIndex.ToString();
            // nmbEditor.DecimalPlaces = nmbUNIT_PRICE.DecimalPlaces;
            nmbEditorExp.Tag = e.RowIndex.ToString();

            if (e.ColumnIndex == clmExpValue.Index)
            {
                if (dgvExpensses[clmExpValue.Index, e.RowIndex].Value == null || dgvExpensses[clmExpValue.Index, e.RowIndex].Value.ToString() == "")
                    dgvExpensses[clmExpValue.Index, e.RowIndex].Value = "0";

                nmbEditorExp.Value = Convert.ToDecimal(dgvExpensses[clmExpValue.Index, e.RowIndex].Value.ToString());

                CtlLocationExp(RECT, nmbEditorExp);

            }
            
        }
        private void CtlLocationExp(Rectangle rect, Control ctrl)
        {


            ctrl.Top = dgvExpensses.Location.Y + rect.Y;
            ctrl.Left = dgvExpensses.Location.X + rect.X;

            ctrl.Width = rect.Width;
            ctrl.Height = rect.Height;
            ctrl.BringToFront();
            ctrl.Visible = true;

            ctrl.Focus();


        }

        private void dgvExpensses_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvExpensses.Rows.Count < 0)
                return;
           


            if (e.KeyCode == Keys.F9)
            {
                GetAccountName();
            }
            else if (e.KeyCode == Keys.F7)
            {
              
                dgvExpensses.Rows.Add();


            }
        }

        private void GetAccountName()
        {
            if (dgvExpensses.CurrentCell.ColumnIndex == clmAccNo.Index || dgvExpensses.CurrentCell.ColumnIndex == clmAccName.Index)
            {
                Accounts.frmFindAccount frm = new Accounts.frmFindAccount();
                frm.strWhere = " ";
                frm.ShowDialog();
                if (frm.strPKid != "")
                {
                  
                    int iRow = dgvExpensses.CurrentCell.RowIndex;
                   dgvExpensses[clmExpPKid.Index, iRow].Value   = "";
                    dgvExpensses[clmAccId.Index, iRow].Value = frm.strPKid;
                    dgvExpensses[clmAccNo.Index, iRow].Value = frm.strAccNo;
                    dgvExpensses[clmAccName.Index, iRow].Value = frm.strAccName;

                   
                }
            }

        }

        private void dgvExpensses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAccountName();
        }
    }
}
