namespace OilStationW.Purchases
{
    partial class frmFindPurchaseInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPurchaseInvoice));
            this.dgvJournalData = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MainButton();
            this.btnOk = new MainButton();
            this.btnFind = new SmallButton();
            this.txtSearchField = new myText();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).BeginInit();
            this.SuspendLayout();
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
            this.clmPkid,
            this.clmInvoiceNo,
            this.clmWarehouseName,
            this.clmAccNo,
            this.clmAccName,
            this.clmNote});
            this.dgvJournalData.EnableHeadersVisualStyles = false;
            this.dgvJournalData.Location = new System.Drawing.Point(4, 64);
            this.dgvJournalData.Name = "dgvJournalData";
            this.dgvJournalData.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvJournalData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJournalData.Size = new System.Drawing.Size(612, 360);
            this.dgvJournalData.TabIndex = 68;
            this.dgvJournalData.W_ClmName = "";
            this.dgvJournalData.W_PK = "";
            this.dgvJournalData.W_TableName = "";
            this.dgvJournalData.W_updValName = "";
            this.dgvJournalData.W_ValName = "";
            this.dgvJournalData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalData_CellDoubleClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmInvoiceNo
            // 
            this.clmInvoiceNo.HeaderText = "رقم الفاتورة";
            this.clmInvoiceNo.Name = "clmInvoiceNo";
            this.clmInvoiceNo.ReadOnly = true;
            // 
            // clmWarehouseName
            // 
            this.clmWarehouseName.HeaderText = "اسم المخزن";
            this.clmWarehouseName.Name = "clmWarehouseName";
            this.clmWarehouseName.ReadOnly = true;
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
            // clmNote
            // 
            this.clmNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNote.HeaderText = "ملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
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
            this.btnClose.Location = new System.Drawing.Point(4, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 67;
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
            this.btnOk.Location = new System.Drawing.Point(80, 430);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 66;
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
            this.btnFind.Location = new System.Drawing.Point(142, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 65;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchField.Location = new System.Drawing.Point(170, 32);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(249, 26);
            this.txtSearchField.TabIndex = 64;
            this.txtSearchField.W_ColumnName = "";
            this.txtSearchField.W_OldValue = "";
            this.txtSearchField.w_Tran = myText.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(428, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "البحث";
            // 
            // frmFindPurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(619, 469);
            this.Controls.Add(this.dgvJournalData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.label1);
            this.Name = "frmFindPurchaseInvoice";
            this.Text = "البحث عن فاتورة شراء";
            this.Titel = "البحث عن فاتورة شراء";
            this.Load += new System.EventHandler(this.frmFindPurchaseInvoice_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchField, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvJournalData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataGrid dgvJournalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private MainButton btnClose;
        private MainButton btnOk;
        private SmallButton btnFind;
        private myText txtSearchField;
        private System.Windows.Forms.Label label1;
    }
}
