namespace OilStationW.Sales
{
    partial class frmFindSalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindSalesInvoice));
            this.dgvCustomers = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MainButton();
            this.btnOk = new MainButton();
            this.btnFind = new SmallButton();
            this.txtSearchField = new myText();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 30;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmInvoiceNo,
            this.clmEmpName,
            this.clmPumpName,
            this.clmValue,
            this.clmtNote});
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 64);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.Size = new System.Drawing.Size(612, 360);
            this.dgvCustomers.TabIndex = 86;
            this.dgvCustomers.W_ClmName = "";
            this.dgvCustomers.W_PK = "";
            this.dgvCustomers.W_TableName = "";
            this.dgvCustomers.W_updValName = "";
            this.dgvCustomers.W_ValName = "";
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmInvoiceNo
            // 
            this.clmInvoiceNo.HeaderText = "رقم الفاتورة";
            this.clmInvoiceNo.Name = "clmInvoiceNo";
            this.clmInvoiceNo.ReadOnly = true;
            // 
            // clmEmpName
            // 
            this.clmEmpName.HeaderText = "اسم العامل";
            this.clmEmpName.Name = "clmEmpName";
            this.clmEmpName.ReadOnly = true;
            this.clmEmpName.Width = 200;
            // 
            // clmPumpName
            // 
            this.clmPumpName.HeaderText = "الطرمبة";
            this.clmPumpName.Name = "clmPumpName";
            this.clmPumpName.ReadOnly = true;
            // 
            // clmValue
            // 
            this.clmValue.HeaderText = "المبلغ";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            // 
            // clmtNote
            // 
            this.clmtNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmtNote.HeaderText = "ملاحظات";
            this.clmtNote.Name = "clmtNote";
            this.clmtNote.ReadOnly = true;
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
            this.btnClose.Location = new System.Drawing.Point(3, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 85;
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
            this.btnOk.Location = new System.Drawing.Point(79, 430);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 84;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.btnFind.Location = new System.Drawing.Point(141, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 83;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchField.Location = new System.Drawing.Point(169, 32);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(249, 26);
            this.txtSearchField.TabIndex = 82;
            this.txtSearchField.W_ColumnName = "";
            this.txtSearchField.W_OldValue = "";
            this.txtSearchField.w_Tran = myText.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(427, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 81;
            this.label1.Text = "البحث";
            // 
            // frmFindSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(618, 472);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.label1);
            this.Name = "frmFindSalesInvoice";
            this.Text = "البحث عن فاتورة";
            this.Titel = "البحث عن فاتورة";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchField, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvCustomers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataGrid dgvCustomers;
        private MainButton btnClose;
        private MainButton btnOk;
        private SmallButton btnFind;
        private myText txtSearchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtNote;
    }
}
