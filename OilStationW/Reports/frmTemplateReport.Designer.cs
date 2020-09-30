namespace OilStationW.Reports
{
    partial class frmTemplateReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAccSheet = new MainButton();
            this.btnTrailBalance = new MainButton();
            this.btnClose = new MainButton();
            this.myDataGrid1 = new myDataGrid();
            this.btnExcel = new MainButton();
            this.btnNoCordinate = new MainButton();
            this.dtpTo = new myDate();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new myDate();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccSheet
            // 
            this.btnAccSheet.BackColor = System.Drawing.Color.Black;
            this.btnAccSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccSheet.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnAccSheet.FlatAppearance.BorderSize = 2;
            this.btnAccSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAccSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAccSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSheet.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAccSheet.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAccSheet.Location = new System.Drawing.Point(208, 525);
            this.btnAccSheet.Name = "btnAccSheet";
            this.btnAccSheet.Size = new System.Drawing.Size(99, 35);
            this.btnAccSheet.TabIndex = 7;
            this.btnAccSheet.Text = "كشف حساب";
            this.btnAccSheet.UseVisualStyleBackColor = false;
            // 
            // btnTrailBalance
            // 
            this.btnTrailBalance.BackColor = System.Drawing.Color.Black;
            this.btnTrailBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrailBalance.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnTrailBalance.FlatAppearance.BorderSize = 2;
            this.btnTrailBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnTrailBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnTrailBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrailBalance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnTrailBalance.ForeColor = System.Drawing.Color.Chocolate;
            this.btnTrailBalance.Location = new System.Drawing.Point(84, 525);
            this.btnTrailBalance.Name = "btnTrailBalance";
            this.btnTrailBalance.Size = new System.Drawing.Size(123, 35);
            this.btnTrailBalance.TabIndex = 8;
            this.btnTrailBalance.Text = "ميزان المراجعة";
            this.btnTrailBalance.UseVisualStyleBackColor = false;
            this.btnTrailBalance.Click += new System.EventHandler(this.btnTrailBalance_Click);
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
            this.btnClose.Location = new System.Drawing.Point(8, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.AllowUserToAddRows = false;
            this.myDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.myDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.myDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGrid1.EnableHeadersVisualStyles = false;
            this.myDataGrid1.Location = new System.Drawing.Point(8, 74);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.myDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.myDataGrid1.Size = new System.Drawing.Size(894, 427);
            this.myDataGrid1.TabIndex = 10;
            this.myDataGrid1.W_ClmName = "";
            this.myDataGrid1.W_PK = "";
            this.myDataGrid1.W_TableName = "";
            this.myDataGrid1.W_updValName = "";
            this.myDataGrid1.W_ValName = "";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Black;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnExcel.FlatAppearance.BorderSize = 2;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnExcel.ForeColor = System.Drawing.Color.Chocolate;
            this.btnExcel.Location = new System.Drawing.Point(12, 33);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(122, 35);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "فتح ملف اكسل";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnNoCordinate
            // 
            this.btnNoCordinate.BackColor = System.Drawing.Color.Black;
            this.btnNoCordinate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoCordinate.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnNoCordinate.FlatAppearance.BorderSize = 2;
            this.btnNoCordinate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnNoCordinate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnNoCordinate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoCordinate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnNoCordinate.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNoCordinate.Location = new System.Drawing.Point(155, 33);
            this.btnNoCordinate.Name = "btnNoCordinate";
            this.btnNoCordinate.Size = new System.Drawing.Size(122, 35);
            this.btnNoCordinate.TabIndex = 12;
            this.btnNoCordinate.Text = "تنسيق الارقام";
            this.btnNoCordinate.UseVisualStyleBackColor = false;
            this.btnNoCordinate.Click += new System.EventHandler(this.btnNoCordinate_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(670, 536);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowCheckBox = false;
            this.dtpTo.Size = new System.Drawing.Size(163, 26);
            this.dtpTo.TabIndex = 67;
            this.dtpTo.W_ColumnName = "";
            this.dtpTo.W_OldValue = "";
            this.dtpTo.w_Tran = myDate.Tran.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(842, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "إلى تاريخ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(670, 504);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = false;
            this.dtpFrom.Size = new System.Drawing.Size(163, 26);
            this.dtpFrom.TabIndex = 65;
            this.dtpFrom.W_ColumnName = "";
            this.dtpFrom.W_OldValue = "";
            this.dtpFrom.w_Tran = myDate.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(843, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "من تاريخ";
            // 
            // frmTemplateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(905, 568);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoCordinate);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.myDataGrid1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTrailBalance);
            this.Controls.Add(this.btnAccSheet);
            this.Name = "frmTemplateReport";
            this.Controls.SetChildIndex(this.btnAccSheet, 0);
            this.Controls.SetChildIndex(this.btnTrailBalance, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.myDataGrid1, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            this.Controls.SetChildIndex(this.btnNoCordinate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpFrom, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtpTo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainButton btnAccSheet;
        private MainButton btnTrailBalance;
        private MainButton btnClose;
        private myDataGrid myDataGrid1;
        private MainButton btnExcel;
        private MainButton btnNoCordinate;
        private myDate dtpTo;
        private System.Windows.Forms.Label label2;
        private myDate dtpFrom;
        private System.Windows.Forms.Label label1;
    }
}
