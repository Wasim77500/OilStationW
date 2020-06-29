namespace OilStationW.Purchases
{
    partial class frmPurchaseExpensses
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
            this.label4 = new System.Windows.Forms.Label();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.txtExpName = new myText();
            this.lstCalcType = new myList();
            this.nmbExpValue = new myNumber();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.dgvExpensses = new myDataGrid();
            this.btnAdd = new SmallButton();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmExpPKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalcMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(525, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(510, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "اسم المصروف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(235, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "طريقة الحساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(236, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "المبلغ/النسبة";
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(8, 35);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(330, 26);
            this.lstAccName.TabIndex = 60;
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
            this.lstAccNo.Location = new System.Drawing.Point(340, 35);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(166, 26);
            this.lstAccNo.TabIndex = 59;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtExpName
            // 
            this.txtExpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtExpName.Location = new System.Drawing.Point(340, 64);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(166, 26);
            this.txtExpName.TabIndex = 61;
            this.txtExpName.W_ColumnName = "";
            this.txtExpName.W_OldValue = "";
            this.txtExpName.w_Tran = myText.Tran.None;
            // 
            // lstCalcType
            // 
            this.lstCalcType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCalcType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstCalcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCalcType.Font = new System.Drawing.Font("Arial", 12F);
            this.lstCalcType.FormattingEnabled = true;
            this.lstCalcType.Items.AddRange(new object[] {
            "مبلغ",
            "نسبة"});
            this.lstCalcType.Location = new System.Drawing.Point(87, 64);
            this.lstCalcType.Name = "lstCalcType";
            this.lstCalcType.Size = new System.Drawing.Size(143, 26);
            this.lstCalcType.TabIndex = 62;
            this.lstCalcType.W_ColumnName = "";
            this.lstCalcType.W_OldValue = "";
            this.lstCalcType.w_Tran = myList.Tran.None;
            this.lstCalcType.w_ValueType = myList.ValueType.TEXT;
            // 
            // nmbExpValue
            // 
            this.nmbExpValue.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbExpValue.Location = new System.Drawing.Point(87, 94);
            this.nmbExpValue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbExpValue.Name = "nmbExpValue";
            this.nmbExpValue.Size = new System.Drawing.Size(143, 26);
            this.nmbExpValue.TabIndex = 63;
            this.nmbExpValue.W_ColumnName = "";
            this.nmbExpValue.W_OldValue = "";
            this.nmbExpValue.w_Tran = myNumber.Tran.None;
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbAll.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbAll.Location = new System.Drawing.Point(513, 96);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(91, 26);
            this.ckbAll.TabIndex = 300;
            this.ckbAll.Text = "تحديد الكل";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // dgvExpensses
            // 
            this.dgvExpensses.AllowUserToAddRows = false;
            this.dgvExpensses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvExpensses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpensses.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpensses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpensses.ColumnHeadersHeight = 30;
            this.dgvExpensses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelect,
            this.clmExpPKid,
            this.clmAccId,
            this.clmAccNo,
            this.clmAccName,
            this.clmExpName,
            this.clmCalcMethod,
            this.clmExpValue});
            this.dgvExpensses.EnableHeadersVisualStyles = false;
            this.dgvExpensses.Location = new System.Drawing.Point(3, 125);
            this.dgvExpensses.Name = "dgvExpensses";
            this.dgvExpensses.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvExpensses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpensses.Size = new System.Drawing.Size(609, 322);
            this.dgvExpensses.TabIndex = 301;
            this.dgvExpensses.W_ClmName = "";
            this.dgvExpensses.W_PK = "";
            this.dgvExpensses.W_TableName = "";
            this.dgvExpensses.W_updValName = "";
            this.dgvExpensses.W_ValName = "";
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
            this.btnAdd.Location = new System.Drawing.Point(59, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 302;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clmSelect
            // 
            this.clmSelect.HeaderText = "تحديد";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.Width = 40;
            // 
            // clmExpPKid
            // 
            this.clmExpPKid.HeaderText = "رقم التصنيف";
            this.clmExpPKid.Name = "clmExpPKid";
            this.clmExpPKid.ReadOnly = true;
            this.clmExpPKid.Visible = false;
            // 
            // clmAccId
            // 
            this.clmAccId.HeaderText = "رقم تعريف  الحساب";
            this.clmAccId.Name = "clmAccId";
            this.clmAccId.ReadOnly = true;
            this.clmAccId.Visible = false;
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
            // clmExpName
            // 
            this.clmExpName.HeaderText = "اسم المصروف";
            this.clmExpName.Name = "clmExpName";
            this.clmExpName.ReadOnly = true;
            // 
            // clmCalcMethod
            // 
            this.clmCalcMethod.HeaderText = "طريقة الحساب";
            this.clmCalcMethod.Name = "clmCalcMethod";
            this.clmCalcMethod.ReadOnly = true;
            this.clmCalcMethod.Width = 90;
            // 
            // clmExpValue
            // 
            this.clmExpValue.HeaderText = "المبلغ";
            this.clmExpValue.Name = "clmExpValue";
            this.clmExpValue.ReadOnly = true;
            this.clmExpValue.Width = 70;
            // 
            // frmPurchaseExpensses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvExpensses);
            this.Controls.Add(this.ckbAll);
            this.Controls.Add(this.nmbExpValue);
            this.Controls.Add(this.lstCalcType);
            this.Controls.Add(this.txtExpName);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseExpensses";
            this.Tag = "frmPurchaseExpensses";
            this.Text = "مصاريف المشتريات";
            this.Titel = "مصاريف المشتريات";
            this.Load += new System.EventHandler(this.frmPurchaseExpensses_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtExpName, 0);
            this.Controls.SetChildIndex(this.lstCalcType, 0);
            this.Controls.SetChildIndex(this.nmbExpValue, 0);
            this.Controls.SetChildIndex(this.ckbAll, 0);
            this.Controls.SetChildIndex(this.dgvExpensses, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbExpValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private myList lstAccName;
        private myList lstAccNo;
        private myText txtExpName;
        private myList lstCalcType;
        private myNumber nmbExpValue;
        private System.Windows.Forms.CheckBox ckbAll;
        private SmallButton btnAdd;
        public myDataGrid dgvExpensses;
        public System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmExpPKid;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmAccId;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmAccNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmAccName;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmExpName;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmCalcMethod;
        public System.Windows.Forms.DataGridViewTextBoxColumn clmExpValue;
    }
}
