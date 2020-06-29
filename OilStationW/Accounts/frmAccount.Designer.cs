namespace OilStationW.Accounts
{
    partial class frmAccount
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
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.txtLevel = new myText();
            this.txtParentAccNo = new myText();
            this.txtParentId = new myText();
            this.txtPkid = new myText();
            this.txtAccShoreNo = new myText();
            this.txtAccNote = new myText();
            this.lstAccountNature = new myList();
            this.lstSubAccount = new myList();
            this.lstReportType = new myList();
            this.txtParentAccName = new myText();
            this.txtAccName = new myText();
            this.txtAccNo = new myText();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(90, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 291;
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
            this.btnSave.Location = new System.Drawing.Point(166, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 290;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevel.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLevel.Location = new System.Drawing.Point(110, 212);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(51, 26);
            this.txtLevel.TabIndex = 310;
            this.txtLevel.Visible = false;
            this.txtLevel.W_ColumnName = "";
            this.txtLevel.W_OldValue = "";
            this.txtLevel.w_Tran = myText.Tran.None;
            // 
            // txtParentAccNo
            // 
            this.txtParentAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtParentAccNo.Location = new System.Drawing.Point(68, 92);
            this.txtParentAccNo.Name = "txtParentAccNo";
            this.txtParentAccNo.Size = new System.Drawing.Size(51, 26);
            this.txtParentAccNo.TabIndex = 309;
            this.txtParentAccNo.Visible = false;
            this.txtParentAccNo.W_ColumnName = "";
            this.txtParentAccNo.W_OldValue = "";
            this.txtParentAccNo.w_Tran = myText.Tran.None;
            // 
            // txtParentId
            // 
            this.txtParentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtParentId.Location = new System.Drawing.Point(135, 92);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(51, 26);
            this.txtParentId.TabIndex = 308;
            this.txtParentId.Visible = false;
            this.txtParentId.W_ColumnName = "";
            this.txtParentId.W_OldValue = "";
            this.txtParentId.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(135, 32);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(51, 26);
            this.txtPkid.TabIndex = 307;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // txtAccShoreNo
            // 
            this.txtAccShoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccShoreNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccShoreNo.Location = new System.Drawing.Point(68, 32);
            this.txtAccShoreNo.Name = "txtAccShoreNo";
            this.txtAccShoreNo.Size = new System.Drawing.Size(51, 26);
            this.txtAccShoreNo.TabIndex = 306;
            this.txtAccShoreNo.Visible = false;
            this.txtAccShoreNo.W_ColumnName = "";
            this.txtAccShoreNo.W_OldValue = "";
            this.txtAccShoreNo.w_Tran = myText.Tran.None;
            // 
            // txtAccNote
            // 
            this.txtAccNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNote.Location = new System.Drawing.Point(10, 212);
            this.txtAccNote.Name = "txtAccNote";
            this.txtAccNote.Size = new System.Drawing.Size(208, 26);
            this.txtAccNote.TabIndex = 305;
            this.txtAccNote.W_ColumnName = "";
            this.txtAccNote.W_OldValue = "";
            this.txtAccNote.w_Tran = myText.Tran.None;
            // 
            // lstAccountNature
            // 
            this.lstAccountNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccountNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccountNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstAccountNature.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccountNature.FormattingEnabled = true;
            this.lstAccountNature.Items.AddRange(new object[] {
            "مدين",
            "دائن",
            "مدين/دائن"});
            this.lstAccountNature.Location = new System.Drawing.Point(10, 182);
            this.lstAccountNature.Name = "lstAccountNature";
            this.lstAccountNature.Size = new System.Drawing.Size(208, 26);
            this.lstAccountNature.TabIndex = 304;
            this.lstAccountNature.W_ColumnName = "";
            this.lstAccountNature.W_OldValue = "";
            this.lstAccountNature.w_Tran = myList.Tran.None;
            this.lstAccountNature.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstSubAccount
            // 
            this.lstSubAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstSubAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.lstSubAccount.Location = new System.Drawing.Point(10, 152);
            this.lstSubAccount.Name = "lstSubAccount";
            this.lstSubAccount.Size = new System.Drawing.Size(208, 26);
            this.lstSubAccount.TabIndex = 303;
            this.lstSubAccount.W_ColumnName = "";
            this.lstSubAccount.W_OldValue = "";
            this.lstSubAccount.w_Tran = myList.Tran.None;
            this.lstSubAccount.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstReportType
            // 
            this.lstReportType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstReportType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstReportType.Font = new System.Drawing.Font("Arial", 12F);
            this.lstReportType.FormattingEnabled = true;
            this.lstReportType.Items.AddRange(new object[] {
            "الميزانية العمومية",
            "الأرباح والخسائر"});
            this.lstReportType.Location = new System.Drawing.Point(10, 122);
            this.lstReportType.Name = "lstReportType";
            this.lstReportType.Size = new System.Drawing.Size(208, 26);
            this.lstReportType.TabIndex = 302;
            this.lstReportType.W_ColumnName = "";
            this.lstReportType.W_OldValue = "";
            this.lstReportType.w_Tran = myList.Tran.None;
            this.lstReportType.w_ValueType = myList.ValueType.TEXT;
            // 
            // txtParentAccName
            // 
            this.txtParentAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentAccName.Enabled = false;
            this.txtParentAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtParentAccName.Location = new System.Drawing.Point(10, 92);
            this.txtParentAccName.Name = "txtParentAccName";
            this.txtParentAccName.Size = new System.Drawing.Size(208, 26);
            this.txtParentAccName.TabIndex = 301;
            this.txtParentAccName.W_ColumnName = "";
            this.txtParentAccName.W_OldValue = "";
            this.txtParentAccName.w_Tran = myText.Tran.None;
            // 
            // txtAccName
            // 
            this.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccName.Location = new System.Drawing.Point(10, 62);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(208, 26);
            this.txtAccName.TabIndex = 300;
            this.txtAccName.W_ColumnName = "";
            this.txtAccName.W_OldValue = "";
            this.txtAccName.w_Tran = myText.Tran.None;
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAccNo.Location = new System.Drawing.Point(10, 32);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(208, 26);
            this.txtAccNo.TabIndex = 299;
            this.txtAccNo.W_ColumnName = "";
            this.txtAccNo.W_OldValue = "";
            this.txtAccNo.w_Tran = myText.Tran.None;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(239, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 298;
            this.label8.Text = "مـلاحـظـات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(236, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 297;
            this.label7.Text = "طبيعة الحساب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(230, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 296;
            this.label6.Text = "الحساب الفرعي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(239, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 295;
            this.label5.Text = "نوع التقرير";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(239, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 294;
            this.label4.Text = "حساب الأب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(239, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 293;
            this.label3.Text = "اسم الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(239, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 292;
            this.label2.Text = "رقم الحساب";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(342, 294);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtParentAccNo);
            this.Controls.Add(this.txtParentId);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.txtAccShoreNo);
            this.Controls.Add(this.txtAccNote);
            this.Controls.Add(this.lstAccountNature);
            this.Controls.Add(this.lstSubAccount);
            this.Controls.Add(this.lstReportType);
            this.Controls.Add(this.txtParentAccName);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAccount";
            this.Tag = "frmAccount";
            this.Text = "بيانات الحسابات";
            this.Titel = "بيانات الحسابات";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtAccNo, 0);
            this.Controls.SetChildIndex(this.txtAccName, 0);
            this.Controls.SetChildIndex(this.txtParentAccName, 0);
            this.Controls.SetChildIndex(this.lstReportType, 0);
            this.Controls.SetChildIndex(this.lstSubAccount, 0);
            this.Controls.SetChildIndex(this.lstAccountNature, 0);
            this.Controls.SetChildIndex(this.txtAccNote, 0);
            this.Controls.SetChildIndex(this.txtAccShoreNo, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.txtParentId, 0);
            this.Controls.SetChildIndex(this.txtParentAccNo, 0);
            this.Controls.SetChildIndex(this.txtLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MainButton btnClose;
        private MainButton btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public myText txtLevel;
        public myText txtParentAccNo;
        public myText txtParentId;
        public myText txtPkid;
        public myText txtAccShoreNo;
        public myText txtAccNote;
        public myList lstAccountNature;
        public myList lstSubAccount;
        public myList lstReportType;
        public myText txtParentAccName;
        public myText txtAccName;
        public myText txtAccNo;
    }
}
