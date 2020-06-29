namespace OilStationW.Sales
{
    partial class frmInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPkid = new myText();
            this.btnFind = new SmallButton();
            this.txtInvoiceNo = new myText();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJourDate = new myDate();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInvoiceNote = new myText();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvInvoices = new myDataGrid();
            this.clmPump_empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWarehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOldCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNewCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalesAccId = new myText();
            this.txtInventoryAccId = new myText();
            this.txtCostGoodSoldAccId = new myText();
            this.btnPrint = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.nmbTotalSellingPrice = new myNumber();
            this.label13 = new System.Windows.Forms.Label();
            this.nmbEditor = new myNumber();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(430, 29);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(35, 26);
            this.txtPkid.TabIndex = 344;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::OilStationW.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(368, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 343;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(396, 29);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(139, 26);
            this.txtInvoiceNo.TabIndex = 342;
            this.txtInvoiceNo.W_ColumnName = "";
            this.txtInvoiceNo.W_OldValue = "";
            this.txtInvoiceNo.w_Tran = myText.Tran.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(541, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 341;
            this.label2.Text = "رقم الفاتورة";
            // 
            // dtpJourDate
            // 
            this.dtpJourDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpJourDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourDate.Location = new System.Drawing.Point(92, 32);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(195, 26);
            this.dtpJourDate.TabIndex = 354;
            this.dtpJourDate.W_ColumnName = "";
            this.dtpJourDate.W_OldValue = "";
            this.dtpJourDate.w_Tran = myDate.Tran.None;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F);
            this.label14.Location = new System.Drawing.Point(294, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 353;
            this.label14.Text = "التاريخ";
            // 
            // txtInvoiceNote
            // 
            this.txtInvoiceNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNote.Location = new System.Drawing.Point(92, 59);
            this.txtInvoiceNote.Name = "txtInvoiceNote";
            this.txtInvoiceNote.Size = new System.Drawing.Size(443, 26);
            this.txtInvoiceNote.TabIndex = 352;
            this.txtInvoiceNote.W_ColumnName = "";
            this.txtInvoiceNote.W_OldValue = "";
            this.txtInvoiceNote.w_Tran = myText.Tran.None;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(543, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 351;
            this.label7.Text = "ملاحظات";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInvoices.ColumnHeadersHeight = 30;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPump_empId,
            this.clmWarehouseId,
            this.clmPumpId,
            this.clmPumpNo,
            this.clmPumpName,
            this.clmItemId,
            this.clmItemName,
            this.clmEmpId,
            this.clmEmpAccId,
            this.clmEmpName,
            this.clmUnitSellingPrice,
            this.clmUnitCost,
            this.clmOldCounter,
            this.clmNewCounter,
            this.clmQty,
            this.clmTotalSellingPrice});
            this.dgvInvoices.EnableHeadersVisualStyles = false;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 86);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvInvoices.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInvoices.Size = new System.Drawing.Size(894, 342);
            this.dgvInvoices.TabIndex = 355;
            this.dgvInvoices.W_ClmName = "";
            this.dgvInvoices.W_PK = "";
            this.dgvInvoices.W_TableName = "";
            this.dgvInvoices.W_updValName = "";
            this.dgvInvoices.W_ValName = "";
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // clmPump_empId
            // 
            this.clmPump_empId.HeaderText = "رقم تعريف اسناد الطرمبة الى العامل";
            this.clmPump_empId.Name = "clmPump_empId";
            this.clmPump_empId.ReadOnly = true;
            this.clmPump_empId.Visible = false;
            // 
            // clmWarehouseId
            // 
            this.clmWarehouseId.HeaderText = "رقم تعريف المخزن";
            this.clmWarehouseId.Name = "clmWarehouseId";
            this.clmWarehouseId.ReadOnly = true;
            this.clmWarehouseId.Visible = false;
            // 
            // clmPumpId
            // 
            this.clmPumpId.HeaderText = "رقم تعريف الطرمبة";
            this.clmPumpId.Name = "clmPumpId";
            this.clmPumpId.ReadOnly = true;
            this.clmPumpId.Visible = false;
            // 
            // clmPumpNo
            // 
            this.clmPumpNo.HeaderText = "رقم الطرمبة";
            this.clmPumpNo.Name = "clmPumpNo";
            this.clmPumpNo.ReadOnly = true;
            this.clmPumpNo.Width = 120;
            // 
            // clmPumpName
            // 
            this.clmPumpName.HeaderText = "اسم الطرمبة";
            this.clmPumpName.Name = "clmPumpName";
            this.clmPumpName.ReadOnly = true;
            this.clmPumpName.Width = 120;
            // 
            // clmItemId
            // 
            this.clmItemId.HeaderText = "رقم تعريف الصنف";
            this.clmItemId.Name = "clmItemId";
            this.clmItemId.ReadOnly = true;
            this.clmItemId.Visible = false;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "اسم الصنف";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            this.clmItemName.Width = 80;
            // 
            // clmEmpId
            // 
            this.clmEmpId.HeaderText = "رقم تعريف العامل";
            this.clmEmpId.Name = "clmEmpId";
            this.clmEmpId.ReadOnly = true;
            this.clmEmpId.Visible = false;
            // 
            // clmEmpAccId
            // 
            this.clmEmpAccId.HeaderText = "رقم حساب العامل";
            this.clmEmpAccId.Name = "clmEmpAccId";
            this.clmEmpAccId.ReadOnly = true;
            this.clmEmpAccId.Visible = false;
            // 
            // clmEmpName
            // 
            this.clmEmpName.HeaderText = "اسم العامل";
            this.clmEmpName.Name = "clmEmpName";
            this.clmEmpName.ReadOnly = true;
            this.clmEmpName.Width = 120;
            // 
            // clmUnitSellingPrice
            // 
            this.clmUnitSellingPrice.HeaderText = "سعر البيع";
            this.clmUnitSellingPrice.Name = "clmUnitSellingPrice";
            this.clmUnitSellingPrice.ReadOnly = true;
            this.clmUnitSellingPrice.Width = 70;
            // 
            // clmUnitCost
            // 
            this.clmUnitCost.HeaderText = "سعر التكلفة";
            this.clmUnitCost.Name = "clmUnitCost";
            this.clmUnitCost.ReadOnly = true;
            this.clmUnitCost.Visible = false;
            // 
            // clmOldCounter
            // 
            this.clmOldCounter.HeaderText = "القراء السابقة";
            this.clmOldCounter.Name = "clmOldCounter";
            this.clmOldCounter.ReadOnly = true;
            // 
            // clmNewCounter
            // 
            this.clmNewCounter.HeaderText = "القراءة الحالية";
            this.clmNewCounter.Name = "clmNewCounter";
            this.clmNewCounter.ReadOnly = true;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "الكمية";
            this.clmQty.Name = "clmQty";
            this.clmQty.ReadOnly = true;
            this.clmQty.Width = 80;
            // 
            // clmTotalSellingPrice
            // 
            this.clmTotalSellingPrice.HeaderText = "السعر";
            this.clmTotalSellingPrice.Name = "clmTotalSellingPrice";
            this.clmTotalSellingPrice.ReadOnly = true;
            // 
            // txtSalesAccId
            // 
            this.txtSalesAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSalesAccId.Location = new System.Drawing.Point(761, 434);
            this.txtSalesAccId.Name = "txtSalesAccId";
            this.txtSalesAccId.Size = new System.Drawing.Size(16, 26);
            this.txtSalesAccId.TabIndex = 358;
            this.txtSalesAccId.Visible = false;
            this.txtSalesAccId.W_ColumnName = "";
            this.txtSalesAccId.W_OldValue = "";
            this.txtSalesAccId.w_Tran = myText.Tran.None;
            // 
            // txtInventoryAccId
            // 
            this.txtInventoryAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInventoryAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInventoryAccId.Location = new System.Drawing.Point(783, 434);
            this.txtInventoryAccId.Name = "txtInventoryAccId";
            this.txtInventoryAccId.Size = new System.Drawing.Size(11, 26);
            this.txtInventoryAccId.TabIndex = 357;
            this.txtInventoryAccId.Visible = false;
            this.txtInventoryAccId.W_ColumnName = "";
            this.txtInventoryAccId.W_OldValue = "";
            this.txtInventoryAccId.w_Tran = myText.Tran.None;
            // 
            // txtCostGoodSoldAccId
            // 
            this.txtCostGoodSoldAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostGoodSoldAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCostGoodSoldAccId.Location = new System.Drawing.Point(800, 434);
            this.txtCostGoodSoldAccId.Name = "txtCostGoodSoldAccId";
            this.txtCostGoodSoldAccId.Size = new System.Drawing.Size(11, 26);
            this.txtCostGoodSoldAccId.TabIndex = 356;
            this.txtCostGoodSoldAccId.Visible = false;
            this.txtCostGoodSoldAccId.W_ColumnName = "";
            this.txtCostGoodSoldAccId.W_OldValue = "";
            this.txtCostGoodSoldAccId.w_Tran = myText.Tran.None;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPrint.Location = new System.Drawing.Point(326, 432);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 362;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.Chocolate;
            this.btnClose.Location = new System.Drawing.Point(250, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 361;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSave.Location = new System.Drawing.Point(402, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 360;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnNew.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNew.Location = new System.Drawing.Point(478, 432);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 359;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // nmbTotalSellingPrice
            // 
            this.nmbTotalSellingPrice.Enabled = false;
            this.nmbTotalSellingPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbTotalSellingPrice.Location = new System.Drawing.Point(3, 431);
            this.nmbTotalSellingPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbTotalSellingPrice.Name = "nmbTotalSellingPrice";
            this.nmbTotalSellingPrice.Size = new System.Drawing.Size(133, 26);
            this.nmbTotalSellingPrice.TabIndex = 364;
            this.nmbTotalSellingPrice.W_ColumnName = "";
            this.nmbTotalSellingPrice.W_OldValue = "";
            this.nmbTotalSellingPrice.w_Tran = myNumber.Tran.None;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(141, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 22);
            this.label13.TabIndex = 363;
            this.label13.Text = "اجمالي الفاتورة";
            // 
            // nmbEditor
            // 
            this.nmbEditor.DecimalPlaces = 2;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(360, 225);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 23);
            this.nmbEditor.TabIndex = 365;
            this.nmbEditor.ThousandsSeparator = true;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(903, 473);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.nmbTotalSellingPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSalesAccId);
            this.Controls.Add(this.txtInventoryAccId);
            this.Controls.Add(this.txtCostGoodSoldAccId);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.dtpJourDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtInvoiceNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label2);
            this.Name = "frmInvoices";
            this.Tag = "frmInvoices";
            this.Text = "فاتورة المبيعات";
            this.Titel = "فاتورة المبيعات";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNo, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNote, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.dtpJourDate, 0);
            this.Controls.SetChildIndex(this.dgvInvoices, 0);
            this.Controls.SetChildIndex(this.txtCostGoodSoldAccId, 0);
            this.Controls.SetChildIndex(this.txtInventoryAccId, 0);
            this.Controls.SetChildIndex(this.txtSalesAccId, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.nmbTotalSellingPrice, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText txtPkid;
        private SmallButton btnFind;
        private myText txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private myDate dtpJourDate;
        private System.Windows.Forms.Label label14;
        private myText txtInvoiceNote;
        private System.Windows.Forms.Label label7;
        private myDataGrid dgvInvoices;
        private myText txtSalesAccId;
        private myText txtInventoryAccId;
        private myText txtCostGoodSoldAccId;
        private MainButton btnPrint;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myNumber nmbTotalSellingPrice;
        private System.Windows.Forms.Label label13;
        private myNumber nmbEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPump_empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWarehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOldCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNewCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalSellingPrice;
    }
}
