namespace OilStationW.Files
{
    partial class frmFormTemplet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbMULTI_FORM_FOR_USER = new System.Windows.Forms.CheckBox();
            this.txtAR_NAME = new myText();
            this.txtEN_NAME = new myText();
            this.btnFind = new SmallButton();
            this.lstFormType = new myList();
            this.myGroupBox1 = new myGroupBox();
            this.btnAdd = new SmallButton();
            this.txtPROPERITY_NOTE = new myText();
            this.txtEnName = new myText();
            this.txtArName = new myText();
            this.txtFreeListId = new myText();
            this.lstListType = new myList();
            this.lstControlType = new myList();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPkid = new myText();
            this.dgvProperities = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFieldNameAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFieldNameEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmListTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmListType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFreeList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(582, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "اسم الشاشة(عربي)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(254, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "الشاشة في البرنامج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(606, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "نوع الشاشة";
            // 
            // ckbMULTI_FORM_FOR_USER
            // 
            this.ckbMULTI_FORM_FOR_USER.AutoSize = true;
            this.ckbMULTI_FORM_FOR_USER.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbMULTI_FORM_FOR_USER.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbMULTI_FORM_FOR_USER.Location = new System.Drawing.Point(97, 63);
            this.ckbMULTI_FORM_FOR_USER.Name = "ckbMULTI_FORM_FOR_USER";
            this.ckbMULTI_FORM_FOR_USER.Size = new System.Drawing.Size(246, 26);
            this.ckbMULTI_FORM_FOR_USER.TabIndex = 53;
            this.ckbMULTI_FORM_FOR_USER.Text = "يقبل اكثر من نموذج للمستخدم الواحد";
            this.ckbMULTI_FORM_FOR_USER.UseVisualStyleBackColor = true;
            // 
            // txtAR_NAME
            // 
            this.txtAR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAR_NAME.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAR_NAME.Location = new System.Drawing.Point(421, 32);
            this.txtAR_NAME.Name = "txtAR_NAME";
            this.txtAR_NAME.Size = new System.Drawing.Size(155, 26);
            this.txtAR_NAME.TabIndex = 56;
            this.txtAR_NAME.W_ColumnName = "";
            this.txtAR_NAME.W_OldValue = "";
            this.txtAR_NAME.w_Tran = myText.Tran.None;
            // 
            // txtEN_NAME
            // 
            this.txtEN_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEN_NAME.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEN_NAME.Location = new System.Drawing.Point(97, 31);
            this.txtEN_NAME.Name = "txtEN_NAME";
            this.txtEN_NAME.Size = new System.Drawing.Size(154, 26);
            this.txtEN_NAME.TabIndex = 57;
            this.txtEN_NAME.W_ColumnName = "";
            this.txtEN_NAME.W_OldValue = "";
            this.txtEN_NAME.w_Tran = myText.Tran.None;
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
            this.btnFind.Location = new System.Drawing.Point(393, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 59;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstFormType
            // 
            this.lstFormType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstFormType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstFormType.Font = new System.Drawing.Font("Arial", 12F);
            this.lstFormType.FormattingEnabled = true;
            this.lstFormType.Location = new System.Drawing.Point(393, 62);
            this.lstFormType.Name = "lstFormType";
            this.lstFormType.Size = new System.Drawing.Size(183, 26);
            this.lstFormType.TabIndex = 60;
            this.lstFormType.W_ColumnName = "";
            this.lstFormType.W_OldValue = "";
            this.lstFormType.w_Tran = myList.Tran.None;
            this.lstFormType.w_ValueType = myList.ValueType.TEXT;
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.btnAdd);
            this.myGroupBox1.Controls.Add(this.txtPROPERITY_NOTE);
            this.myGroupBox1.Controls.Add(this.txtEnName);
            this.myGroupBox1.Controls.Add(this.txtArName);
            this.myGroupBox1.Controls.Add(this.txtFreeListId);
            this.myGroupBox1.Controls.Add(this.lstListType);
            this.myGroupBox1.Controls.Add(this.lstControlType);
            this.myGroupBox1.Controls.Add(this.label7);
            this.myGroupBox1.Controls.Add(this.label6);
            this.myGroupBox1.Controls.Add(this.label5);
            this.myGroupBox1.Controls.Add(this.label4);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(127, 94);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(552, 132);
            this.myGroupBox1.TabIndex = 61;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "اضافة خاصية";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::OilStationW.Properties.Resources.Add_h;
            this.btnAdd.Location = new System.Drawing.Point(48, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPROPERITY_NOTE
            // 
            this.txtPROPERITY_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPROPERITY_NOTE.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPROPERITY_NOTE.Location = new System.Drawing.Point(77, 103);
            this.txtPROPERITY_NOTE.Name = "txtPROPERITY_NOTE";
            this.txtPROPERITY_NOTE.Size = new System.Drawing.Size(339, 23);
            this.txtPROPERITY_NOTE.TabIndex = 36;
            this.txtPROPERITY_NOTE.W_ColumnName = "";
            this.txtPROPERITY_NOTE.W_OldValue = "";
            this.txtPROPERITY_NOTE.w_Tran = myText.Tran.None;
            // 
            // txtEnName
            // 
            this.txtEnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEnName.Location = new System.Drawing.Point(244, 77);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(172, 23);
            this.txtEnName.TabIndex = 35;
            this.txtEnName.W_ColumnName = "";
            this.txtEnName.W_OldValue = "";
            this.txtEnName.w_Tran = myText.Tran.None;
            // 
            // txtArName
            // 
            this.txtArName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtArName.Location = new System.Drawing.Point(244, 50);
            this.txtArName.Name = "txtArName";
            this.txtArName.Size = new System.Drawing.Size(172, 23);
            this.txtArName.TabIndex = 34;
            this.txtArName.W_ColumnName = "";
            this.txtArName.W_OldValue = "";
            this.txtArName.w_Tran = myText.Tran.None;
            // 
            // txtFreeListId
            // 
            this.txtFreeListId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreeListId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFreeListId.Location = new System.Drawing.Point(7, 52);
            this.txtFreeListId.Name = "txtFreeListId";
            this.txtFreeListId.Size = new System.Drawing.Size(47, 23);
            this.txtFreeListId.TabIndex = 33;
            this.txtFreeListId.Visible = false;
            this.txtFreeListId.W_ColumnName = "";
            this.txtFreeListId.W_OldValue = "";
            this.txtFreeListId.w_Tran = myText.Tran.None;
            // 
            // lstListType
            // 
            this.lstListType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstListType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstListType.Font = new System.Drawing.Font("Arial", 10F);
            this.lstListType.FormattingEnabled = true;
            this.lstListType.Location = new System.Drawing.Point(77, 23);
            this.lstListType.Name = "lstListType";
            this.lstListType.Size = new System.Drawing.Size(161, 24);
            this.lstListType.TabIndex = 32;
            this.lstListType.W_ColumnName = "";
            this.lstListType.W_OldValue = "";
            this.lstListType.w_Tran = myList.Tran.None;
            this.lstListType.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstControlType
            // 
            this.lstControlType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstControlType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstControlType.Font = new System.Drawing.Font("Arial", 10F);
            this.lstControlType.FormattingEnabled = true;
            this.lstControlType.Items.AddRange(new object[] {
            "List",
            "MultiChoices",
            "Free List",
            "Free MultiChoices",
            "Text",
            "Enability",
            "Visability"});
            this.lstControlType.Location = new System.Drawing.Point(244, 23);
            this.lstControlType.Name = "lstControlType";
            this.lstControlType.Size = new System.Drawing.Size(172, 24);
            this.lstControlType.TabIndex = 31;
            this.lstControlType.W_ColumnName = "";
            this.lstControlType.W_OldValue = "";
            this.lstControlType.w_Tran = myList.Tran.None;
            this.lstControlType.w_ValueType = myList.ValueType.TEXT;
            this.lstControlType.SelectedIndexChanged += new System.EventHandler(this.lstControlType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(449, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "نوع الحقل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(429, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "اسم الحقل(عربي)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(426, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "اسم الحقل في الشاشة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(453, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "ملاحظات";
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPkid.Location = new System.Drawing.Point(698, 36);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(47, 23);
            this.txtPkid.TabIndex = 62;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // dgvProperities
            // 
            this.dgvProperities.AllowUserToAddRows = false;
            this.dgvProperities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvProperities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProperities.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProperities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProperities.ColumnHeadersHeight = 30;
            this.dgvProperities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmFieldType,
            this.clmFieldNameAr,
            this.clmFieldNameEn,
            this.clmNote,
            this.clmListTypeId,
            this.clmListType,
            this.clmFreeList,
            this.clmDelete});
            this.dgvProperities.EnableHeadersVisualStyles = false;
            this.dgvProperities.Location = new System.Drawing.Point(6, 237);
            this.dgvProperities.Name = "dgvProperities";
            this.dgvProperities.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvProperities.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProperities.Size = new System.Drawing.Size(825, 244);
            this.dgvProperities.TabIndex = 63;
            this.dgvProperities.W_ClmName = "";
            this.dgvProperities.W_PK = "";
            this.dgvProperities.W_TableName = "";
            this.dgvProperities.W_updValName = "";
            this.dgvProperities.W_ValName = "";
            this.dgvProperities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperities_CellClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmFieldType
            // 
            this.clmFieldType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFieldType.HeaderText = "نوع الحقل";
            this.clmFieldType.Name = "clmFieldType";
            this.clmFieldType.ReadOnly = true;
            // 
            // clmFieldNameAr
            // 
            this.clmFieldNameAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFieldNameAr.HeaderText = "اسم الحقل";
            this.clmFieldNameAr.Name = "clmFieldNameAr";
            this.clmFieldNameAr.ReadOnly = true;
            // 
            // clmFieldNameEn
            // 
            this.clmFieldNameEn.HeaderText = "اسم الحقل في الشاشة";
            this.clmFieldNameEn.Name = "clmFieldNameEn";
            this.clmFieldNameEn.ReadOnly = true;
            this.clmFieldNameEn.Width = 150;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "ملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            // 
            // clmListTypeId
            // 
            this.clmListTypeId.HeaderText = "رقم نوع القائمة";
            this.clmListTypeId.Name = "clmListTypeId";
            this.clmListTypeId.ReadOnly = true;
            // 
            // clmListType
            // 
            this.clmListType.HeaderText = "نوع القائمة";
            this.clmListType.Name = "clmListType";
            this.clmListType.ReadOnly = true;
            // 
            // clmFreeList
            // 
            this.clmFreeList.HeaderText = "اسم القائمة الحرة";
            this.clmFreeList.Name = "clmFreeList";
            this.clmFreeList.ReadOnly = true;
            this.clmFreeList.Width = 120;
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
            this.btnUpdate.Location = new System.Drawing.Point(81, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 67;
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
            this.btnClose.Location = new System.Drawing.Point(5, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 66;
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
            this.btnSave.Location = new System.Drawing.Point(157, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 65;
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
            this.btnNew.Location = new System.Drawing.Point(233, 488);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 64;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmFormTemplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 530);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvProperities);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.lstFormType);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtEN_NAME);
            this.Controls.Add(this.txtAR_NAME);
            this.Controls.Add(this.ckbMULTI_FORM_FOR_USER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFormTemplet";
            this.Tag = "frmFormTemplet";
            this.Text = "تعريف النماذج";
            this.Titel = "تعريف النماذج";
            this.Load += new System.EventHandler(this.frmFormTemplet_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ckbMULTI_FORM_FOR_USER, 0);
            this.Controls.SetChildIndex(this.txtAR_NAME, 0);
            this.Controls.SetChildIndex(this.txtEN_NAME, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lstFormType, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.dgvProperities, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbMULTI_FORM_FOR_USER;
        private myText txtAR_NAME;
        private myText txtEN_NAME;
        private SmallButton btnFind;
        private myList lstFormType;
        private myGroupBox myGroupBox1;
        private myText txtPROPERITY_NOTE;
        private myText txtEnName;
        private myText txtArName;
        private myText txtFreeListId;
        private myList lstListType;
        private myList lstControlType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private myText txtPkid;
        private SmallButton btnAdd;
        private myDataGrid dgvProperities;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFieldNameAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFieldNameEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmListTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmListType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFreeList;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}
