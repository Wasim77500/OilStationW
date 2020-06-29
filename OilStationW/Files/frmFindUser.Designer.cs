namespace OilStationW.Files
{
    partial class frmFindUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new SmallButton();
            this.txtSearchField = new myText();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new MainButton();
            this.btnClose = new MainButton();
            this.dgvUser = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(69, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 46;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearchField.Location = new System.Drawing.Point(97, 32);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(249, 26);
            this.txtSearchField.TabIndex = 45;
            this.txtSearchField.W_ColumnName = "";
            this.txtSearchField.W_OldValue = "";
            this.txtSearchField.w_Tran = myText.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(355, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "البحث";
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
            this.btnOk.Location = new System.Drawing.Point(79, 350);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 48;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.btnClose.Location = new System.Drawing.Point(3, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmUserName,
            this.clmLoginName});
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(3, 64);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.Size = new System.Drawing.Size(439, 280);
            this.dgvUser.TabIndex = 50;
            this.dgvUser.W_ClmName = "";
            this.dgvUser.W_PK = "";
            this.dgvUser.W_TableName = "";
            this.dgvUser.W_updValName = "";
            this.dgvUser.W_ValName = "";
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmUserName
            // 
            this.clmUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUserName.HeaderText = "اسم المستخدم";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmLoginName
            // 
            this.clmLoginName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLoginName.HeaderText = "اسم الدخول";
            this.clmLoginName.Name = "clmLoginName";
            this.clmLoginName.ReadOnly = true;
            // 
            // frmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 389);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.label1);
            this.Name = "frmFindUser";
            this.Text = "البحث عن المستخدمين";
            this.Titel = "البحث عن المستخدمين";
            this.Load += new System.EventHandler(this.frmFindUser_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchField, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmallButton btnFind;
        private myText txtSearchField;
        private System.Windows.Forms.Label label1;
        private MainButton btnOk;
        private MainButton btnClose;
        private myDataGrid dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoginName;
    }
}
