﻿namespace OilStationW.Accounts
{
    partial class frmCashReceipts
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
            this.txtAccNo = new myText();
            this.txtBranchId = new myText();
            this.txtPkid = new myText();
            this.nmbEditor = new myNumber();
            this.txtCreditTotal = new myText();
            this.btnPrint = new MainButton();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.dgvJourDetails = new myDataGrid();
            this.myGroupBox1 = new myGroupBox();
            this.txtPerson = new myText();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeaderNote = new myText();
            this.dtpJourDate = new myDate();
            this.btnFind = new SmallButton();
            this.txtJourNo = new myText();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJourNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfitCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfitCenter1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(32, 113);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(58, 26);
            this.txtAccNo.TabIndex = 96;
            this.txtAccNo.Visible = false;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // txtBranchId
            // 
            this.txtBranchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBranchId.Location = new System.Drawing.Point(32, 77);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(58, 26);
            this.txtBranchId.TabIndex = 95;
            this.txtBranchId.Visible = false;
            this.txtBranchId.W_ColumnName = "";
            this.txtBranchId.W_OldValue = "";
            this.txtBranchId.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(32, 50);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(58, 26);
            this.txtPkid.TabIndex = 94;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // nmbEditor
            // 
            this.nmbEditor.DecimalPlaces = 2;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbEditor.Location = new System.Drawing.Point(674, 88);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 26);
            this.nmbEditor.TabIndex = 93;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCreditTotal.Location = new System.Drawing.Point(655, 482);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.Size = new System.Drawing.Size(143, 26);
            this.txtCreditTotal.TabIndex = 92;
            this.txtCreditTotal.W_ColumnName = "";
            this.txtCreditTotal.W_OldValue = "";
            this.txtCreditTotal.w_Tran = myText.Tran.None;
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
            this.btnPrint.Location = new System.Drawing.Point(80, 482);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 91;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(156, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 90;
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
            this.btnClose.Location = new System.Drawing.Point(4, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 89;
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
            this.btnSave.Location = new System.Drawing.Point(232, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 88;
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
            this.btnNew.Location = new System.Drawing.Point(308, 482);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 87;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.clmCredit,
            this.clmJourNote,
            this.clmProfitCenter,
            this.clmProfitCenter1,
            this.clmDelete});
            this.dgvJourDetails.EnableHeadersVisualStyles = false;
            this.dgvJourDetails.Location = new System.Drawing.Point(3, 149);
            this.dgvJourDetails.Name = "dgvJourDetails";
            this.dgvJourDetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvJourDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJourDetails.RowTemplate.Height = 26;
            this.dgvJourDetails.Size = new System.Drawing.Size(795, 329);
            this.dgvJourDetails.TabIndex = 86;
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
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtPerson);
            this.myGroupBox1.Controls.Add(this.label3);
            this.myGroupBox1.Controls.Add(this.txtHeaderNote);
            this.myGroupBox1.Controls.Add(this.dtpJourDate);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Controls.Add(this.txtJourNo);
            this.myGroupBox1.Controls.Add(this.label2);
            this.myGroupBox1.Controls.Add(this.label1);
            this.myGroupBox1.Controls.Add(this.label7);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(114, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(552, 114);
            this.myGroupBox1.TabIndex = 85;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات القيد الرئيسية";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            // 
            // txtPerson
            // 
            this.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerson.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPerson.Location = new System.Drawing.Point(6, 81);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(474, 26);
            this.txtPerson.TabIndex = 64;
            this.txtPerson.W_ColumnName = "";
            this.txtPerson.W_OldValue = "";
            this.txtPerson.w_Tran = myText.Tran.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(492, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "المسلم";
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
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(8, 450);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(318, 26);
            this.lstAccName.TabIndex = 98;
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
            this.lstAccNo.Location = new System.Drawing.Point(327, 450);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(155, 26);
            this.lstAccNo.TabIndex = 97;
            this.lstAccNo.Visible = false;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            this.lstAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAccNo_KeyDown);
            this.lstAccNo.Leave += new System.EventHandler(this.lstAccNo_Leave);
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
            this.clmAccId.Width = 90;
            // 
            // clmAccNo
            // 
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            this.clmAccNo.Width = 120;
            // 
            // clmAccName
            // 
            this.clmAccName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAccName.HeaderText = "اسم الحساب";
            this.clmAccName.Name = "clmAccName";
            this.clmAccName.ReadOnly = true;
            // 
            // clmCredit
            // 
            this.clmCredit.HeaderText = "دائن";
            this.clmCredit.Name = "clmCredit";
            this.clmCredit.ReadOnly = true;
            // 
            // clmJourNote
            // 
            this.clmJourNote.HeaderText = "البيان";
            this.clmJourNote.Name = "clmJourNote";
            this.clmJourNote.Width = 150;
            // 
            // clmProfitCenter
            // 
            this.clmProfitCenter.HeaderText = "مركز التكلفة";
            this.clmProfitCenter.Name = "clmProfitCenter";
            this.clmProfitCenter.ReadOnly = true;
            // 
            // clmProfitCenter1
            // 
            this.clmProfitCenter1.HeaderText = "مركز التكلفة1";
            this.clmProfitCenter1.Name = "clmProfitCenter1";
            this.clmProfitCenter1.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::OilStationW.Properties.Resources.Delete16;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
            // 
            // frmCashReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvJourDetails);
            this.Controls.Add(this.myGroupBox1);
            this.Name = "frmCashReceipts";
            this.Tag = "frmCashReceipts";
            this.Text = "سند قبض";
            this.Titel = "سند قبض";
            this.Load += new System.EventHandler(this.frmCashReceipts_Load);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.dgvJourDetails, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtCreditTotal, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.txtBranchId, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText txtAccNo;
        private myText txtBranchId;
        private myText txtPkid;
        private myNumber nmbEditor;
        private myText txtCreditTotal;
        private MainButton btnPrint;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myDataGrid dgvJourDetails;
        private myGroupBox myGroupBox1;
        private myText txtPerson;
        private System.Windows.Forms.Label label3;
        private myText txtHeaderNote;
        private myDate dtpJourDate;
        private SmallButton btnFind;
        private myText txtJourNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private myList lstAccName;
        private myList lstAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJourNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProfitCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProfitCenter1;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}
