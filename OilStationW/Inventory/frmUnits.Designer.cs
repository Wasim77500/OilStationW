namespace OilStationW.Inventory
{
    partial class frmUnits
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbIsMainUnit = new System.Windows.Forms.CheckBox();
            this.ckbIsPurchaseUnit = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstStandardUnit = new myList();
            this.txtUnitName = new myText();
            this.nmbUnitValue = new myNumber();
            this.txtUnitNote = new myText();
            this.dgvUnits = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsMainCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsPurchaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new SmallButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(273, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "الوحدة القياسية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(278, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "قيمة الوحدة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(279, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "اسم الوحدة";
            // 
            // ckbIsMainUnit
            // 
            this.ckbIsMainUnit.AutoSize = true;
            this.ckbIsMainUnit.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbIsMainUnit.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbIsMainUnit.Location = new System.Drawing.Point(108, 123);
            this.ckbIsMainUnit.Name = "ckbIsMainUnit";
            this.ckbIsMainUnit.Size = new System.Drawing.Size(155, 26);
            this.ckbIsMainUnit.TabIndex = 67;
            this.ckbIsMainUnit.Text = "وحدة القياس الرئيسية";
            this.ckbIsMainUnit.UseVisualStyleBackColor = true;
            // 
            // ckbIsPurchaseUnit
            // 
            this.ckbIsPurchaseUnit.AutoSize = true;
            this.ckbIsPurchaseUnit.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbIsPurchaseUnit.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbIsPurchaseUnit.Location = new System.Drawing.Point(161, 151);
            this.ckbIsPurchaseUnit.Name = "ckbIsPurchaseUnit";
            this.ckbIsPurchaseUnit.Size = new System.Drawing.Size(102, 26);
            this.ckbIsPurchaseUnit.TabIndex = 68;
            this.ckbIsPurchaseUnit.Text = "وحدة الشراء";
            this.ckbIsPurchaseUnit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(279, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "مـلاحـظـات";
            // 
            // lstStandardUnit
            // 
            this.lstStandardUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstStandardUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstStandardUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.lstStandardUnit.FormattingEnabled = true;
            this.lstStandardUnit.Location = new System.Drawing.Point(66, 32);
            this.lstStandardUnit.Name = "lstStandardUnit";
            this.lstStandardUnit.Size = new System.Drawing.Size(197, 26);
            this.lstStandardUnit.TabIndex = 70;
            this.lstStandardUnit.W_ColumnName = "";
            this.lstStandardUnit.W_OldValue = "";
            this.lstStandardUnit.w_Tran = myList.Tran.None;
            this.lstStandardUnit.w_ValueType = myList.ValueType.TEXT;
            this.lstStandardUnit.SelectedIndexChanged += new System.EventHandler(this.lstStandardUnit_SelectedIndexChanged);
            // 
            // txtUnitName
            // 
            this.txtUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUnitName.Location = new System.Drawing.Point(66, 61);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(197, 26);
            this.txtUnitName.TabIndex = 71;
            this.txtUnitName.W_ColumnName = "";
            this.txtUnitName.W_OldValue = "";
            this.txtUnitName.w_Tran = myText.Tran.None;
            // 
            // nmbUnitValue
            // 
            this.nmbUnitValue.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbUnitValue.Location = new System.Drawing.Point(66, 91);
            this.nmbUnitValue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbUnitValue.Name = "nmbUnitValue";
            this.nmbUnitValue.Size = new System.Drawing.Size(197, 26);
            this.nmbUnitValue.TabIndex = 72;
            this.nmbUnitValue.W_ColumnName = "";
            this.nmbUnitValue.W_OldValue = "";
            this.nmbUnitValue.w_Tran = myNumber.Tran.None;
            // 
            // txtUnitNote
            // 
            this.txtUnitNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUnitNote.Location = new System.Drawing.Point(66, 180);
            this.txtUnitNote.Name = "txtUnitNote";
            this.txtUnitNote.Size = new System.Drawing.Size(197, 26);
            this.txtUnitNote.TabIndex = 73;
            this.txtUnitNote.W_ColumnName = "";
            this.txtUnitNote.W_OldValue = "";
            this.txtUnitNote.w_Tran = myText.Tran.None;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnits.ColumnHeadersHeight = 30;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmUnitName,
            this.clmUnitValue,
            this.clmUnitNote,
            this.clmIsMainCurr,
            this.clmIsPurchaseUnit,
            this.clmDelete});
            this.dgvUnits.EnableHeadersVisualStyles = false;
            this.dgvUnits.Location = new System.Drawing.Point(3, 209);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvUnits.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnits.Size = new System.Drawing.Size(505, 250);
            this.dgvUnits.TabIndex = 93;
            this.dgvUnits.W_ClmName = "";
            this.dgvUnits.W_PK = "";
            this.dgvUnits.W_TableName = "";
            this.dgvUnits.W_updValName = "";
            this.dgvUnits.W_ValName = "";
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmUnitName
            // 
            this.clmUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUnitName.HeaderText = "اسم الوحدة";
            this.clmUnitName.Name = "clmUnitName";
            this.clmUnitName.ReadOnly = true;
            // 
            // clmUnitValue
            // 
            this.clmUnitValue.HeaderText = "قيمة الوحدة";
            this.clmUnitValue.Name = "clmUnitValue";
            this.clmUnitValue.ReadOnly = true;
            // 
            // clmUnitNote
            // 
            this.clmUnitNote.HeaderText = "ملاحظات";
            this.clmUnitNote.Name = "clmUnitNote";
            this.clmUnitNote.ReadOnly = true;
            this.clmUnitNote.Width = 150;
            // 
            // clmIsMainCurr
            // 
            this.clmIsMainCurr.HeaderText = "وحدة رئيسية";
            this.clmIsMainCurr.Name = "clmIsMainCurr";
            this.clmIsMainCurr.ReadOnly = true;
            this.clmIsMainCurr.Width = 80;
            // 
            // clmIsPurchaseUnit
            // 
            this.clmIsPurchaseUnit.HeaderText = "وحدة شراء";
            this.clmIsPurchaseUnit.Name = "clmIsPurchaseUnit";
            this.clmIsPurchaseUnit.ReadOnly = true;
            this.clmIsPurchaseUnit.Visible = false;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Image = global::OilStationW.Properties.Resources.Delete16;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
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
            this.btnAdd.Location = new System.Drawing.Point(38, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 94;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(514, 462);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.txtUnitNote);
            this.Controls.Add(this.nmbUnitValue);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.lstStandardUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbIsPurchaseUnit);
            this.Controls.Add(this.ckbIsMainUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUnits";
            this.Tag = "frmUnits";
            this.Text = "تعريف الوحدات";
            this.Titel = "تعريف الوحدات";
            this.Load += new System.EventHandler(this.frmUnits_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ckbIsMainUnit, 0);
            this.Controls.SetChildIndex(this.ckbIsPurchaseUnit, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lstStandardUnit, 0);
            this.Controls.SetChildIndex(this.txtUnitName, 0);
            this.Controls.SetChildIndex(this.nmbUnitValue, 0);
            this.Controls.SetChildIndex(this.txtUnitNote, 0);
            this.Controls.SetChildIndex(this.dgvUnits, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbUnitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbIsMainUnit;
        private System.Windows.Forms.CheckBox ckbIsPurchaseUnit;
        private System.Windows.Forms.Label label4;
        private myList lstStandardUnit;
        private myText txtUnitName;
        private myNumber nmbUnitValue;
        private myText txtUnitNote;
        private myDataGrid dgvUnits;
        private SmallButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsMainCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsPurchaseUnit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}
