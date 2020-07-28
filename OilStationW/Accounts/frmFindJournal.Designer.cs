namespace OilStationW.Accounts
{
    partial class frmFindJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindJournal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDate = new myGroupBox();
            this.dtpTo = new myDate();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new myDate();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSelectDate = new System.Windows.Forms.CheckBox();
            this.btnFind = new SmallButton();
            this.txtSearchField = new myText();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvJournalData = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJourDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJourNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MainButton();
            this.btnOk = new MainButton();
            this.gbDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDate
            // 
            this.gbDate.BackColor = System.Drawing.Color.Transparent;
            this.gbDate.Controls.Add(this.dtpTo);
            this.gbDate.Controls.Add(this.label2);
            this.gbDate.Controls.Add(this.dtpFrom);
            this.gbDate.Controls.Add(this.label1);
            this.gbDate.Enabled = false;
            this.gbDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDate.ForeColor = System.Drawing.Color.Chocolate;
            this.gbDate.Location = new System.Drawing.Point(237, 32);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(241, 97);
            this.gbDate.TabIndex = 64;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "تحديد المدة";
            this.gbDate.W_FormArabicName = null;
            this.gbDate.W_Pk = null;
            this.gbDate.W_TableName = null;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(6, 60);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowCheckBox = false;
            this.dtpTo.Size = new System.Drawing.Size(163, 26);
            this.dtpTo.TabIndex = 63;
            this.dtpTo.W_ColumnName = "";
            this.dtpTo.W_OldValue = "";
            this.dtpTo.w_Tran = myDate.Tran.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(178, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "إلى تاريخ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(6, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = false;
            this.dtpFrom.Size = new System.Drawing.Size(163, 26);
            this.dtpFrom.TabIndex = 61;
            this.dtpFrom.W_ColumnName = "";
            this.dtpFrom.W_OldValue = "";
            this.dtpFrom.w_Tran = myDate.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "من تاريخ";
            // 
            // ckbSelectDate
            // 
            this.ckbSelectDate.AutoSize = true;
            this.ckbSelectDate.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbSelectDate.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbSelectDate.Location = new System.Drawing.Point(136, 77);
            this.ckbSelectDate.Name = "ckbSelectDate";
            this.ckbSelectDate.Size = new System.Drawing.Size(92, 26);
            this.ckbSelectDate.TabIndex = 67;
            this.ckbSelectDate.Text = "تحديد المدة";
            this.ckbSelectDate.UseVisualStyleBackColor = true;
            this.ckbSelectDate.CheckedChanged += new System.EventHandler(this.ckbSelectDate_CheckedChanged);
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
            this.btnFind.Location = new System.Drawing.Point(201, 135);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 70;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchField.Location = new System.Drawing.Point(229, 135);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(249, 26);
            this.txtSearchField.TabIndex = 69;
            this.txtSearchField.W_ColumnName = "";
            this.txtSearchField.W_OldValue = "";
            this.txtSearchField.w_Tran = myText.Tran.None;
            this.txtSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchField_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(487, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "البحث";
            // 
            // dgvJournalData
            // 
            this.dgvJournalData.AllowUserToAddRows = false;
            this.dgvJournalData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvJournalData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJournalData.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournalData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJournalData.ColumnHeadersHeight = 30;
            this.dgvJournalData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmTransNo,
            this.clmJourDate,
            this.clmCurrValue,
            this.clmAccNo,
            this.clmAccName,
            this.clmJourNote});
            this.dgvJournalData.EnableHeadersVisualStyles = false;
            this.dgvJournalData.Location = new System.Drawing.Point(3, 167);
            this.dgvJournalData.Name = "dgvJournalData";
            this.dgvJournalData.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvJournalData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJournalData.Size = new System.Drawing.Size(709, 337);
            this.dgvJournalData.TabIndex = 71;
            this.dgvJournalData.W_ClmName = "";
            this.dgvJournalData.W_PK = "";
            this.dgvJournalData.W_TableName = "";
            this.dgvJournalData.W_updValName = "";
            this.dgvJournalData.W_ValName = "";
            this.dgvJournalData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalData_CellDoubleClick);
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmTransNo
            // 
            this.clmTransNo.FillWeight = 50F;
            this.clmTransNo.HeaderText = "رقم السند";
            this.clmTransNo.Name = "clmTransNo";
            this.clmTransNo.ReadOnly = true;
            // 
            // clmJourDate
            // 
            this.clmJourDate.HeaderText = "تاريخ السند";
            this.clmJourDate.Name = "clmJourDate";
            this.clmJourDate.ReadOnly = true;
            // 
            // clmCurrValue
            // 
            this.clmCurrValue.HeaderText = "المبلغ";
            this.clmCurrValue.Name = "clmCurrValue";
            this.clmCurrValue.ReadOnly = true;
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
            // clmJourNote
            // 
            this.clmJourNote.HeaderText = "البيان";
            this.clmJourNote.Name = "clmJourNote";
            this.clmJourNote.ReadOnly = true;
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
            this.btnClose.Location = new System.Drawing.Point(3, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnOk.ForeColor = System.Drawing.Color.Chocolate;
            this.btnOk.Location = new System.Drawing.Point(79, 510);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 72;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmFindJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvJournalData);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbSelectDate);
            this.Controls.Add(this.gbDate);
            this.Name = "frmFindJournal";
            this.Text = "البحث عن سند";
            this.Titel = "البحث عن سند";
            this.Load += new System.EventHandler(this.frmFindJournal_Load);
            this.Controls.SetChildIndex(this.gbDate, 0);
            this.Controls.SetChildIndex(this.ckbSelectDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSearchField, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.dgvJournalData, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myGroupBox gbDate;
        private myDate dtpTo;
        private System.Windows.Forms.Label label2;
        private myDate dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSelectDate;
        private SmallButton btnFind;
        private myText txtSearchField;
        private System.Windows.Forms.Label label3;
        private myDataGrid dgvJournalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJourDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJourNote;
        private MainButton btnClose;
        private MainButton btnOk;
    }
}
