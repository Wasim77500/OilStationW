namespace OilStationW.Inventory
{
    partial class frmStackAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStackAdjustment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockAdjNo = new myText();
            this.btnFind = new SmallButton();
            this.lstWarehouses = new myList();
            this.lstAccNo = new myList();
            this.lstAccName = new myList();
            this.txtStockAdjNote = new myText();
            this.myGroupBox1 = new myGroupBox();
            this.txtItemId = new myText();
            this.btnAdd = new SmallButton();
            this.btnFindItem = new SmallButton();
            this.nmbUnitCost = new myNumber();
            this.nmbQty = new myNumber();
            this.nmbQtyOnHand = new myNumber();
            this.txtItemName = new myText();
            this.txtItemNo = new myText();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStockAdjustment = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtyOnhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequiredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOldUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrint = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.label10 = new System.Windows.Forms.Label();
            this.nmbTotal = new myNumber();
            this.txtPkid = new myText();
            this.txtAccNo = new myText();
            this.nmbOldUnitCost = new myNumber();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpJourDate = new myDate();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQtyOnHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOldUnitCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(616, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "رقم الامر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(342, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "المخزن";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(605, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "مـلاحـظـات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(621, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "الحساب";
            // 
            // txtStockAdjNo
            // 
            this.txtStockAdjNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockAdjNo.Enabled = false;
            this.txtStockAdjNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtStockAdjNo.Location = new System.Drawing.Point(431, 32);
            this.txtStockAdjNo.Name = "txtStockAdjNo";
            this.txtStockAdjNo.Size = new System.Drawing.Size(166, 26);
            this.txtStockAdjNo.TabIndex = 49;
            this.txtStockAdjNo.W_ColumnName = "";
            this.txtStockAdjNo.W_OldValue = "";
            this.txtStockAdjNo.w_Tran = myText.Tran.None;
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
            this.btnFind.Location = new System.Drawing.Point(402, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 50;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstWarehouses
            // 
            this.lstWarehouses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstWarehouses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWarehouses.Font = new System.Drawing.Font("Arial", 12F);
            this.lstWarehouses.FormattingEnabled = true;
            this.lstWarehouses.Location = new System.Drawing.Point(99, 32);
            this.lstWarehouses.Name = "lstWarehouses";
            this.lstWarehouses.Size = new System.Drawing.Size(238, 26);
            this.lstWarehouses.TabIndex = 51;
            this.lstWarehouses.W_ColumnName = "";
            this.lstWarehouses.W_OldValue = "";
            this.lstWarehouses.w_Tran = myList.Tran.None;
            this.lstWarehouses.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(431, 62);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(166, 26);
            this.lstAccNo.TabIndex = 52;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(99, 62);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(330, 26);
            this.lstAccName.TabIndex = 53;
            this.lstAccName.W_ColumnName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.w_Tran = myList.Tran.None;
            this.lstAccName.w_ValueType = myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtStockAdjNote
            // 
            this.txtStockAdjNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockAdjNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtStockAdjNote.Location = new System.Drawing.Point(302, 92);
            this.txtStockAdjNote.Name = "txtStockAdjNote";
            this.txtStockAdjNote.Size = new System.Drawing.Size(295, 26);
            this.txtStockAdjNote.TabIndex = 54;
            this.txtStockAdjNote.W_ColumnName = "";
            this.txtStockAdjNote.W_OldValue = "";
            this.txtStockAdjNote.w_Tran = myText.Tran.None;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtItemId);
            this.myGroupBox1.Controls.Add(this.btnAdd);
            this.myGroupBox1.Controls.Add(this.btnFindItem);
            this.myGroupBox1.Controls.Add(this.nmbUnitCost);
            this.myGroupBox1.Controls.Add(this.nmbQty);
            this.myGroupBox1.Controls.Add(this.nmbQtyOnHand);
            this.myGroupBox1.Controls.Add(this.txtItemName);
            this.myGroupBox1.Controls.Add(this.txtItemNo);
            this.myGroupBox1.Controls.Add(this.label9);
            this.myGroupBox1.Controls.Add(this.label8);
            this.myGroupBox1.Controls.Add(this.label7);
            this.myGroupBox1.Controls.Add(this.label6);
            this.myGroupBox1.Controls.Add(this.label5);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(99, 124);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(587, 112);
            this.myGroupBox1.TabIndex = 65;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات الصنف";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            // 
            // txtItemId
            // 
            this.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemId.Location = new System.Drawing.Point(384, 21);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(47, 26);
            this.txtItemId.TabIndex = 79;
            this.txtItemId.Visible = false;
            this.txtItemId.W_ColumnName = "";
            this.txtItemId.W_OldValue = "";
            this.txtItemId.w_Tran = myText.Tran.None;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::OilStationW.Properties.Resources.Add_h;
            this.btnAdd.Location = new System.Drawing.Point(315, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFindItem
            // 
            this.btnFindItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFindItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFindItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFindItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindItem.Image = ((System.Drawing.Image)(resources.GetObject("btnFindItem.Image")));
            this.btnFindItem.Location = new System.Drawing.Point(315, 21);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(26, 26);
            this.btnFindItem.TabIndex = 56;
            this.btnFindItem.UseVisualStyleBackColor = false;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // nmbUnitCost
            // 
            this.nmbUnitCost.DecimalPlaces = 7;
            this.nmbUnitCost.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbUnitCost.Location = new System.Drawing.Point(342, 81);
            this.nmbUnitCost.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbUnitCost.Name = "nmbUnitCost";
            this.nmbUnitCost.Size = new System.Drawing.Size(139, 26);
            this.nmbUnitCost.TabIndex = 55;
            this.nmbUnitCost.W_ColumnName = "";
            this.nmbUnitCost.W_OldValue = "";
            this.nmbUnitCost.w_Tran = myNumber.Tran.None;
            // 
            // nmbQty
            // 
            this.nmbQty.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbQty.Location = new System.Drawing.Point(32, 51);
            this.nmbQty.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbQty.Name = "nmbQty";
            this.nmbQty.Size = new System.Drawing.Size(166, 26);
            this.nmbQty.TabIndex = 54;
            this.nmbQty.W_ColumnName = "";
            this.nmbQty.W_OldValue = "";
            this.nmbQty.w_Tran = myNumber.Tran.None;
            // 
            // nmbQtyOnHand
            // 
            this.nmbQtyOnHand.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbQtyOnHand.Location = new System.Drawing.Point(315, 51);
            this.nmbQtyOnHand.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbQtyOnHand.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.nmbQtyOnHand.Name = "nmbQtyOnHand";
            this.nmbQtyOnHand.Size = new System.Drawing.Size(166, 26);
            this.nmbQtyOnHand.TabIndex = 53;
            this.nmbQtyOnHand.W_ColumnName = "";
            this.nmbQtyOnHand.W_OldValue = "";
            this.nmbQtyOnHand.w_Tran = myNumber.Tran.None;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemName.Location = new System.Drawing.Point(32, 22);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(166, 26);
            this.txtItemName.TabIndex = 52;
            this.txtItemName.W_ColumnName = "";
            this.txtItemName.W_OldValue = "";
            this.txtItemName.w_Tran = myText.Tran.None;
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemNo.Location = new System.Drawing.Point(342, 21);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(139, 26);
            this.txtItemNo.TabIndex = 51;
            this.txtItemNo.W_ColumnName = "";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.w_Tran = myText.Tran.None;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(213, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "كمية التعديل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(488, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 49;
            this.label8.Text = "كمية المخزون";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(499, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "سعر التكلفة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(215, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "اسم الصنف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(498, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "رقم الصنف";
            // 
            // dgvStockAdjustment
            // 
            this.dgvStockAdjustment.AllowUserToAddRows = false;
            this.dgvStockAdjustment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvStockAdjustment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockAdjustment.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockAdjustment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockAdjustment.ColumnHeadersHeight = 30;
            this.dgvStockAdjustment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmItemId,
            this.clmItemNo,
            this.clmItemName,
            this.clmQtyOnhand,
            this.clmRequiredQty,
            this.clmUnitCost,
            this.clmTotalCost,
            this.clmOldUnitCost,
            this.clmDelete});
            this.dgvStockAdjustment.EnableHeadersVisualStyles = false;
            this.dgvStockAdjustment.Location = new System.Drawing.Point(8, 242);
            this.dgvStockAdjustment.Name = "dgvStockAdjustment";
            this.dgvStockAdjustment.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvStockAdjustment.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockAdjustment.Size = new System.Drawing.Size(783, 247);
            this.dgvStockAdjustment.TabIndex = 72;
            this.dgvStockAdjustment.W_ClmName = "";
            this.dgvStockAdjustment.W_PK = "";
            this.dgvStockAdjustment.W_TableName = "";
            this.dgvStockAdjustment.W_updValName = "";
            this.dgvStockAdjustment.W_ValName = "";
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmItemId
            // 
            this.clmItemId.HeaderText = "رقم الصنف";
            this.clmItemId.Name = "clmItemId";
            this.clmItemId.ReadOnly = true;
            this.clmItemId.Visible = false;
            // 
            // clmItemNo
            // 
            this.clmItemNo.FillWeight = 50F;
            this.clmItemNo.HeaderText = "رقم الصنف";
            this.clmItemNo.Name = "clmItemNo";
            this.clmItemNo.ReadOnly = true;
            // 
            // clmItemName
            // 
            this.clmItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmItemName.HeaderText = "اسم الصنف";
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            // 
            // clmQtyOnhand
            // 
            this.clmQtyOnhand.HeaderText = "المخزون";
            this.clmQtyOnhand.Name = "clmQtyOnhand";
            this.clmQtyOnhand.ReadOnly = true;
            // 
            // clmRequiredQty
            // 
            this.clmRequiredQty.HeaderText = "الكمية";
            this.clmRequiredQty.Name = "clmRequiredQty";
            this.clmRequiredQty.ReadOnly = true;
            // 
            // clmUnitCost
            // 
            this.clmUnitCost.HeaderText = "سعر الوحدة";
            this.clmUnitCost.Name = "clmUnitCost";
            this.clmUnitCost.ReadOnly = true;
            // 
            // clmTotalCost
            // 
            this.clmTotalCost.HeaderText = "الأجمالي";
            this.clmTotalCost.Name = "clmTotalCost";
            this.clmTotalCost.ReadOnly = true;
            // 
            // clmOldUnitCost
            // 
            this.clmOldUnitCost.HeaderText = "تكلفة الوحدة القديمة";
            this.clmOldUnitCost.Name = "clmOldUnitCost";
            this.clmOldUnitCost.ReadOnly = true;
            this.clmOldUnitCost.Visible = false;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::OilStationW.Properties.Resources.Delete16;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
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
            this.btnPrint.Location = new System.Drawing.Point(531, 493);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 76;
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
            this.btnClose.Location = new System.Drawing.Point(455, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 75;
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
            this.btnSave.Location = new System.Drawing.Point(607, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 74;
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
            this.btnNew.Location = new System.Drawing.Point(683, 493);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 73;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(230, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 58;
            this.label10.Text = "الأجمالي";
            // 
            // nmbTotal
            // 
            this.nmbTotal.Enabled = false;
            this.nmbTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbTotal.Location = new System.Drawing.Point(8, 493);
            this.nmbTotal.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbTotal.Name = "nmbTotal";
            this.nmbTotal.Size = new System.Drawing.Size(166, 26);
            this.nmbTotal.TabIndex = 58;
            this.nmbTotal.W_ColumnName = "";
            this.nmbTotal.W_OldValue = "";
            this.nmbTotal.w_Tran = myNumber.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(473, 32);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(47, 26);
            this.txtPkid.TabIndex = 77;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(31, 89);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(47, 26);
            this.txtAccNo.TabIndex = 78;
            this.txtAccNo.Visible = false;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // nmbOldUnitCost
            // 
            this.nmbOldUnitCost.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbOldUnitCost.Location = new System.Drawing.Point(12, 143);
            this.nmbOldUnitCost.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbOldUnitCost.Name = "nmbOldUnitCost";
            this.nmbOldUnitCost.Size = new System.Drawing.Size(66, 26);
            this.nmbOldUnitCost.TabIndex = 80;
            this.nmbOldUnitCost.Visible = false;
            this.nmbOldUnitCost.W_ColumnName = "";
            this.nmbOldUnitCost.W_OldValue = "";
            this.nmbOldUnitCost.w_Tran = myNumber.Tran.None;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(247, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 22);
            this.label11.TabIndex = 81;
            this.label11.Text = "التاريخ";
            // 
            // dtpJourDate
            // 
            this.dtpJourDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpJourDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourDate.Location = new System.Drawing.Point(99, 92);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(145, 26);
            this.dtpJourDate.TabIndex = 82;
            this.dtpJourDate.W_ColumnName = "";
            this.dtpJourDate.W_OldValue = "";
            this.dtpJourDate.w_Tran = myDate.Tran.None;
            // 
            // frmStackAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(799, 536);
            this.Controls.Add(this.dtpJourDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nmbOldUnitCost);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.nmbTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvStockAdjustment);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.txtStockAdjNote);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.lstWarehouses);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtStockAdjNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStackAdjustment";
            this.Tag = "frmStockAdjustmentIn";
            this.Text = "التعديل المخزني";
            this.Titel = "التعديل المخزني";
            this.Load += new System.EventHandler(this.frmStackAdjustment_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtStockAdjNo, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lstWarehouses, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtStockAdjNote, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgvStockAdjustment, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.nmbTotal, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.nmbOldUnitCost, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.dtpJourDate, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQtyOnHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOldUnitCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private myText txtStockAdjNo;
        private SmallButton btnFind;
        private myList lstWarehouses;
        private myList lstAccNo;
        private myList lstAccName;
        private myText txtStockAdjNote;
        private myGroupBox myGroupBox1;
        private myNumber nmbQty;
        private myNumber nmbQtyOnHand;
        private myText txtItemName;
        private myText txtItemNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private SmallButton btnAdd;
        private SmallButton btnFindItem;
        private myDataGrid dgvStockAdjustment;
        private MainButton btnPrint;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private System.Windows.Forms.Label label10;
        private myNumber nmbTotal;
        private myText txtPkid;
        private myText txtAccNo;
        private myText txtItemId;
        private myNumber nmbOldUnitCost;
        public myNumber nmbUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtyOnhand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequiredQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOldUnitCost;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.Label label11;
        private myDate dtpJourDate;
    }
}
