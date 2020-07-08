namespace OilStationW.Accounts
{
    partial class frmOtherBranchExpenss
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
            this.nmbEditor = new myNumber();
            this.myGroupBox1 = new myGroupBox();
            this.txtOfficeJourNo = new myText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerson = new myText();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeaderNote = new myText();
            this.dtpJourDate = new myDate();
            this.btnFind = new SmallButton();
            this.txtJourNo = new myText();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccNo = new myText();
            this.txtBranchId = new myText();
            this.txtPkid = new myText();
            this.dgvJourDetails = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJourNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfitCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrint = new MainButton();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtDeptTotal = new myText();
            this.txtAloburAccid = new myText();
            this.txtHeadOfficeAccid = new myText();
            this.txtPkidH = new myText();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // nmbEditor
            // 
            this.nmbEditor.DecimalPlaces = 2;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(688, 56);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 23);
            this.nmbEditor.TabIndex = 81;
            this.nmbEditor.ThousandsSeparator = true;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.txtPkidH);
            this.myGroupBox1.Controls.Add(this.txtOfficeJourNo);
            this.myGroupBox1.Controls.Add(this.label4);
            this.myGroupBox1.Controls.Add(this.txtPerson);
            this.myGroupBox1.Controls.Add(this.label3);
            this.myGroupBox1.Controls.Add(this.txtHeaderNote);
            this.myGroupBox1.Controls.Add(this.dtpJourDate);
            this.myGroupBox1.Controls.Add(this.btnFind);
            this.myGroupBox1.Controls.Add(this.label2);
            this.myGroupBox1.Controls.Add(this.label1);
            this.myGroupBox1.Controls.Add(this.txtPkid);
            this.myGroupBox1.Controls.Add(this.label7);
            this.myGroupBox1.Controls.Add(this.txtJourNo);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(119, 29);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(552, 114);
            this.myGroupBox1.TabIndex = 82;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "بيانات القيد الرئيسية";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            // 
            // txtOfficeJourNo
            // 
            this.txtOfficeJourNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOfficeJourNo.Enabled = false;
            this.txtOfficeJourNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOfficeJourNo.Location = new System.Drawing.Point(6, 22);
            this.txtOfficeJourNo.Name = "txtOfficeJourNo";
            this.txtOfficeJourNo.Size = new System.Drawing.Size(159, 26);
            this.txtOfficeJourNo.TabIndex = 66;
            this.txtOfficeJourNo.W_ColumnName = "";
            this.txtOfficeJourNo.W_OldValue = "";
            this.txtOfficeJourNo.w_Tran = myText.Tran.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(171, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "رقم قيد الأدارة";
            // 
            // txtPerson
            // 
            this.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerson.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPerson.Location = new System.Drawing.Point(6, 81);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(452, 26);
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
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "المستلم";
            // 
            // txtHeaderNote
            // 
            this.txtHeaderNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeaderNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHeaderNote.Location = new System.Drawing.Point(6, 52);
            this.txtHeaderNote.Name = "txtHeaderNote";
            this.txtHeaderNote.Size = new System.Drawing.Size(209, 26);
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
            this.dtpJourDate.Location = new System.Drawing.Point(257, 52);
            this.dtpJourDate.Name = "dtpJourDate";
            this.dtpJourDate.ShowCheckBox = false;
            this.dtpJourDate.Size = new System.Drawing.Size(201, 26);
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
            this.txtJourNo.Size = new System.Drawing.Size(174, 26);
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
            this.label2.Location = new System.Drawing.Point(217, 57);
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
            this.label1.Location = new System.Drawing.Point(464, 55);
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
            this.label7.Location = new System.Drawing.Point(464, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "رقم قيد المحطة";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(40, 93);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(58, 26);
            this.txtAccNo.TabIndex = 87;
            this.txtAccNo.Visible = false;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // txtBranchId
            // 
            this.txtBranchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBranchId.Location = new System.Drawing.Point(40, 69);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(58, 26);
            this.txtBranchId.TabIndex = 86;
            this.txtBranchId.Visible = false;
            this.txtBranchId.W_ColumnName = "";
            this.txtBranchId.W_OldValue = "";
            this.txtBranchId.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(382, 22);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(58, 26);
            this.txtPkid.TabIndex = 85;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // dgvJourDetails
            // 
            this.dgvJourDetails.AllowUserToAddRows = false;
            this.dgvJourDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
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
            this.clmJourNote,
            this.clmProfitCenter,
            this.clmDelete});
            this.dgvJourDetails.EnableHeadersVisualStyles = false;
            this.dgvJourDetails.Location = new System.Drawing.Point(3, 147);
            this.dgvJourDetails.Name = "dgvJourDetails";
            this.dgvJourDetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvJourDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJourDetails.Size = new System.Drawing.Size(795, 329);
            this.dgvJourDetails.TabIndex = 88;
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
            this.clmAccId.Width = 90;
            // 
            // clmAccNo
            // 
            this.clmAccNo.HeaderText = "رقم الحساب";
            this.clmAccNo.Name = "clmAccNo";
            this.clmAccNo.ReadOnly = true;
            // 
            // clmAccName
            // 
            this.clmAccName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAccName.HeaderText = "اسم الحساب";
            this.clmAccName.Name = "clmAccName";
            this.clmAccName.ReadOnly = true;
            // 
            // clmDept
            // 
            this.clmDept.HeaderText = "مدين";
            this.clmDept.Name = "clmDept";
            this.clmDept.ReadOnly = true;
            // 
            // clmJourNote
            // 
            this.clmJourNote.HeaderText = "البيان";
            this.clmJourNote.Name = "clmJourNote";
            this.clmJourNote.Width = 150;
            // 
            // clmProfitCenter
            // 
            this.clmProfitCenter.HeaderText = "مركز الربحية";
            this.clmProfitCenter.Name = "clmProfitCenter";
            this.clmProfitCenter.ReadOnly = true;
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
            this.btnPrint.Location = new System.Drawing.Point(79, 479);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 93;
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
            this.btnUpdate.Location = new System.Drawing.Point(155, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 92;
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
            this.btnClose.Location = new System.Drawing.Point(3, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 91;
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
            this.btnSave.Location = new System.Drawing.Point(231, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 90;
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
            this.btnNew.Location = new System.Drawing.Point(307, 479);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 89;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDeptTotal
            // 
            this.txtDeptTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDeptTotal.Location = new System.Drawing.Point(654, 479);
            this.txtDeptTotal.Name = "txtDeptTotal";
            this.txtDeptTotal.Size = new System.Drawing.Size(143, 26);
            this.txtDeptTotal.TabIndex = 94;
            this.txtDeptTotal.W_ColumnName = "";
            this.txtDeptTotal.W_OldValue = "";
            this.txtDeptTotal.w_Tran = myText.Tran.None;
            // 
            // txtAloburAccid
            // 
            this.txtAloburAccid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAloburAccid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAloburAccid.Location = new System.Drawing.Point(38, 112);
            this.txtAloburAccid.Name = "txtAloburAccid";
            this.txtAloburAccid.Size = new System.Drawing.Size(29, 26);
            this.txtAloburAccid.TabIndex = 96;
            this.txtAloburAccid.Visible = false;
            this.txtAloburAccid.W_ColumnName = "";
            this.txtAloburAccid.W_OldValue = "";
            this.txtAloburAccid.w_Tran = myText.Tran.None;
            // 
            // txtHeadOfficeAccid
            // 
            this.txtHeadOfficeAccid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadOfficeAccid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHeadOfficeAccid.Location = new System.Drawing.Point(20, 111);
            this.txtHeadOfficeAccid.Name = "txtHeadOfficeAccid";
            this.txtHeadOfficeAccid.Size = new System.Drawing.Size(58, 26);
            this.txtHeadOfficeAccid.TabIndex = 95;
            this.txtHeadOfficeAccid.Visible = false;
            this.txtHeadOfficeAccid.W_ColumnName = "";
            this.txtHeadOfficeAccid.W_OldValue = "";
            this.txtHeadOfficeAccid.w_Tran = myText.Tran.None;
            // 
            // txtPkidH
            // 
            this.txtPkidH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkidH.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkidH.Location = new System.Drawing.Point(76, 22);
            this.txtPkidH.Name = "txtPkidH";
            this.txtPkidH.Size = new System.Drawing.Size(58, 26);
            this.txtPkidH.TabIndex = 97;
            this.txtPkidH.Visible = false;
            this.txtPkidH.W_ColumnName = "";
            this.txtPkidH.W_OldValue = "";
            this.txtPkidH.w_Tran = myText.Tran.None;
            // 
            // frmOtherBranchExpenss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.txtAloburAccid);
            this.Controls.Add(this.txtHeadOfficeAccid);
            this.Controls.Add(this.txtDeptTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvJourDetails);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.nmbEditor);
            this.Name = "frmOtherBranchExpenss";
            this.Tag = "frmOtherBranchExpenss";
            this.Text = "صرف مصاريف الادارة العامة";
            this.Titel = "صرف مصاريف الادارة العامة";
            this.Load += new System.EventHandler(this.frmOtherBranchExpenss_Load);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.txtBranchId, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.dgvJourDetails, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDeptTotal, 0);
            this.Controls.SetChildIndex(this.txtHeadOfficeAccid, 0);
            this.Controls.SetChildIndex(this.txtAloburAccid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myNumber nmbEditor;
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
        private myText txtAccNo;
        private myText txtBranchId;
        private myText txtPkid;
        private myDataGrid dgvJourDetails;
        private MainButton btnPrint;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtDeptTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJourNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProfitCenter;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private myText txtAloburAccid;
        private myText txtHeadOfficeAccid;
        private myText txtOfficeJourNo;
        private System.Windows.Forms.Label label4;
        private myText txtPkidH;
    }
}
