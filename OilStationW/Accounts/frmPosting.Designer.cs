namespace OilStationW.Accounts
{
    partial class frmPosting
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOperatoin = new myList();
            this.txtOperationNo = new myText();
            this.ckbSelectDate = new System.Windows.Forms.CheckBox();
            this.gbDate = new myGroupBox();
            this.dtpTo = new myDate();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new myDate();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.btnClose = new MainButton();
            this.btnFind = new MainButton();
            this.dgvEntries = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJurNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJurType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJurDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPosting = new MainButton();
            this.gbDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(631, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 293;
            this.label2.Text = "نوع العملية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(632, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 294;
            this.label1.Text = "رقم العملية";
            // 
            // lstOperatoin
            // 
            this.lstOperatoin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstOperatoin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstOperatoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOperatoin.Font = new System.Drawing.Font("Arial", 12F);
            this.lstOperatoin.FormattingEnabled = true;
            this.lstOperatoin.Location = new System.Drawing.Point(407, 33);
            this.lstOperatoin.Name = "lstOperatoin";
            this.lstOperatoin.Size = new System.Drawing.Size(221, 26);
            this.lstOperatoin.TabIndex = 295;
            this.lstOperatoin.W_ColumnName = "";
            this.lstOperatoin.W_OldValue = "";
            this.lstOperatoin.w_Tran = myList.Tran.None;
            this.lstOperatoin.w_ValueType = myList.ValueType.TEXT;
            this.lstOperatoin.SelectedIndexChanged += new System.EventHandler(this.lstOperatoin_SelectedIndexChanged);
            // 
            // txtOperationNo
            // 
            this.txtOperationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOperationNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOperationNo.Location = new System.Drawing.Point(407, 65);
            this.txtOperationNo.Name = "txtOperationNo";
            this.txtOperationNo.Size = new System.Drawing.Size(221, 26);
            this.txtOperationNo.TabIndex = 296;
            this.txtOperationNo.W_ColumnName = "";
            this.txtOperationNo.W_OldValue = "";
            this.txtOperationNo.w_Tran = myText.Tran.None;
            // 
            // ckbSelectDate
            // 
            this.ckbSelectDate.AutoSize = true;
            this.ckbSelectDate.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbSelectDate.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbSelectDate.Location = new System.Drawing.Point(407, 139);
            this.ckbSelectDate.Name = "ckbSelectDate";
            this.ckbSelectDate.Size = new System.Drawing.Size(92, 26);
            this.ckbSelectDate.TabIndex = 298;
            this.ckbSelectDate.Text = "تحديد المدة";
            this.ckbSelectDate.UseVisualStyleBackColor = true;
            this.ckbSelectDate.CheckedChanged += new System.EventHandler(this.ckbSelectDate_CheckedChanged);
            // 
            // gbDate
            // 
            this.gbDate.BackColor = System.Drawing.Color.Transparent;
            this.gbDate.Controls.Add(this.dtpTo);
            this.gbDate.Controls.Add(this.label3);
            this.gbDate.Controls.Add(this.dtpFrom);
            this.gbDate.Controls.Add(this.label4);
            this.gbDate.Enabled = false;
            this.gbDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDate.ForeColor = System.Drawing.Color.Chocolate;
            this.gbDate.Location = new System.Drawing.Point(503, 94);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(198, 97);
            this.gbDate.TabIndex = 297;
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
            this.dtpTo.Size = new System.Drawing.Size(126, 26);
            this.dtpTo.TabIndex = 63;
            this.dtpTo.W_ColumnName = "";
            this.dtpTo.W_OldValue = "";
            this.dtpTo.w_Tran = myDate.Tran.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "إلى تاريخ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(6, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = false;
            this.dtpFrom.Size = new System.Drawing.Size(126, 26);
            this.dtpFrom.TabIndex = 61;
            this.dtpFrom.W_ColumnName = "";
            this.dtpFrom.W_OldValue = "";
            this.dtpFrom.w_Tran = myDate.Tran.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(140, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "من تاريخ";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbAll.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbAll.Location = new System.Drawing.Point(294, 43);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(91, 26);
            this.ckbAll.TabIndex = 299;
            this.ckbAll.Text = "تحديد الكل";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
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
            this.btnClose.Location = new System.Drawing.Point(529, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 301;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Black;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnFind.ForeColor = System.Drawing.Color.Chocolate;
            this.btnFind.Location = new System.Drawing.Point(605, 197);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 35);
            this.btnFind.TabIndex = 300;
            this.btnFind.Text = "عرض";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntries.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntries.ColumnHeadersHeight = 30;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmJurNo,
            this.clmJurType,
            this.clmJurDate,
            this.clmSelect});
            this.dgvEntries.EnableHeadersVisualStyles = false;
            this.dgvEntries.Location = new System.Drawing.Point(3, 72);
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvEntries.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntries.Size = new System.Drawing.Size(382, 399);
            this.dgvEntries.TabIndex = 302;
            this.dgvEntries.W_ClmName = "";
            this.dgvEntries.W_PK = "";
            this.dgvEntries.W_TableName = "";
            this.dgvEntries.W_updValName = "";
            this.dgvEntries.W_ValName = "";
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmJurNo
            // 
            this.clmJurNo.FillWeight = 50F;
            this.clmJurNo.HeaderText = "الرقم";
            this.clmJurNo.Name = "clmJurNo";
            this.clmJurNo.ReadOnly = true;
            this.clmJurNo.Width = 126;
            // 
            // clmJurType
            // 
            this.clmJurType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmJurType.HeaderText = "النوع";
            this.clmJurType.Name = "clmJurType";
            this.clmJurType.ReadOnly = true;
            // 
            // clmJurDate
            // 
            this.clmJurDate.HeaderText = "التاريخ";
            this.clmJurDate.Name = "clmJurDate";
            this.clmJurDate.ReadOnly = true;
            // 
            // clmSelect
            // 
            this.clmSelect.HeaderText = "تحديد";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.Width = 50;
            // 
            // btnPosting
            // 
            this.btnPosting.BackColor = System.Drawing.Color.Black;
            this.btnPosting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosting.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnPosting.FlatAppearance.BorderSize = 2;
            this.btnPosting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnPosting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPosting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosting.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnPosting.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPosting.Location = new System.Drawing.Point(3, 35);
            this.btnPosting.Name = "btnPosting";
            this.btnPosting.Size = new System.Drawing.Size(75, 35);
            this.btnPosting.TabIndex = 303;
            this.btnPosting.Text = "ترحيل";
            this.btnPosting.UseVisualStyleBackColor = false;
            this.btnPosting.Click += new System.EventHandler(this.btnPosting_Click);
            // 
            // frmPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 476);
            this.Controls.Add(this.btnPosting);
            this.Controls.Add(this.dgvEntries);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ckbAll);
            this.Controls.Add(this.ckbSelectDate);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.txtOperationNo);
            this.Controls.Add(this.lstOperatoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmPosting";
            this.Tag = "frmPosting";
            this.Text = "ترحيل القيود";
            this.Titel = "ترحيل القيود";
            this.Load += new System.EventHandler(this.frmPosting_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lstOperatoin, 0);
            this.Controls.SetChildIndex(this.txtOperationNo, 0);
            this.Controls.SetChildIndex(this.gbDate, 0);
            this.Controls.SetChildIndex(this.ckbSelectDate, 0);
            this.Controls.SetChildIndex(this.ckbAll, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvEntries, 0);
            this.Controls.SetChildIndex(this.btnPosting, 0);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private myList lstOperatoin;
        private myText txtOperationNo;
        private System.Windows.Forms.CheckBox ckbSelectDate;
        private myGroupBox gbDate;
        private myDate dtpTo;
        private System.Windows.Forms.Label label3;
        private myDate dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbAll;
        private MainButton btnClose;
        private MainButton btnFind;
        private myDataGrid dgvEntries;
        private MainButton btnPosting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJurNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJurType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJurDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
    }
}
