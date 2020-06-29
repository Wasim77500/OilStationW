namespace OilStationW.Purchases
{
    partial class frmPurchaseDocuments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myGroupBox1 = new myGroupBox();
            this.rbImageFile = new System.Windows.Forms.RadioButton();
            this.rbScanner = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtImgDescription = new myText();
            this.btnAdd = new SmallButton();
            this.dgvDocumnets = new myDataGrid();
            this.clmPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImageDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmShowImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.myGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumnets)).BeginInit();
            this.SuspendLayout();
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.rbImageFile);
            this.myGroupBox1.Controls.Add(this.rbScanner);
            this.myGroupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.myGroupBox1.Location = new System.Drawing.Point(174, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(180, 90);
            this.myGroupBox1.TabIndex = 65;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "طريقة إدخال الصورة";
            this.myGroupBox1.W_FormArabicName = null;
            this.myGroupBox1.W_Pk = null;
            this.myGroupBox1.W_TableName = null;
            this.myGroupBox1.Enter += new System.EventHandler(this.myGroupBox1_Enter);
            // 
            // rbImageFile
            // 
            this.rbImageFile.AutoSize = true;
            this.rbImageFile.ForeColor = System.Drawing.Color.Black;
            this.rbImageFile.Location = new System.Drawing.Point(87, 55);
            this.rbImageFile.Name = "rbImageFile";
            this.rbImageFile.Size = new System.Drawing.Size(77, 26);
            this.rbImageFile.TabIndex = 1;
            this.rbImageFile.Text = "من ملف";
            this.rbImageFile.UseVisualStyleBackColor = true;
            // 
            // rbScanner
            // 
            this.rbScanner.AutoSize = true;
            this.rbScanner.Checked = true;
            this.rbScanner.ForeColor = System.Drawing.Color.Black;
            this.rbScanner.Location = new System.Drawing.Point(8, 28);
            this.rbScanner.Name = "rbScanner";
            this.rbScanner.Size = new System.Drawing.Size(156, 26);
            this.rbScanner.TabIndex = 0;
            this.rbScanner.TabStop = true;
            this.rbScanner.Text = "من الماسحة الضوئية";
            this.rbScanner.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "وصف الصورة";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tan;
            this.pictureBox3.Location = new System.Drawing.Point(12, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // txtImgDescription
            // 
            this.txtImgDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImgDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.txtImgDescription.Location = new System.Drawing.Point(46, 132);
            this.txtImgDescription.Name = "txtImgDescription";
            this.txtImgDescription.Size = new System.Drawing.Size(199, 26);
            this.txtImgDescription.TabIndex = 67;
            this.txtImgDescription.W_ColumnName = "";
            this.txtImgDescription.W_OldValue = "";
            this.txtImgDescription.w_Tran = myText.Tran.None;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::OilStationW.Properties.Resources.Add_h;
            this.btnAdd.Location = new System.Drawing.Point(14, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDocumnets
            // 
            this.dgvDocumnets.AllowUserToAddRows = false;
            this.dgvDocumnets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvDocumnets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumnets.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumnets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumnets.ColumnHeadersHeight = 30;
            this.dgvDocumnets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPKid,
            this.clmImageDescription,
            this.clmImage,
            this.clmShowImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumnets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumnets.EnableHeadersVisualStyles = false;
            this.dgvDocumnets.Location = new System.Drawing.Point(3, 164);
            this.dgvDocumnets.Name = "dgvDocumnets";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumnets.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocumnets.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvDocumnets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDocumnets.Size = new System.Drawing.Size(354, 192);
            this.dgvDocumnets.TabIndex = 69;
            this.dgvDocumnets.W_ClmName = "";
            this.dgvDocumnets.W_PK = "";
            this.dgvDocumnets.W_TableName = "";
            this.dgvDocumnets.W_updValName = "";
            this.dgvDocumnets.W_ValName = "";
            this.dgvDocumnets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumnets_CellClick);
            // 
            // clmPKid
            // 
            this.clmPKid.HeaderText = "رقم التصنيف";
            this.clmPKid.Name = "clmPKid";
            this.clmPKid.ReadOnly = true;
            this.clmPKid.Visible = false;
            // 
            // clmImageDescription
            // 
            this.clmImageDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmImageDescription.FillWeight = 50F;
            this.clmImageDescription.HeaderText = "وصف الصورة";
            this.clmImageDescription.Name = "clmImageDescription";
            this.clmImageDescription.ReadOnly = true;
            // 
            // clmImage
            // 
            this.clmImage.HeaderText = "الصورة كسلسلة نصية";
            this.clmImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmImage.Name = "clmImage";
            this.clmImage.ReadOnly = true;
            this.clmImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmImage.Visible = false;
            // 
            // clmShowImage
            // 
            this.clmShowImage.HeaderText = "عرض";
            this.clmShowImage.Image = global::OilStationW.Properties.Resources.Open16;
            this.clmShowImage.Name = "clmShowImage";
            this.clmShowImage.ReadOnly = true;
            this.clmShowImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmShowImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmShowImage.Width = 60;
            // 
            // frmPurchaseDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(360, 359);
            this.Controls.Add(this.dgvDocumnets);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtImgDescription);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseDocuments";
            this.Tag = "frmPurchaseDocuments";
            this.Text = "إدخال المستندات";
            this.Titel = "إدخال المستندات";
            this.Load += new System.EventHandler(this.frmPurchaseDocuments_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.myGroupBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.txtImgDescription, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dgvDocumnets, 0);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumnets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myGroupBox myGroupBox1;
        private System.Windows.Forms.RadioButton rbImageFile;
        private System.Windows.Forms.RadioButton rbScanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private myText txtImgDescription;
        private SmallButton btnAdd;
        private myDataGrid dgvDocumnets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImageDescription;
        private System.Windows.Forms.DataGridViewImageColumn clmImage;
        private System.Windows.Forms.DataGridViewImageColumn clmShowImage;
    }
}
