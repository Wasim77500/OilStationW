namespace OilStationW.Purchases
{
    partial class frmPurchaseInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new myText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceNote = new myText();
            this.btnInsertDoc = new MainButton();
            this.btnGetExpensses = new MainButton();
            this.lstWarehouse = new myList();
            this.btnFind = new SmallButton();
            this.txtAccNo = new myText();
            this.txtPkid = new myText();
            this.dgvItems = new myDataGrid();
            this.clmItemPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOldUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtyOnhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExpensses = new myDataGrid();
            this.clmExpPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.nmbItemTotal = new myNumber();
            this.nmbExpTotal = new myNumber();
            this.nmbEditor = new myNumber();
            this.nmbEditorExp = new myNumber();
            this.dtpJourDate = new myDate();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbItemTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditorExp)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(196, 59);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(296, 26);
            this.lstAccName.TabIndex = 63;
            this.lstAccName.W_ColumnName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.w_Tran = myList.Tran.None;
            this.lstAccName.w_ValueType = myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(494, 59);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(166, 26);
            this.lstAccNo.TabIndex = 62;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(671, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(670, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "رقم الفاتورة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(400, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 65;
            this.label3.Text = "المخزن";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(494, 30);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(166, 26);
            this.txtInvoiceNo.TabIndex = 66;
            this.txtInvoiceNo.W_ColumnName = "";
            this.txtInvoiceNo.W_OldValue = "";
            this.txtInvoiceNo.w_Tran = myText.Tran.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(679, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "البيان";
            // 
            // txtInvoiceNote
            // 
            this.txtInvoiceNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInvoiceNote.Location = new System.Drawing.Point(376, 88);
            this.txtInvoiceNote.Name = "txtInvoiceNote";
            this.txtInvoiceNote.Size = new System.Drawing.Size(284, 26);
            this.txtInvoiceNote.TabIndex = 68;
            this.txtInvoiceNote.W_ColumnName = "";
            this.txtInvoiceNote.W_OldValue = "";
            this.txtInvoiceNote.w_Tran = myText.Tran.None;
            // 
            // btnInsertDoc
            // 
            this.btnInsertDoc.BackColor = System.Drawing.Color.Black;
            this.btnInsertDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertDoc.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnInsertDoc.FlatAppearance.BorderSize = 2;
            this.btnInsertDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnInsertDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnInsertDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertDoc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnInsertDoc.ForeColor = System.Drawing.Color.Chocolate;
            this.btnInsertDoc.Location = new System.Drawing.Point(3, 36);
            this.btnInsertDoc.Name = "btnInsertDoc";
            this.btnInsertDoc.Size = new System.Drawing.Size(107, 35);
            this.btnInsertDoc.TabIndex = 69;
            this.btnInsertDoc.Text = "إدخال الوثائق";
            this.btnInsertDoc.UseVisualStyleBackColor = false;
            this.btnInsertDoc.Click += new System.EventHandler(this.btnInsertDoc_Click);
            // 
            // btnGetExpensses
            // 
            this.btnGetExpensses.BackColor = System.Drawing.Color.Black;
            this.btnGetExpensses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExpensses.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnGetExpensses.FlatAppearance.BorderSize = 2;
            this.btnGetExpensses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnGetExpensses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnGetExpensses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExpensses.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnGetExpensses.ForeColor = System.Drawing.Color.Chocolate;
            this.btnGetExpensses.Location = new System.Drawing.Point(3, 80);
            this.btnGetExpensses.Name = "btnGetExpensses";
            this.btnGetExpensses.Size = new System.Drawing.Size(150, 35);
            this.btnGetExpensses.TabIndex = 70;
            this.btnGetExpensses.Text = "استحضار المصاريف";
            this.btnGetExpensses.UseVisualStyleBackColor = false;
            this.btnGetExpensses.Click += new System.EventHandler(this.btnGetExpensses_Click);
            // 
            // lstWarehouse
            // 
            this.lstWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWarehouse.Font = new System.Drawing.Font("Arial", 12F);
            this.lstWarehouse.FormattingEnabled = true;
            this.lstWarehouse.Location = new System.Drawing.Point(196, 30);
            this.lstWarehouse.Name = "lstWarehouse";
            this.lstWarehouse.Size = new System.Drawing.Size(198, 26);
            this.lstWarehouse.TabIndex = 71;
            this.lstWarehouse.W_ColumnName = "";
            this.lstWarehouse.W_OldValue = "";
            this.lstWarehouse.w_Tran = myList.Tran.None;
            this.lstWarehouse.w_ValueType = myList.ValueType.TEXT;
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
            this.btnFind.Location = new System.Drawing.Point(466, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 72;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(466, 88);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(56, 26);
            this.txtAccNo.TabIndex = 73;
            this.txtAccNo.Visible = false;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(554, 30);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(56, 26);
            this.txtPkid.TabIndex = 74;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 30;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemPKid,
            this.clmItemId,
            this.clmItemNo,
            this.clmItemName,
            this.clmOldUnitCost,
            this.clmItemQty,
            this.clmItemPrice,
            this.clmItemCost,
            this.clmQtyOnhand});
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(421, 120);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.Size = new System.Drawing.Size(327, 315);
            this.dgvItems.TabIndex = 302;
            this.dgvItems.W_ClmName = "";
            this.dgvItems.W_PK = "";
            this.dgvItems.W_TableName = "";
            this.dgvItems.W_updValName = "";
            this.dgvItems.W_ValName = "";
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            // 
            // clmItemPKid
            // 
            this.clmItemPKid.HeaderText = "رقم التصنيف";
            this.clmItemPKid.Name = "clmItemPKid";
            this.clmItemPKid.ReadOnly = true;
            this.clmItemPKid.Visible = false;
            // 
            // clmItemId
            // 
            this.clmItemId.HeaderText = "رقم تعريف  الصنف";
            this.clmItemId.Name = "clmItemId";
            this.clmItemId.ReadOnly = true;
            this.clmItemId.Visible = false;
            // 
            // clmItemNo
            // 
            this.clmItemNo.HeaderText = "رقم الصنف";
            this.clmItemNo.Name = "clmItemNo";
            this.clmItemNo.ReadOnly = true;
            this.clmItemNo.Width = 80;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "اسم الصنف";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            // 
            // clmOldUnitCost
            // 
            this.clmOldUnitCost.HeaderText = "تكلفة الوحدة السابق او الحالي";
            this.clmOldUnitCost.Name = "clmOldUnitCost";
            this.clmOldUnitCost.ReadOnly = true;
            this.clmOldUnitCost.Visible = false;
            // 
            // clmItemQty
            // 
            this.clmItemQty.HeaderText = "الكمية";
            this.clmItemQty.Name = "clmItemQty";
            this.clmItemQty.ReadOnly = true;
            this.clmItemQty.Width = 70;
            // 
            // clmItemPrice
            // 
            this.clmItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmItemPrice.HeaderText = "السعر";
            this.clmItemPrice.Name = "clmItemPrice";
            this.clmItemPrice.ReadOnly = true;
            // 
            // clmItemCost
            // 
            this.clmItemCost.HeaderText = "تكلفة الوحدة";
            this.clmItemCost.Name = "clmItemCost";
            this.clmItemCost.ReadOnly = true;
            this.clmItemCost.Visible = false;
            // 
            // clmQtyOnhand
            // 
            this.clmQtyOnhand.HeaderText = "الكمية الحالية في المخزن";
            this.clmQtyOnhand.Name = "clmQtyOnhand";
            this.clmQtyOnhand.ReadOnly = true;
            this.clmQtyOnhand.Visible = false;
            // 
            // dgvExpensses
            // 
            this.dgvExpensses.AllowUserToAddRows = false;
            this.dgvExpensses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvExpensses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpensses.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpensses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpensses.ColumnHeadersHeight = 30;
            this.dgvExpensses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExpPKid,
            this.clmAccId,
            this.clmAccNo,
            this.clmAccName,
            this.clmExpName,
            this.clmExpValue});
            this.dgvExpensses.EnableHeadersVisualStyles = false;
            this.dgvExpensses.Location = new System.Drawing.Point(3, 120);
            this.dgvExpensses.Name = "dgvExpensses";
            this.dgvExpensses.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvExpensses.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExpensses.Size = new System.Drawing.Size(412, 315);
            this.dgvExpensses.TabIndex = 303;
            this.dgvExpensses.W_ClmName = "";
            this.dgvExpensses.W_PK = "";
            this.dgvExpensses.W_TableName = "";
            this.dgvExpensses.W_updValName = "";
            this.dgvExpensses.W_ValName = "";
            this.dgvExpensses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpensses_CellClick);
            this.dgvExpensses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpensses_CellDoubleClick);
            this.dgvExpensses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvExpensses_KeyDown);
            // 
            // clmExpPKid
            // 
            this.clmExpPKid.HeaderText = "رقم التصنيف";
            this.clmExpPKid.Name = "clmExpPKid";
            this.clmExpPKid.Visible = false;
            // 
            // clmAccId
            // 
            this.clmAccId.HeaderText = "رقم تعريف  الحساب";
            this.clmAccId.Name = "clmAccId";
            this.clmAccId.ReadOnly = true;
            this.clmAccId.Visible = false;
            // 
            // clmAccNo
            // 
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            this.clmAccNo.Width = 80;
            // 
            // clmAccName
            // 
            this.clmAccName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAccName.HeaderText = "اسم الحساب";
            this.clmAccName.Name = "clmAccName";
            this.clmAccName.ReadOnly = true;
            // 
            // clmExpName
            // 
            this.clmExpName.HeaderText = "اسم المصروف";
            this.clmExpName.Name = "clmExpName";
            // 
            // clmExpValue
            // 
            this.clmExpValue.HeaderText = "المبلغ";
            this.clmExpValue.Name = "clmExpValue";
            this.clmExpValue.ReadOnly = true;
            this.clmExpValue.Width = 90;
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
            this.btnPrint.Location = new System.Drawing.Point(272, 467);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 308;
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
            this.btnClose.Location = new System.Drawing.Point(196, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 306;
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
            this.btnSave.Location = new System.Drawing.Point(348, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 305;
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
            this.btnNew.Location = new System.Drawing.Point(424, 467);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 304;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // nmbItemTotal
            // 
            this.nmbItemTotal.Enabled = false;
            this.nmbItemTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbItemTotal.Location = new System.Drawing.Point(421, 437);
            this.nmbItemTotal.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbItemTotal.Name = "nmbItemTotal";
            this.nmbItemTotal.Size = new System.Drawing.Size(118, 23);
            this.nmbItemTotal.TabIndex = 309;
            this.nmbItemTotal.W_ColumnName = "";
            this.nmbItemTotal.W_OldValue = "";
            this.nmbItemTotal.w_Tran = myNumber.Tran.None;
            // 
            // nmbExpTotal
            // 
            this.nmbExpTotal.Enabled = false;
            this.nmbExpTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbExpTotal.Location = new System.Drawing.Point(3, 437);
            this.nmbExpTotal.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbExpTotal.Name = "nmbExpTotal";
            this.nmbExpTotal.Size = new System.Drawing.Size(118, 23);
            this.nmbExpTotal.TabIndex = 310;
            this.nmbExpTotal.W_ColumnName = "";
            this.nmbExpTotal.W_OldValue = "";
            this.nmbExpTotal.w_Tran = myNumber.Tran.None;
            // 
            // nmbEditor
            // 
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(642, 177);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 23);
            this.nmbEditor.TabIndex = 311;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // nmbEditorExp
            // 
            this.nmbEditorExp.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditorExp.Location = new System.Drawing.Point(186, 213);
            this.nmbEditorExp.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditorExp.Name = "nmbEditorExp";
            this.nmbEditorExp.Size = new System.Drawing.Size(100, 23);
            this.nmbEditorExp.TabIndex = 312;
            this.nmbEditorExp.Visible = false;
            this.nmbEditorExp.W_ColumnName = "";
            this.nmbEditorExp.W_OldValue = "";
            this.nmbEditorExp.w_Tran = myNumber.Tran.None;
            this.nmbEditorExp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditorExp_KeyDown);
            this.nmbEditorExp.Leave += new System.EventHandler(this.nmbEditorExp_Leave);
            // 
            // dtpJourDate
            // 
            this.dtpJourDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpJourDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourDate.Location = new System.Drawing.Point(196, 88);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(118, 26);
            this.dtpJourDate.TabIndex = 314;
            this.dtpJourDate.W_ColumnName = "";
            this.dtpJourDate.W_OldValue = "";
            this.dtpJourDate.w_Tran = myDate.Tran.None;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(319, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 22);
            this.label11.TabIndex = 313;
            this.label11.Text = "التاريخ";
            // 
            // frmPurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.dtpJourDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nmbEditorExp);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.nmbExpTotal);
            this.Controls.Add(this.nmbItemTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvExpensses);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lstWarehouse);
            this.Controls.Add(this.btnGetExpensses);
            this.Controls.Add(this.btnInsertDoc);
            this.Controls.Add(this.txtInvoiceNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseInvoice";
            this.Tag = "frmPurchaseInvoice";
            this.Text = "فاتورة الشراء";
            this.Titel = "فاتورة الشراء";
            this.Load += new System.EventHandler(this.frmPurchaseInvoice_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtInvoiceNote, 0);
            this.Controls.SetChildIndex(this.btnInsertDoc, 0);
            this.Controls.SetChildIndex(this.btnGetExpensses, 0);
            this.Controls.SetChildIndex(this.lstWarehouse, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.dgvItems, 0);
            this.Controls.SetChildIndex(this.dgvExpensses, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.nmbItemTotal, 0);
            this.Controls.SetChildIndex(this.nmbExpTotal, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.nmbEditorExp, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.dtpJourDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbItemTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditorExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myList lstAccName;
        private myList lstAccNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private myText txtInvoiceNo;
        private System.Windows.Forms.Label label4;
        private myText txtInvoiceNote;
        private MainButton btnInsertDoc;
        private MainButton btnGetExpensses;
        private myList lstWarehouse;
        private SmallButton btnFind;
        private myText txtAccNo;
        private myText txtPkid;
        private myDataGrid dgvItems;
        private myDataGrid dgvExpensses;
        private MainButton btnPrint;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOldUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtyOnhand;
        private myNumber nmbItemTotal;
        private myNumber nmbExpTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpValue;
        private myNumber nmbEditor;
        private myNumber nmbEditorExp;
        private myDate dtpJourDate;
        private System.Windows.Forms.Label label11;
    }
}
