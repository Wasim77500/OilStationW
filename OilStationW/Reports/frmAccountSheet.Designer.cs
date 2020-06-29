namespace OilStationW.Reports
{
    partial class frmAccountSheet
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
            this.ckbSelectDate = new System.Windows.Forms.CheckBox();
            this.gbDate = new myGroupBox();
            this.dtpTo = new myDate();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new myDate();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbPosting = new System.Windows.Forms.CheckBox();
            this.btnClose = new MainButton();
            this.btnPrint = new MainButton();
            this.gbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbSelectDate
            // 
            this.ckbSelectDate.AutoSize = true;
            this.ckbSelectDate.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbSelectDate.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbSelectDate.Location = new System.Drawing.Point(66, 77);
            this.ckbSelectDate.Name = "ckbSelectDate";
            this.ckbSelectDate.Size = new System.Drawing.Size(92, 26);
            this.ckbSelectDate.TabIndex = 69;
            this.ckbSelectDate.Text = "تحديد المدة";
            this.ckbSelectDate.UseVisualStyleBackColor = true;
            this.ckbSelectDate.CheckedChanged += new System.EventHandler(this.ckbSelectDate_CheckedChanged);
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
            this.gbDate.Location = new System.Drawing.Point(161, 32);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(241, 97);
            this.gbDate.TabIndex = 68;
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
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(5, 140);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(275, 26);
            this.lstAccName.TabIndex = 76;
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
            this.lstAccNo.Location = new System.Drawing.Point(282, 140);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(120, 26);
            this.lstAccNo.TabIndex = 75;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(406, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "رقم الحساب";
            // 
            // ckbPosting
            // 
            this.ckbPosting.AutoSize = true;
            this.ckbPosting.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbPosting.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbPosting.Location = new System.Drawing.Point(217, 172);
            this.ckbPosting.Name = "ckbPosting";
            this.ckbPosting.Size = new System.Drawing.Size(185, 26);
            this.ckbPosting.TabIndex = 77;
            this.ckbPosting.Text = "تضمين القيود الغير مرحلة";
            this.ckbPosting.UseVisualStyleBackColor = true;
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
            this.btnClose.Location = new System.Drawing.Point(165, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnPrint.Location = new System.Drawing.Point(241, 204);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 78;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmAccountSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(490, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ckbPosting);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbSelectDate);
            this.Controls.Add(this.gbDate);
            this.Name = "frmAccountSheet";
            this.Tag = "frmAccountSheet";
            this.Text = "كشف الحساب";
            this.Titel = "كشف الحساب";
            this.Load += new System.EventHandler(this.frmAccountSheet_Load);
            this.Controls.SetChildIndex(this.gbDate, 0);
            this.Controls.SetChildIndex(this.ckbSelectDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.ckbPosting, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbSelectDate;
        private myGroupBox gbDate;
        private myDate dtpTo;
        private System.Windows.Forms.Label label2;
        private myDate dtpFrom;
        private System.Windows.Forms.Label label1;
        private myList lstAccName;
        private myList lstAccNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbPosting;
        private MainButton btnClose;
        private MainButton btnPrint;
    }
}
