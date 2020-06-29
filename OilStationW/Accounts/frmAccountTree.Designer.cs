namespace OilStationW.Accounts
{
    partial class frmAccountTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTree));
            this.btnFind = new SmallButton();
            this.txtNodeName = new myText();
            this.label1 = new System.Windows.Forms.Label();
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccNo = new myText();
            this.txtAccName = new myText();
            this.txtAccParentName = new myText();
            this.lstReportType = new myList();
            this.lstSubAccount = new myList();
            this.lstAccountNature = new myList();
            this.txtAccNote = new myText();
            this.txtAccShoreNo = new myText();
            this.txtPkid = new myText();
            this.txtParentId = new myText();
            this.txtParentAccNo = new myText();
            this.txtLevel = new myText();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.btnDelete = new MainButton();
            this.SuspendLayout();
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
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(345, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 54;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNodeName.Location = new System.Drawing.Point(373, 34);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(335, 26);
            this.txtNodeName.TabIndex = 53;
            this.txtNodeName.W_ColumnName = "";
            this.txtNodeName.W_OldValue = "";
            this.txtNodeName.w_Tran = myText.Tran.None;
            this.txtNodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNodeName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(713, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "اسم الحساب";
            // 
            // tvAccounts
            // 
            this.tvAccounts.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvAccounts.Location = new System.Drawing.Point(345, 66);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.RightToLeftLayout = true;
            this.tvAccounts.Size = new System.Drawing.Size(455, 454);
            this.tvAccounts.TabIndex = 251;
            this.tvAccounts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvAccounts_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(241, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 252;
            this.label2.Text = "رقم الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(241, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 253;
            this.label3.Text = "اسم الحساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(241, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 254;
            this.label4.Text = "حساب الأب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(241, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 255;
            this.label5.Text = "نوع التقرير";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(232, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 256;
            this.label6.Text = "الحساب الفرعي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(238, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 257;
            this.label7.Text = "طبيعة الحساب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(241, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 258;
            this.label8.Text = "مـلاحـظـات";
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(12, 67);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(208, 26);
            this.txtAccNo.TabIndex = 259;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // txtAccName
            // 
            this.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccName.Enabled = false;
            this.txtAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccName.Location = new System.Drawing.Point(12, 97);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(208, 26);
            this.txtAccName.TabIndex = 260;
            this.txtAccName.W_ColumnName = "";
            this.txtAccName.W_OldValue = "";
            this.txtAccName.w_Tran = myText.Tran.None;
            // 
            // txtAccParentName
            // 
            this.txtAccParentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccParentName.Enabled = false;
            this.txtAccParentName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccParentName.Location = new System.Drawing.Point(12, 127);
            this.txtAccParentName.Name = "txtAccParentName";
            this.txtAccParentName.Size = new System.Drawing.Size(208, 26);
            this.txtAccParentName.TabIndex = 261;
            this.txtAccParentName.W_ColumnName = "";
            this.txtAccParentName.W_OldValue = "";
            this.txtAccParentName.w_Tran = myText.Tran.None;
            // 
            // lstReportType
            // 
            this.lstReportType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstReportType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstReportType.Enabled = false;
            this.lstReportType.Font = new System.Drawing.Font("Arial", 12F);
            this.lstReportType.FormattingEnabled = true;
            this.lstReportType.Items.AddRange(new object[] {
            "الميزانية العمومية",
            "الأرباح والخسائر"});
            this.lstReportType.Location = new System.Drawing.Point(12, 157);
            this.lstReportType.Name = "lstReportType";
            this.lstReportType.Size = new System.Drawing.Size(208, 26);
            this.lstReportType.TabIndex = 262;
            this.lstReportType.W_ColumnName = "";
            this.lstReportType.W_OldValue = "";
            this.lstReportType.w_Tran = myList.Tran.None;
            this.lstReportType.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstSubAccount
            // 
            this.lstSubAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSubAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstSubAccount.Enabled = false;
            this.lstSubAccount.Font = new System.Drawing.Font("Arial", 12F);
            this.lstSubAccount.FormattingEnabled = true;
            this.lstSubAccount.Items.AddRange(new object[] {
            " أستاذ عام",
            "النقدية",
            "بنوك",
            "استثمارات",
            "العملاء",
            "المخازن",
            "ارصدة مدينة",
            "ذمم",
            "الاصول الثابتة",
            "قروض وتمويلات",
            "ارصدة دائنة",
            "رأس المال"});
            this.lstSubAccount.Location = new System.Drawing.Point(12, 187);
            this.lstSubAccount.Name = "lstSubAccount";
            this.lstSubAccount.Size = new System.Drawing.Size(208, 26);
            this.lstSubAccount.TabIndex = 263;
            this.lstSubAccount.W_ColumnName = "";
            this.lstSubAccount.W_OldValue = "";
            this.lstSubAccount.w_Tran = myList.Tran.None;
            this.lstSubAccount.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstAccountNature
            // 
            this.lstAccountNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccountNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccountNature.Enabled = false;
            this.lstAccountNature.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccountNature.FormattingEnabled = true;
            this.lstAccountNature.Items.AddRange(new object[] {
            "مدين",
            "دائن",
            "مدين/دائن"});
            this.lstAccountNature.Location = new System.Drawing.Point(12, 217);
            this.lstAccountNature.Name = "lstAccountNature";
            this.lstAccountNature.Size = new System.Drawing.Size(208, 26);
            this.lstAccountNature.TabIndex = 264;
            this.lstAccountNature.W_ColumnName = "";
            this.lstAccountNature.W_OldValue = "";
            this.lstAccountNature.w_Tran = myList.Tran.None;
            this.lstAccountNature.w_ValueType = myList.ValueType.TEXT;
            // 
            // txtAccNote
            // 
            this.txtAccNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNote.Enabled = false;
            this.txtAccNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNote.Location = new System.Drawing.Point(12, 247);
            this.txtAccNote.Name = "txtAccNote";
            this.txtAccNote.Size = new System.Drawing.Size(208, 26);
            this.txtAccNote.TabIndex = 265;
            this.txtAccNote.W_ColumnName = "";
            this.txtAccNote.W_OldValue = "";
            this.txtAccNote.w_Tran = myText.Tran.None;
            // 
            // txtAccShoreNo
            // 
            this.txtAccShoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccShoreNo.Enabled = false;
            this.txtAccShoreNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccShoreNo.Location = new System.Drawing.Point(70, 67);
            this.txtAccShoreNo.Name = "txtAccShoreNo";
            this.txtAccShoreNo.Size = new System.Drawing.Size(51, 26);
            this.txtAccShoreNo.TabIndex = 266;
            this.txtAccShoreNo.Visible = false;
            this.txtAccShoreNo.W_ColumnName = "";
            this.txtAccShoreNo.W_OldValue = "";
            this.txtAccShoreNo.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Enabled = false;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(137, 67);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(51, 26);
            this.txtPkid.TabIndex = 267;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // txtParentId
            // 
            this.txtParentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentId.Enabled = false;
            this.txtParentId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtParentId.Location = new System.Drawing.Point(137, 127);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(51, 26);
            this.txtParentId.TabIndex = 268;
            this.txtParentId.Visible = false;
            this.txtParentId.W_ColumnName = "";
            this.txtParentId.W_OldValue = "";
            this.txtParentId.w_Tran = myText.Tran.None;
            // 
            // txtParentAccNo
            // 
            this.txtParentAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentAccNo.Enabled = false;
            this.txtParentAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtParentAccNo.Location = new System.Drawing.Point(70, 127);
            this.txtParentAccNo.Name = "txtParentAccNo";
            this.txtParentAccNo.Size = new System.Drawing.Size(51, 26);
            this.txtParentAccNo.TabIndex = 269;
            this.txtParentAccNo.Visible = false;
            this.txtParentAccNo.W_ColumnName = "";
            this.txtParentAccNo.W_OldValue = "";
            this.txtParentAccNo.w_Tran = myText.Tran.None;
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevel.Enabled = false;
            this.txtLevel.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLevel.Location = new System.Drawing.Point(112, 247);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(51, 26);
            this.txtLevel.TabIndex = 270;
            this.txtLevel.Visible = false;
            this.txtLevel.W_ColumnName = "";
            this.txtLevel.W_OldValue = "";
            this.txtLevel.w_Tran = myText.Tran.None;
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
            this.btnUpdate.Location = new System.Drawing.Point(157, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 274;
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
            this.btnClose.Location = new System.Drawing.Point(5, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 273;
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
            this.btnSave.Location = new System.Drawing.Point(233, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 272;
            this.btnSave.Text = "إضافة";
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
            this.btnNew.Location = new System.Drawing.Point(309, 526);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 271;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDelete.Location = new System.Drawing.Point(81, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 275;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(803, 568);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtParentAccNo);
            this.Controls.Add(this.txtParentId);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.txtAccShoreNo);
            this.Controls.Add(this.txtAccNote);
            this.Controls.Add(this.lstAccountNature);
            this.Controls.Add(this.lstSubAccount);
            this.Controls.Add(this.lstReportType);
            this.Controls.Add(this.txtAccParentName);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvAccounts);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountTree";
            this.Tag = "frmAccountTree";
            this.Text = "الدليل المحاسبي";
            this.Titel = "الدليل المحاسبي";
            this.Load += new System.EventHandler(this.frmAccountTree_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNodeName, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.tvAccounts, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.txtAccName, 0);
            this.Controls.SetChildIndex(this.txtAccParentName, 0);
            this.Controls.SetChildIndex(this.lstReportType, 0);
            this.Controls.SetChildIndex(this.lstSubAccount, 0);
            this.Controls.SetChildIndex(this.lstAccountNature, 0);
            this.Controls.SetChildIndex(this.txtAccNote, 0);
            this.Controls.SetChildIndex(this.txtAccShoreNo, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.txtParentId, 0);
            this.Controls.SetChildIndex(this.txtParentAccNo, 0);
            this.Controls.SetChildIndex(this.txtLevel, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmallButton btnFind;
        private myText txtNodeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private myText txtAccNo;
        private myText txtAccName;
        private myText txtAccParentName;
        private myList lstReportType;
        private myList lstSubAccount;
        private myList lstAccountNature;
        private myText txtAccNote;
        private myText txtAccShoreNo;
        private myText txtPkid;
        private myText txtParentId;
        private myText txtParentAccNo;
        private myText txtLevel;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private MainButton btnDelete;
    }
}
