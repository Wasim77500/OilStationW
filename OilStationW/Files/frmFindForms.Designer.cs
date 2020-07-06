namespace OilStationW.Files
{
    partial class frmFindForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindForms));
            this.txtFormEn = new myText();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormAr = new myText();
            this.label49 = new System.Windows.Forms.Label();
            this.dgvForms = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new SmallButton();
            this.btnClose = new MainButton();
            this.btnOk = new MainButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFormEn
            // 
            this.txtFormEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormEn.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormEn.Location = new System.Drawing.Point(126, 69);
            this.txtFormEn.Name = "txtFormEn";
            this.txtFormEn.Size = new System.Drawing.Size(189, 23);
            this.txtFormEn.TabIndex = 33;
            this.txtFormEn.W_ColumnName = "";
            this.txtFormEn.W_OldValue = "";
            this.txtFormEn.w_Tran = myText.Tran.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(326, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "الشاشة في البرنامج";
            // 
            // txtFormAr
            // 
            this.txtFormAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormAr.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormAr.Location = new System.Drawing.Point(126, 43);
            this.txtFormAr.Name = "txtFormAr";
            this.txtFormAr.Size = new System.Drawing.Size(189, 23);
            this.txtFormAr.TabIndex = 31;
            this.txtFormAr.W_ColumnName = "";
            this.txtFormAr.W_OldValue = "";
            this.txtFormAr.w_Tran = myText.Tran.None;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(326, 44);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(103, 18);
            this.label49.TabIndex = 30;
            this.label49.Text = "اسم الشاشة(عربي)";
            // 
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvForms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForms.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvForms.ColumnHeadersHeight = 30;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmFormAr,
            this.clmFormEn});
            this.dgvForms.EnableHeadersVisualStyles = false;
            this.dgvForms.Location = new System.Drawing.Point(3, 98);
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvForms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvForms.Size = new System.Drawing.Size(530, 280);
            this.dgvForms.TabIndex = 51;
            this.dgvForms.W_ClmName = "";
            this.dgvForms.W_PK = "";
            this.dgvForms.W_TableName = "";
            this.dgvForms.W_updValName = "";
            this.dgvForms.W_ValName = "";
            this.dgvForms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForms_CellDoubleClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmFormAr
            // 
            this.clmFormAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFormAr.HeaderText = "اسم الشاشة بالعربي";
            this.clmFormAr.Name = "clmFormAr";
            this.clmFormAr.ReadOnly = true;
            // 
            // clmFormEn
            // 
            this.clmFormEn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFormEn.HeaderText = "الشاشة في البرنامج";
            this.clmFormEn.Name = "clmFormEn";
            this.clmFormEn.ReadOnly = true;
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
            this.btnFind.Location = new System.Drawing.Point(97, 42);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 52;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnClose.Location = new System.Drawing.Point(3, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
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
            this.btnOk.Location = new System.Drawing.Point(79, 384);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 53;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmFindForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(536, 425);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvForms);
            this.Controls.Add(this.txtFormEn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFormAr);
            this.Controls.Add(this.label49);
            this.Name = "frmFindForms";
            this.Text = "البحث عن نموذج";
            this.Titel = "البحث عن نموذج";
            this.Load += new System.EventHandler(this.frmFindForms_Load);
            this.Controls.SetChildIndex(this.label49, 0);
            this.Controls.SetChildIndex(this.txtFormAr, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtFormEn, 0);
            this.Controls.SetChildIndex(this.dgvForms, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText txtFormEn;
        private System.Windows.Forms.Label label3;
        private myText txtFormAr;
        private System.Windows.Forms.Label label49;
        private myDataGrid dgvForms;
        private SmallButton btnFind;
        private MainButton btnClose;
        private MainButton btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormEn;
    }
}
