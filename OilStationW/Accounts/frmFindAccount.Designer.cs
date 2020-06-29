namespace OilStationW.Accounts
{
    partial class frmFindAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new SmallButton();
            this.txtSearchField = new myText();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJournalData = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MainButton();
            this.btnOk = new MainButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).BeginInit();
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
            this.btnFind.Location = new System.Drawing.Point(30, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 56;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchField.Location = new System.Drawing.Point(58, 32);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(249, 26);
            this.txtSearchField.TabIndex = 55;
            this.txtSearchField.W_ColumnName = "";
            this.txtSearchField.W_OldValue = "";
            this.txtSearchField.w_Tran = myText.Tran.None;
            this.txtSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchField_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "البحث";
            // 
            // dgvJournalData
            // 
            this.dgvJournalData.AllowUserToAddRows = false;
            this.dgvJournalData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvJournalData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJournalData.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournalData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJournalData.ColumnHeadersHeight = 30;
            this.dgvJournalData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmAccNo,
            this.clmAccName});
            this.dgvJournalData.EnableHeadersVisualStyles = false;
            this.dgvJournalData.Location = new System.Drawing.Point(3, 60);
            this.dgvJournalData.Name = "dgvJournalData";
            this.dgvJournalData.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvJournalData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJournalData.Size = new System.Drawing.Size(393, 446);
            this.dgvJournalData.TabIndex = 57;
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
            // clmAccNo
            // 
            this.clmAccNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAccNo.FillWeight = 50F;
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
            this.btnClose.Location = new System.Drawing.Point(3, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 59;
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
            this.btnOk.Location = new System.Drawing.Point(79, 509);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 58;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmFindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvJournalData);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.label1);
            this.Name = "frmFindAccount";
            this.Text = "البحث عن حساب";
            this.Titel = "البحث عن حساب";
            this.Load += new System.EventHandler(this.frmFindAccount_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchField, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.dgvJournalData, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmallButton btnFind;
        private myText txtSearchField;
        private System.Windows.Forms.Label label1;
        private myDataGrid dgvJournalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        private MainButton btnClose;
        private MainButton btnOk;
    }
}
