namespace OilStationW.Sales
{
    partial class frmInvoicesOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicesOld));
            this.btnPrint = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new myText();
            this.lstPumps = new myList();
            this.txtItemNo = new myText();
            this.nmbOnhandQty = new myNumber();
            this.nmbPreviousCounter = new myNumber();
            this.nmbRequiredQty = new myNumber();
            this.txtInvoiceNote = new myText();
            this.btnFind = new SmallButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstWareHouse = new myList();
            this.txtItemName = new myText();
            this.txtEmpName = new myText();
            this.nmbTotalSellingPrice = new myNumber();
            this.nmbCurrentCounter = new myNumber();
            this.nmbUnitSellingPrice = new myNumber();
            this.txtPkid = new myText();
            this.txtPumpEmpId = new myText();
            this.txtEmpId = new myText();
            this.txtEmpAccId = new myText();
            this.txtCostGoodSoldAccId = new myText();
            this.txtInventoryAccId = new myText();
            this.txtSalesAccId = new myText();
            this.txtItemPkid = new myText();
            this.nmbUnitCost = new myNumber();
            this.dtpJourDate = new myDate();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOnhandQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPreviousCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRequiredQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCurrentCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitCost)).BeginInit();
            this.SuspendLayout();
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
            this.btnPrint.Location = new System.Drawing.Point(199, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 312;
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
            this.btnClose.Location = new System.Drawing.Point(123, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 311;
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
            this.btnSave.Location = new System.Drawing.Point(275, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 310;
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
            this.btnNew.Location = new System.Drawing.Point(351, 244);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 309;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(462, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 313;
            this.label2.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(466, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 314;
            this.label1.Text = "الطرمبة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(458, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 315;
            this.label3.Text = "الكمية المباعة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(459, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 316;
            this.label4.Text = "العداد السابق";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(459, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 317;
            this.label5.Text = "الكمية الحالية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(459, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 318;
            this.label6.Text = "رقم الصنف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(467, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 319;
            this.label7.Text = "ملاحظات";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(317, 31);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(139, 26);
            this.txtInvoiceNo.TabIndex = 320;
            this.txtInvoiceNo.W_ColumnName = "";
            this.txtInvoiceNo.W_OldValue = "";
            this.txtInvoiceNo.w_Tran = myText.Tran.None;
            // 
            // lstPumps
            // 
            this.lstPumps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPumps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPumps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPumps.Font = new System.Drawing.Font("Arial", 12F);
            this.lstPumps.FormattingEnabled = true;
            this.lstPumps.Location = new System.Drawing.Point(289, 61);
            this.lstPumps.Name = "lstPumps";
            this.lstPumps.Size = new System.Drawing.Size(167, 26);
            this.lstPumps.TabIndex = 321;
            this.lstPumps.W_ColumnName = "";
            this.lstPumps.W_OldValue = "";
            this.lstPumps.w_Tran = myList.Tran.None;
            this.lstPumps.w_ValueType = myList.ValueType.TEXT;
            this.lstPumps.SelectedIndexChanged += new System.EventHandler(this.lstPumps_SelectedIndexChanged);
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemNo.Location = new System.Drawing.Point(289, 90);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(167, 26);
            this.txtItemNo.TabIndex = 322;
            this.txtItemNo.W_ColumnName = "";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.w_Tran = myText.Tran.None;
            // 
            // nmbOnhandQty
            // 
            this.nmbOnhandQty.Enabled = false;
            this.nmbOnhandQty.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbOnhandQty.Location = new System.Drawing.Point(289, 120);
            this.nmbOnhandQty.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbOnhandQty.Name = "nmbOnhandQty";
            this.nmbOnhandQty.Size = new System.Drawing.Size(167, 26);
            this.nmbOnhandQty.TabIndex = 323;
            this.nmbOnhandQty.W_ColumnName = "";
            this.nmbOnhandQty.W_OldValue = "";
            this.nmbOnhandQty.w_Tran = myNumber.Tran.None;
            // 
            // nmbPreviousCounter
            // 
            this.nmbPreviousCounter.Enabled = false;
            this.nmbPreviousCounter.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbPreviousCounter.Location = new System.Drawing.Point(289, 150);
            this.nmbPreviousCounter.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbPreviousCounter.Name = "nmbPreviousCounter";
            this.nmbPreviousCounter.Size = new System.Drawing.Size(167, 26);
            this.nmbPreviousCounter.TabIndex = 324;
            this.nmbPreviousCounter.W_ColumnName = "";
            this.nmbPreviousCounter.W_OldValue = "";
            this.nmbPreviousCounter.w_Tran = myNumber.Tran.None;
            // 
            // nmbRequiredQty
            // 
            this.nmbRequiredQty.Enabled = false;
            this.nmbRequiredQty.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbRequiredQty.Location = new System.Drawing.Point(289, 180);
            this.nmbRequiredQty.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbRequiredQty.Name = "nmbRequiredQty";
            this.nmbRequiredQty.Size = new System.Drawing.Size(167, 26);
            this.nmbRequiredQty.TabIndex = 325;
            this.nmbRequiredQty.W_ColumnName = "";
            this.nmbRequiredQty.W_OldValue = "";
            this.nmbRequiredQty.w_Tran = myNumber.Tran.None;
            // 
            // txtInvoiceNote
            // 
            this.txtInvoiceNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNote.Location = new System.Drawing.Point(289, 210);
            this.txtInvoiceNote.Name = "txtInvoiceNote";
            this.txtInvoiceNote.Size = new System.Drawing.Size(167, 26);
            this.txtInvoiceNote.TabIndex = 326;
            this.txtInvoiceNote.W_ColumnName = "";
            this.txtInvoiceNote.W_OldValue = "";
            this.txtInvoiceNote.w_Tran = myText.Tran.None;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(289, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 327;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(201, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 328;
            this.label8.Text = "المخزن";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.Location = new System.Drawing.Point(203, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 329;
            this.label9.Text = "العداد الحالي";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.Location = new System.Drawing.Point(205, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 330;
            this.label10.Text = "سعر الوحدة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(203, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 331;
            this.label11.Text = "اسم الصنف";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(201, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 22);
            this.label12.TabIndex = 332;
            this.label12.Text = "اسم العامل";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(203, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 22);
            this.label13.TabIndex = 333;
            this.label13.Text = "سعر البيع";
            // 
            // lstWareHouse
            // 
            this.lstWareHouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstWareHouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWareHouse.Font = new System.Drawing.Font("Arial", 12F);
            this.lstWareHouse.FormattingEnabled = true;
            this.lstWareHouse.Location = new System.Drawing.Point(3, 33);
            this.lstWareHouse.Name = "lstWareHouse";
            this.lstWareHouse.Size = new System.Drawing.Size(195, 26);
            this.lstWareHouse.TabIndex = 334;
            this.lstWareHouse.W_ColumnName = "";
            this.lstWareHouse.W_OldValue = "";
            this.lstWareHouse.w_Tran = myList.Tran.None;
            this.lstWareHouse.w_ValueType = myList.ValueType.TEXT;
            this.lstWareHouse.SelectedIndexChanged += new System.EventHandler(this.lstWareHouse_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemName.Location = new System.Drawing.Point(2, 90);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(196, 26);
            this.txtItemName.TabIndex = 335;
            this.txtItemName.W_ColumnName = "";
            this.txtItemName.W_OldValue = "";
            this.txtItemName.w_Tran = myText.Tran.None;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpName.Location = new System.Drawing.Point(3, 61);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(195, 26);
            this.txtEmpName.TabIndex = 336;
            this.txtEmpName.W_ColumnName = "";
            this.txtEmpName.W_OldValue = "";
            this.txtEmpName.w_Tran = myText.Tran.None;
            // 
            // nmbTotalSellingPrice
            // 
            this.nmbTotalSellingPrice.Enabled = false;
            this.nmbTotalSellingPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbTotalSellingPrice.Location = new System.Drawing.Point(3, 180);
            this.nmbTotalSellingPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbTotalSellingPrice.Name = "nmbTotalSellingPrice";
            this.nmbTotalSellingPrice.Size = new System.Drawing.Size(195, 26);
            this.nmbTotalSellingPrice.TabIndex = 339;
            this.nmbTotalSellingPrice.W_ColumnName = "";
            this.nmbTotalSellingPrice.W_OldValue = "";
            this.nmbTotalSellingPrice.w_Tran = myNumber.Tran.None;
            // 
            // nmbCurrentCounter
            // 
            this.nmbCurrentCounter.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbCurrentCounter.Location = new System.Drawing.Point(3, 150);
            this.nmbCurrentCounter.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbCurrentCounter.Name = "nmbCurrentCounter";
            this.nmbCurrentCounter.Size = new System.Drawing.Size(195, 26);
            this.nmbCurrentCounter.TabIndex = 338;
            this.nmbCurrentCounter.W_ColumnName = "";
            this.nmbCurrentCounter.W_OldValue = "";
            this.nmbCurrentCounter.w_Tran = myNumber.Tran.None;
            this.nmbCurrentCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbCurrentCounter_KeyDown);
            this.nmbCurrentCounter.Leave += new System.EventHandler(this.nmbCurrentCounter_Leave);
            // 
            // nmbUnitSellingPrice
            // 
            this.nmbUnitSellingPrice.Enabled = false;
            this.nmbUnitSellingPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbUnitSellingPrice.Location = new System.Drawing.Point(3, 120);
            this.nmbUnitSellingPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbUnitSellingPrice.Name = "nmbUnitSellingPrice";
            this.nmbUnitSellingPrice.Size = new System.Drawing.Size(195, 26);
            this.nmbUnitSellingPrice.TabIndex = 337;
            this.nmbUnitSellingPrice.W_ColumnName = "";
            this.nmbUnitSellingPrice.W_OldValue = "";
            this.nmbUnitSellingPrice.w_Tran = myNumber.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(351, 31);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(35, 26);
            this.txtPkid.TabIndex = 340;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // txtPumpEmpId
            // 
            this.txtPumpEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPumpEmpId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPumpEmpId.Location = new System.Drawing.Point(365, 61);
            this.txtPumpEmpId.Name = "txtPumpEmpId";
            this.txtPumpEmpId.Size = new System.Drawing.Size(35, 26);
            this.txtPumpEmpId.TabIndex = 341;
            this.txtPumpEmpId.Visible = false;
            this.txtPumpEmpId.W_ColumnName = "";
            this.txtPumpEmpId.W_OldValue = "";
            this.txtPumpEmpId.w_Tran = myText.Tran.None;
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpId.Location = new System.Drawing.Point(109, 61);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(35, 26);
            this.txtEmpId.TabIndex = 342;
            this.txtEmpId.Visible = false;
            this.txtEmpId.W_ColumnName = "";
            this.txtEmpId.W_OldValue = "";
            this.txtEmpId.w_Tran = myText.Tran.None;
            // 
            // txtEmpAccId
            // 
            this.txtEmpAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpAccId.Location = new System.Drawing.Point(59, 61);
            this.txtEmpAccId.Name = "txtEmpAccId";
            this.txtEmpAccId.Size = new System.Drawing.Size(35, 26);
            this.txtEmpAccId.TabIndex = 343;
            this.txtEmpAccId.Visible = false;
            this.txtEmpAccId.W_ColumnName = "";
            this.txtEmpAccId.W_OldValue = "";
            this.txtEmpAccId.w_Tran = myText.Tran.None;
            // 
            // txtCostGoodSoldAccId
            // 
            this.txtCostGoodSoldAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostGoodSoldAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCostGoodSoldAccId.Location = new System.Drawing.Point(47, 242);
            this.txtCostGoodSoldAccId.Name = "txtCostGoodSoldAccId";
            this.txtCostGoodSoldAccId.Size = new System.Drawing.Size(11, 26);
            this.txtCostGoodSoldAccId.TabIndex = 344;
            this.txtCostGoodSoldAccId.Visible = false;
            this.txtCostGoodSoldAccId.W_ColumnName = "";
            this.txtCostGoodSoldAccId.W_OldValue = "";
            this.txtCostGoodSoldAccId.w_Tran = myText.Tran.None;
            // 
            // txtInventoryAccId
            // 
            this.txtInventoryAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInventoryAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInventoryAccId.Location = new System.Drawing.Point(30, 242);
            this.txtInventoryAccId.Name = "txtInventoryAccId";
            this.txtInventoryAccId.Size = new System.Drawing.Size(11, 26);
            this.txtInventoryAccId.TabIndex = 345;
            this.txtInventoryAccId.Visible = false;
            this.txtInventoryAccId.W_ColumnName = "";
            this.txtInventoryAccId.W_OldValue = "";
            this.txtInventoryAccId.w_Tran = myText.Tran.None;
            // 
            // txtSalesAccId
            // 
            this.txtSalesAccId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesAccId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSalesAccId.Location = new System.Drawing.Point(8, 242);
            this.txtSalesAccId.Name = "txtSalesAccId";
            this.txtSalesAccId.Size = new System.Drawing.Size(16, 26);
            this.txtSalesAccId.TabIndex = 346;
            this.txtSalesAccId.Visible = false;
            this.txtSalesAccId.W_ColumnName = "";
            this.txtSalesAccId.W_OldValue = "";
            this.txtSalesAccId.w_Tran = myText.Tran.None;
            // 
            // txtItemPkid
            // 
            this.txtItemPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemPkid.Location = new System.Drawing.Point(413, 90);
            this.txtItemPkid.Name = "txtItemPkid";
            this.txtItemPkid.Size = new System.Drawing.Size(24, 26);
            this.txtItemPkid.TabIndex = 347;
            this.txtItemPkid.Visible = false;
            this.txtItemPkid.W_ColumnName = "";
            this.txtItemPkid.W_OldValue = "";
            this.txtItemPkid.w_Tran = myText.Tran.None;
            // 
            // nmbUnitCost
            // 
            this.nmbUnitCost.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbUnitCost.Location = new System.Drawing.Point(477, 256);
            this.nmbUnitCost.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbUnitCost.Name = "nmbUnitCost";
            this.nmbUnitCost.Size = new System.Drawing.Size(53, 26);
            this.nmbUnitCost.TabIndex = 348;
            this.nmbUnitCost.Visible = false;
            this.nmbUnitCost.W_ColumnName = "";
            this.nmbUnitCost.W_OldValue = "";
            this.nmbUnitCost.w_Tran = myNumber.Tran.None;
            // 
            // dtpJourDate
            // 
            this.dtpJourDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpJourDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourDate.Location = new System.Drawing.Point(3, 210);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(195, 26);
            this.dtpJourDate.TabIndex = 350;
            this.dtpJourDate.W_ColumnName = "";
            this.dtpJourDate.W_OldValue = "";
            this.dtpJourDate.w_Tran = myDate.Tran.None;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F);
            this.label14.Location = new System.Drawing.Point(205, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 349;
            this.label14.Text = "التاريخ";
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 290);
            this.Controls.Add(this.dtpJourDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nmbUnitCost);
            this.Controls.Add(this.txtItemPkid);
            this.Controls.Add(this.txtSalesAccId);
            this.Controls.Add(this.txtInventoryAccId);
            this.Controls.Add(this.txtCostGoodSoldAccId);
            this.Controls.Add(this.txtEmpAccId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtPumpEmpId);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.nmbTotalSellingPrice);
            this.Controls.Add(this.nmbCurrentCounter);
            this.Controls.Add(this.nmbUnitSellingPrice);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lstWareHouse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtInvoiceNote);
            this.Controls.Add(this.nmbRequiredQty);
            this.Controls.Add(this.nmbPreviousCounter);
            this.Controls.Add(this.nmbOnhandQty);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.lstPumps);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Name = "frmInvoices";
            this.Tag = "frmInvoices";
            this.Text = "فاتورة المبيعات";
            this.Titel = "فاتورة المبيعات";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNo, 0);
            this.Controls.SetChildIndex(this.lstPumps, 0);
            this.Controls.SetChildIndex(this.txtItemNo, 0);
            this.Controls.SetChildIndex(this.nmbOnhandQty, 0);
            this.Controls.SetChildIndex(this.nmbPreviousCounter, 0);
            this.Controls.SetChildIndex(this.nmbRequiredQty, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNote, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.lstWareHouse, 0);
            this.Controls.SetChildIndex(this.txtItemName, 0);
            this.Controls.SetChildIndex(this.txtEmpName, 0);
            this.Controls.SetChildIndex(this.nmbUnitSellingPrice, 0);
            this.Controls.SetChildIndex(this.nmbCurrentCounter, 0);
            this.Controls.SetChildIndex(this.nmbTotalSellingPrice, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.txtPumpEmpId, 0);
            this.Controls.SetChildIndex(this.txtEmpId, 0);
            this.Controls.SetChildIndex(this.txtEmpAccId, 0);
            this.Controls.SetChildIndex(this.txtCostGoodSoldAccId, 0);
            this.Controls.SetChildIndex(this.txtInventoryAccId, 0);
            this.Controls.SetChildIndex(this.txtSalesAccId, 0);
            this.Controls.SetChildIndex(this.txtItemPkid, 0);
            this.Controls.SetChildIndex(this.nmbUnitCost, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.dtpJourDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbOnhandQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPreviousCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRequiredQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotalSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCurrentCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainButton btnPrint;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private myText txtInvoiceNo;
        private myList lstPumps;
        private myText txtItemNo;
        private myNumber nmbOnhandQty;
        private myNumber nmbPreviousCounter;
        private myNumber nmbRequiredQty;
        private myText txtInvoiceNote;
        private SmallButton btnFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private myList lstWareHouse;
        private myText txtItemName;
        private myText txtEmpName;
        private myNumber nmbTotalSellingPrice;
        private myNumber nmbCurrentCounter;
        private myNumber nmbUnitSellingPrice;
        private myText txtPkid;
        private myText txtPumpEmpId;
        private myText txtEmpId;
        private myText txtEmpAccId;
        private myText txtCostGoodSoldAccId;
        private myText txtInventoryAccId;
        private myText txtSalesAccId;
        private myText txtItemPkid;
        private myNumber nmbUnitCost;
        private myDate dtpJourDate;
        private System.Windows.Forms.Label label14;
    }
}
