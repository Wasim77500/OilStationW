namespace OilStationW.Accounts
{
    partial class frmBeginingEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myGroupBox1 = new myGroupBox();
            this.txtHeaderNote = new myText();
            this.dtpJourDate = new myDate();
            this.btnFind = new SmallButton();
            this.txtPkid = new myText();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJourNo = new myText();
            this.dgvJourDetails = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfitCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJourNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnNew = new MainButton();
            this.btnPrint = new MainButton();
            this.txtDeptTotal = new myText();
            this.txtCreditTotal = new myText();
            this.txtDiff = new myText();
            this.txtBranchId = new myText();
            this.nmbExchangeRate = new myNumber();
            this.nmbEditor = new myNumber();
            this.btnSave = new MainButton();
            this.btnClosingEntry = new MainButton();
            this.btnGetBegningEntry = new MainButton();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExchangeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtHeaderNote);
            this.myGroupBox1.Controls.Add(this.dtpJourDate);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Controls.Add(this.txtPkid);
            this.myGroupBox1.Controls.Add(this.label2);
            this.myGroupBox1.Controls.Add(this.label1);
            this.myGroupBox1.Controls.Add(this.label7);
            this.myGroupBox1.Controls.Add(this.txtJourNo);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(119, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(552, 85);
            this.myGroupBox1.TabIndex = 62;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات القيد الرئيسية";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            // 
            // txtHeaderNote
            // 
            this.txtHeaderNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeaderNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHeaderNote.Location = new System.Drawing.Point(6, 52);
            this.txtHeaderNote.Name = "txtHeaderNote";
            this.txtHeaderNote.Size = new System.Drawing.Size(474, 26);
            this.txtHeaderNote.TabIndex = 62;
            this.txtHeaderNote.W_ColumnName = "";
            this.txtHeaderNote.W_OldValue = "";
            this.txtHeaderNote.w_Tran = myText.Tran.None;
            // 
            // dtpJourDate
            // 
            this.dtpJourDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpJourDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourDate.Location = new System.Drawing.Point(6, 22);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(163, 26);
            this.dtpJourDate.TabIndex = 61;
            this.dtpJourDate.W_ColumnName = "";
            this.dtpJourDate.W_OldValue = "";
            this.dtpJourDate.w_Tran = myDate.Tran.None;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::OilStationW.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(257, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 60;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(358, 22);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(58, 26);
            this.txtPkid.TabIndex = 75;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(496, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "البيان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "تاريخ القيد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(490, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "رقم القيد";
            // 
            // txtJourNo
            // 
            this.txtJourNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJourNo.Enabled = false;
            this.txtJourNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtJourNo.Location = new System.Drawing.Point(284, 22);
            this.txtJourNo.Name = "txtJourNo";
            this.txtJourNo.Size = new System.Drawing.Size(196, 26);
            this.txtJourNo.TabIndex = 28;
            this.txtJourNo.W_ColumnName = "";
            this.txtJourNo.W_OldValue = "";
            this.txtJourNo.w_Tran = myText.Tran.None;
            // 
            // dgvJourDetails
            // 
            this.dgvJourDetails.AllowUserToAddRows = false;
            this.dgvJourDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvJourDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJourDetails.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJourDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJourDetails.ColumnHeadersHeight = 30;
            this.dgvJourDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmAccId,
            this.clmAccNo,
            this.clmAccName,
            this.clmDept,
            this.clmCredit,
            this.clmProfitCenter,
            this.clmJourNote,
            this.clmDelete});
            this.dgvJourDetails.EnableHeadersVisualStyles = false;
            this.dgvJourDetails.Location = new System.Drawing.Point(3, 126);
            this.dgvJourDetails.Name = "dgvJourDetails";
            this.dgvJourDetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvJourDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJourDetails.RowTemplate.Height = 26;
            this.dgvJourDetails.Size = new System.Drawing.Size(795, 329);
            this.dgvJourDetails.TabIndex = 63;
            this.dgvJourDetails.W_ClmName = "";
            this.dgvJourDetails.W_PK = "";
            this.dgvJourDetails.W_TableName = "";
            this.dgvJourDetails.W_updValName = "";
            this.dgvJourDetails.W_ValName = "";
            this.dgvJourDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJourDetails_CellClick);
            this.dgvJourDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJourDetails_CellDoubleClick);
            this.dgvJourDetails.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvJourDetails_RowsAdded);
            this.dgvJourDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvJourDetails_KeyDown);
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmAccId
            // 
            this.clmAccId.HeaderText = "رقم تعريف  الحساب";
            this.clmAccId.Name = "clmAccId";
            this.clmAccId.ReadOnly = true;
            this.clmAccId.Visible = false;
            this.clmAccId.Width = 396;
            // 
            // clmAccNo
            // 
            this.clmAccNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            // 
            // clmAccName
            // 
            this.clmAccName.HeaderText = "اسم الحساب";
            this.clmAccName.Name = "clmAccName";
            this.clmAccName.ReadOnly = true;
            this.clmAccName.Width = 200;
            // 
            // clmDept
            // 
            this.clmDept.HeaderText = "مدين";
            this.clmDept.Name = "clmDept";
            this.clmDept.ReadOnly = true;
            // 
            // clmCredit
            // 
            this.clmCredit.HeaderText = "دائن";
            this.clmCredit.Name = "clmCredit";
            this.clmCredit.ReadOnly = true;
            // 
            // clmProfitCenter
            // 
            this.clmProfitCenter.HeaderText = "مركز الربحية";
            this.clmProfitCenter.Name = "clmProfitCenter";
            this.clmProfitCenter.ReadOnly = true;
            // 
            // clmJourNote
            // 
            this.clmJourNote.HeaderText = "البيان";
            this.clmJourNote.Name = "clmJourNote";
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::OilStationW.Properties.Resources.Delete16;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.Location = new System.Drawing.Point(156, 461);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClose.Location = new System.Drawing.Point(4, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnNew.Location = new System.Drawing.Point(308, 461);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 68;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnPrint.Location = new System.Drawing.Point(80, 461);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 72;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtDeptTotal
            // 
            this.txtDeptTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptTotal.Enabled = false;
            this.txtDeptTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDeptTotal.Location = new System.Drawing.Point(648, 460);
            this.txtDeptTotal.Name = "txtDeptTotal";
            this.txtDeptTotal.Size = new System.Drawing.Size(150, 26);
            this.txtDeptTotal.TabIndex = 63;
            this.txtDeptTotal.W_ColumnName = "";
            this.txtDeptTotal.W_OldValue = "";
            this.txtDeptTotal.w_Tran = myText.Tran.None;
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditTotal.Enabled = false;
            this.txtCreditTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCreditTotal.Location = new System.Drawing.Point(496, 460);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.Size = new System.Drawing.Size(150, 26);
            this.txtCreditTotal.TabIndex = 73;
            this.txtCreditTotal.W_ColumnName = "";
            this.txtCreditTotal.W_OldValue = "";
            this.txtCreditTotal.w_Tran = myText.Tran.None;
            // 
            // txtDiff
            // 
            this.txtDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiff.Enabled = false;
            this.txtDiff.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDiff.Location = new System.Drawing.Point(496, 487);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(302, 26);
            this.txtDiff.TabIndex = 74;
            this.txtDiff.W_ColumnName = "";
            this.txtDiff.W_OldValue = "";
            this.txtDiff.w_Tran = myText.Tran.None;
            // 
            // txtBranchId
            // 
            this.txtBranchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBranchId.Location = new System.Drawing.Point(55, 59);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(58, 26);
            this.txtBranchId.TabIndex = 77;
            this.txtBranchId.Visible = false;
            this.txtBranchId.W_ColumnName = "";
            this.txtBranchId.W_OldValue = "";
            this.txtBranchId.w_Tran = myText.Tran.None;
            // 
            // nmbExchangeRate
            // 
            this.nmbExchangeRate.DecimalPlaces = 7;
            this.nmbExchangeRate.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbExchangeRate.Location = new System.Drawing.Point(38, 91);
            this.nmbExchangeRate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbExchangeRate.Name = "nmbExchangeRate";
            this.nmbExchangeRate.Size = new System.Drawing.Size(75, 26);
            this.nmbExchangeRate.TabIndex = 78;
            this.nmbExchangeRate.Visible = false;
            this.nmbExchangeRate.W_ColumnName = "";
            this.nmbExchangeRate.W_OldValue = "";
            this.nmbExchangeRate.w_Tran = myNumber.Tran.None;
            // 
            // nmbEditor
            // 
            this.nmbEditor.DecimalPlaces = 2;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbEditor.Location = new System.Drawing.Point(687, 80);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 26);
            this.nmbEditor.TabIndex = 79;
            this.nmbEditor.ThousandsSeparator = true;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
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
            this.btnSave.Location = new System.Drawing.Point(232, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClosingEntry
            // 
            this.btnClosingEntry.BackColor = System.Drawing.Color.Black;
            this.btnClosingEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosingEntry.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnClosingEntry.FlatAppearance.BorderSize = 2;
            this.btnClosingEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnClosingEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnClosingEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosingEntry.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnClosingEntry.ForeColor = System.Drawing.Color.Chocolate;
            this.btnClosingEntry.Location = new System.Drawing.Point(8, 45);
            this.btnClosingEntry.Name = "btnClosingEntry";
            this.btnClosingEntry.Size = new System.Drawing.Size(105, 35);
            this.btnClosingEntry.TabIndex = 81;
            this.btnClosingEntry.Text = "الاقفال";
            this.btnClosingEntry.UseVisualStyleBackColor = false;
            this.btnClosingEntry.Click += new System.EventHandler(this.btnClosingEntry_Click);
            // 
            // btnGetBegningEntry
            // 
            this.btnGetBegningEntry.BackColor = System.Drawing.Color.Black;
            this.btnGetBegningEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetBegningEntry.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnGetBegningEntry.FlatAppearance.BorderSize = 2;
            this.btnGetBegningEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnGetBegningEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnGetBegningEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBegningEntry.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnGetBegningEntry.ForeColor = System.Drawing.Color.Chocolate;
            this.btnGetBegningEntry.Location = new System.Drawing.Point(687, 43);
            this.btnGetBegningEntry.Name = "btnGetBegningEntry";
            this.btnGetBegningEntry.Size = new System.Drawing.Size(107, 35);
            this.btnGetBegningEntry.TabIndex = 82;
            this.btnGetBegningEntry.Text = "استحضار";
            this.btnGetBegningEntry.UseVisualStyleBackColor = false;
            this.btnGetBegningEntry.Click += new System.EventHandler(this.btnGetBegningEntry_Click);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(45, 416);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(318, 26);
            this.lstAccName.TabIndex = 84;
            this.lstAccName.Visible = false;
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
            this.lstAccNo.Location = new System.Drawing.Point(364, 416);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(155, 26);
            this.lstAccNo.TabIndex = 83;
            this.lstAccNo.Visible = false;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAccNo_KeyDown);
            this.lstAccNo.Leave += new System.EventHandler(this.lstAccNo_Leave);
            // 
            // frmBeginingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 520);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.btnGetBegningEntry);
            this.Controls.Add(this.btnClosingEntry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.nmbExchangeRate);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.txtDeptTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvJourDetails);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmBeginingEntry";
            this.Tag = "frmBeginingEntry";
            this.Text = "القيد الافتتاحي";
            this.Titel = "القيد الافتتاحي";
            this.Load += new System.EventHandler(this.frmBeginingEntry_Load);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgvJourDetails, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDeptTotal, 0);
            this.Controls.SetChildIndex(this.txtCreditTotal, 0);
            this.Controls.SetChildIndex(this.txtDiff, 0);
            this.Controls.SetChildIndex(this.txtBranchId, 0);
            this.Controls.SetChildIndex(this.nmbExchangeRate, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClosingEntry, 0);
            this.Controls.SetChildIndex(this.btnGetBegningEntry, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExchangeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myGroupBox myGroupBox1;
        private myText txtJourNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private myText txtHeaderNote;
        private myDate dtpJourDate;
        private SmallButton btnFind;
        private myDataGrid dgvJourDetails;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnNew;
        private MainButton btnPrint;
        private myText txtDeptTotal;
        private myText txtCreditTotal;
        private myText txtDiff;
        private myText txtPkid;
        private myText txtBranchId;
        private myNumber nmbExchangeRate;
        private myNumber nmbEditor;
        private MainButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProfitCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJourNote;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private MainButton btnClosingEntry;
        private MainButton btnGetBegningEntry;
        private myList lstAccName;
        private myList lstAccNo;
    }
}
