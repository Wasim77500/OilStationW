namespace OilStationW.Inventory
{
    partial class frmPumpToEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPumpToEmp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new SmallButton();
            this.lstEmp = new myList();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWorkingDate = new myDate();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPumps = new myList();
            this.btnAdd = new SmallButton();
            this.dgvEmpPump = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPumpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpPump)).BeginInit();
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
            this.btnFind.Location = new System.Drawing.Point(180, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 86;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstEmp
            // 
            this.lstEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmp.Font = new System.Drawing.Font("Arial", 12F);
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.Location = new System.Drawing.Point(257, 77);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(205, 26);
            this.lstEmp.TabIndex = 85;
            this.lstEmp.W_ColumnName = "";
            this.lstEmp.W_OldValue = "";
            this.lstEmp.w_Tran = myList.Tran.None;
            this.lstEmp.w_ValueType = myList.ValueType.TEXT;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(352, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 84;
            this.label1.Text = "التاريخ";
            // 
            // dtpWorkingDate
            // 
            this.dtpWorkingDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWorkingDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpWorkingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkingDate.Location = new System.Drawing.Point(209, 45);
            this.dtpWorkingDate.Name = "dtpWorkingDate";
            this.dtpWorkingDate.ShowCheckBox = false;
            this.dtpWorkingDate.Size = new System.Drawing.Size(137, 26);
            this.dtpWorkingDate.TabIndex = 87;
            this.dtpWorkingDate.W_ColumnName = "";
            this.dtpWorkingDate.W_OldValue = "";
            this.dtpWorkingDate.w_Tran = myDate.Tran.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(465, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 88;
            this.label2.Text = "اسم العامل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(194, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 90;
            this.label3.Text = "الطرمبة";
            // 
            // lstPumps
            // 
            this.lstPumps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPumps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPumps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPumps.Font = new System.Drawing.Font("Arial", 12F);
            this.lstPumps.FormattingEnabled = true;
            this.lstPumps.Location = new System.Drawing.Point(33, 77);
            this.lstPumps.Name = "lstPumps";
            this.lstPumps.Size = new System.Drawing.Size(155, 26);
            this.lstPumps.TabIndex = 89;
            this.lstPumps.W_ColumnName = "";
            this.lstPumps.W_OldValue = "";
            this.lstPumps.w_Tran = myList.Tran.None;
            this.lstPumps.w_ValueType = myList.ValueType.TEXT;
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
            this.btnAdd.Location = new System.Drawing.Point(4, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 91;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmpPump
            // 
            this.dgvEmpPump.AllowUserToAddRows = false;
            this.dgvEmpPump.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvEmpPump.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpPump.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpPump.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpPump.ColumnHeadersHeight = 30;
            this.dgvEmpPump.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmEmpId,
            this.clmEmpName,
            this.clmPumpId,
            this.clmPumpName,
            this.clmDelete});
            this.dgvEmpPump.EnableHeadersVisualStyles = false;
            this.dgvEmpPump.Location = new System.Drawing.Point(3, 109);
            this.dgvEmpPump.Name = "dgvEmpPump";
            this.dgvEmpPump.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvEmpPump.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpPump.Size = new System.Drawing.Size(533, 331);
            this.dgvEmpPump.TabIndex = 92;
            this.dgvEmpPump.W_ClmName = "";
            this.dgvEmpPump.W_PK = "";
            this.dgvEmpPump.W_TableName = "";
            this.dgvEmpPump.W_updValName = "";
            this.dgvEmpPump.W_ValName = "";
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmEmpId
            // 
            this.clmEmpId.HeaderText = "empPkid";
            this.clmEmpId.Name = "clmEmpId";
            this.clmEmpId.ReadOnly = true;
            this.clmEmpId.Visible = false;
            // 
            // clmEmpName
            // 
            this.clmEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEmpName.HeaderText = "اسم العامل";
            this.clmEmpName.Name = "clmEmpName";
            this.clmEmpName.ReadOnly = true;
            // 
            // clmPumpId
            // 
            this.clmPumpId.HeaderText = "pumpPkid";
            this.clmPumpId.Name = "clmPumpId";
            this.clmPumpId.ReadOnly = true;
            this.clmPumpId.Visible = false;
            // 
            // clmPumpName
            // 
            this.clmPumpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPumpName.HeaderText = "اسم الطرمبة";
            this.clmPumpName.Name = "clmPumpName";
            this.clmPumpName.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::OilStationW.Properties.Resources.Delete16;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // frmPumpToEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 443);
            this.Controls.Add(this.dgvEmpPump);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPumps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpWorkingDate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.label1);
            this.Name = "frmPumpToEmp";
            this.Tag = "frmPumpToEmp";
            this.Text = "اسناد الطرمبة";
            this.Titel = "اسناد الطرمبة";
            this.Load += new System.EventHandler(this.frmPumpToEmp_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lstEmp, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.dtpWorkingDate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lstPumps, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dgvEmpPump, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpPump)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmallButton btnFind;
        private myList lstEmp;
        private System.Windows.Forms.Label label1;
        private myDate dtpWorkingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private myList lstPumps;
        private SmallButton btnAdd;
        private myDataGrid dgvEmpPump;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPumpName;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}
