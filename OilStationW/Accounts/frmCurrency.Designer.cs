namespace OilStationW.Accounts
{
    partial class frmCurrency
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
            this.label5 = new System.Windows.Forms.Label();
            this.ckbIsMainCurr = new System.Windows.Forms.CheckBox();
            this.ckbIsInvCurr = new System.Windows.Forms.CheckBox();
            this.dgvCurrencies = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInvCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdateCurrency = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtCurr_name = new myText();
            this.txtCURR_NOTE = new myText();
            this.txtCURR_SMPL = new myText();
            this.numCURR_DECIMAL = new myNumber();
            this.numCURR_CHANGE_Rate = new myNumber();
            this.btnAdd = new SmallButton();
            this.txtPkid = new myText();
            this.nmbEditor = new myNumber();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCURR_DECIMAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCURR_CHANGE_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(628, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "اسم العملة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(283, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "رمز العملة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(628, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "عدد الكسر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(275, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "سعر الصرف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(628, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "ملاحظات";
            // 
            // ckbIsMainCurr
            // 
            this.ckbIsMainCurr.AutoSize = true;
            this.ckbIsMainCurr.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbIsMainCurr.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbIsMainCurr.Location = new System.Drawing.Point(180, 99);
            this.ckbIsMainCurr.Name = "ckbIsMainCurr";
            this.ckbIsMainCurr.Size = new System.Drawing.Size(103, 26);
            this.ckbIsMainCurr.TabIndex = 66;
            this.ckbIsMainCurr.Text = "عملة رئيسية";
            this.ckbIsMainCurr.UseVisualStyleBackColor = true;
            // 
            // ckbIsInvCurr
            // 
            this.ckbIsInvCurr.AutoSize = true;
            this.ckbIsInvCurr.Font = new System.Drawing.Font("Arial", 14F);
            this.ckbIsInvCurr.ForeColor = System.Drawing.Color.Chocolate;
            this.ckbIsInvCurr.Location = new System.Drawing.Point(68, 98);
            this.ckbIsInvCurr.Name = "ckbIsInvCurr";
            this.ckbIsInvCurr.Size = new System.Drawing.Size(106, 26);
            this.ckbIsInvCurr.TabIndex = 67;
            this.ckbIsInvCurr.Text = "عملة مخزون";
            this.ckbIsInvCurr.UseVisualStyleBackColor = true;
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrencies.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrencies.ColumnHeadersHeight = 30;
            this.dgvCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmCurrName,
            this.clmCurrSample,
            this.clmCurrDecimal,
            this.clmExchangeRate,
            this.clmCurrNotes,
            this.clmMainCurr,
            this.clmInvCurr,
            this.clmUpdateCurrency});
            this.dgvCurrencies.EnableHeadersVisualStyles = false;
            this.dgvCurrencies.Location = new System.Drawing.Point(3, 129);
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvCurrencies.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrencies.Size = new System.Drawing.Size(714, 368);
            this.dgvCurrencies.TabIndex = 68;
            this.dgvCurrencies.W_ClmName = "";
            this.dgvCurrencies.W_PK = "";
            this.dgvCurrencies.W_TableName = "";
            this.dgvCurrencies.W_updValName = "";
            this.dgvCurrencies.W_ValName = "";
            this.dgvCurrencies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrencies_CellClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmCurrName
            // 
            this.clmCurrName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCurrName.HeaderText = "اسم العملة";
            this.clmCurrName.Name = "clmCurrName";
            this.clmCurrName.ReadOnly = true;
            this.clmCurrName.Width = 150;
            // 
            // clmCurrSample
            // 
            this.clmCurrSample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCurrSample.HeaderText = "الرمز";
            this.clmCurrSample.Name = "clmCurrSample";
            this.clmCurrSample.ReadOnly = true;
            // 
            // clmCurrDecimal
            // 
            this.clmCurrDecimal.HeaderText = "الكسر";
            this.clmCurrDecimal.Name = "clmCurrDecimal";
            this.clmCurrDecimal.ReadOnly = true;
            // 
            // clmExchangeRate
            // 
            this.clmExchangeRate.HeaderText = "سعر الصرف";
            this.clmExchangeRate.Name = "clmExchangeRate";
            this.clmExchangeRate.ReadOnly = true;
            // 
            // clmCurrNotes
            // 
            this.clmCurrNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCurrNotes.HeaderText = "ملاحظات";
            this.clmCurrNotes.Name = "clmCurrNotes";
            this.clmCurrNotes.ReadOnly = true;
            // 
            // clmMainCurr
            // 
            this.clmMainCurr.HeaderText = "عملة رئيسية";
            this.clmMainCurr.Name = "clmMainCurr";
            this.clmMainCurr.ReadOnly = true;
            this.clmMainCurr.Visible = false;
            // 
            // clmInvCurr
            // 
            this.clmInvCurr.HeaderText = "عملة مخزون";
            this.clmInvCurr.Name = "clmInvCurr";
            this.clmInvCurr.ReadOnly = true;
            this.clmInvCurr.Visible = false;
            this.clmInvCurr.Width = 120;
            // 
            // clmUpdateCurrency
            // 
            this.clmUpdateCurrency.HeaderText = "تعديل";
            this.clmUpdateCurrency.Image = global::OilStationW.Properties.Resources.Save16;
            this.clmUpdateCurrency.Name = "clmUpdateCurrency";
            this.clmUpdateCurrency.ReadOnly = true;
            this.clmUpdateCurrency.Width = 50;
            // 
            // txtCurr_name
            // 
            this.txtCurr_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurr_name.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCurr_name.Location = new System.Drawing.Point(419, 38);
            this.txtCurr_name.Name = "txtCurr_name";
            this.txtCurr_name.Size = new System.Drawing.Size(203, 26);
            this.txtCurr_name.TabIndex = 69;
            this.txtCurr_name.W_ColumnName = "";
            this.txtCurr_name.W_OldValue = "";
            this.txtCurr_name.w_Tran = myText.Tran.None;
            // 
            // txtCURR_NOTE
            // 
            this.txtCURR_NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCURR_NOTE.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCURR_NOTE.Location = new System.Drawing.Point(419, 97);
            this.txtCURR_NOTE.Name = "txtCURR_NOTE";
            this.txtCURR_NOTE.Size = new System.Drawing.Size(203, 26);
            this.txtCURR_NOTE.TabIndex = 70;
            this.txtCURR_NOTE.W_ColumnName = "";
            this.txtCURR_NOTE.W_OldValue = "";
            this.txtCURR_NOTE.w_Tran = myText.Tran.None;
            // 
            // txtCURR_SMPL
            // 
            this.txtCURR_SMPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCURR_SMPL.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCURR_SMPL.Location = new System.Drawing.Point(66, 38);
            this.txtCURR_SMPL.Name = "txtCURR_SMPL";
            this.txtCURR_SMPL.Size = new System.Drawing.Size(203, 26);
            this.txtCURR_SMPL.TabIndex = 71;
            this.txtCURR_SMPL.W_ColumnName = "";
            this.txtCURR_SMPL.W_OldValue = "";
            this.txtCURR_SMPL.w_Tran = myText.Tran.None;
            // 
            // numCURR_DECIMAL
            // 
            this.numCURR_DECIMAL.Font = new System.Drawing.Font("Arial", 12F);
            this.numCURR_DECIMAL.Location = new System.Drawing.Point(419, 67);
            this.numCURR_DECIMAL.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numCURR_DECIMAL.Name = "numCURR_DECIMAL";
            this.numCURR_DECIMAL.Size = new System.Drawing.Size(203, 26);
            this.numCURR_DECIMAL.TabIndex = 72;
            this.numCURR_DECIMAL.W_ColumnName = "";
            this.numCURR_DECIMAL.W_OldValue = "";
            this.numCURR_DECIMAL.w_Tran = myNumber.Tran.None;
            // 
            // numCURR_CHANGE_Rate
            // 
            this.numCURR_CHANGE_Rate.Font = new System.Drawing.Font("Arial", 12F);
            this.numCURR_CHANGE_Rate.Location = new System.Drawing.Point(66, 67);
            this.numCURR_CHANGE_Rate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numCURR_CHANGE_Rate.Name = "numCURR_CHANGE_Rate";
            this.numCURR_CHANGE_Rate.Size = new System.Drawing.Size(203, 26);
            this.numCURR_CHANGE_Rate.TabIndex = 73;
            this.numCURR_CHANGE_Rate.W_ColumnName = "";
            this.numCURR_CHANGE_Rate.W_OldValue = "";
            this.numCURR_CHANGE_Rate.w_Tran = myNumber.Tran.None;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::OilStationW.Properties.Resources.Add_h;
            this.btnAdd.Location = new System.Drawing.Point(391, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(474, 38);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(36, 26);
            this.txtPkid.TabIndex = 75;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // nmbEditor
            // 
            this.nmbEditor.DecimalPlaces = 2;
            this.nmbEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.nmbEditor.Location = new System.Drawing.Point(310, 239);
            this.nmbEditor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbEditor.Name = "nmbEditor";
            this.nmbEditor.Size = new System.Drawing.Size(100, 23);
            this.nmbEditor.TabIndex = 80;
            this.nmbEditor.ThousandsSeparator = true;
            this.nmbEditor.Visible = false;
            this.nmbEditor.W_ColumnName = "";
            this.nmbEditor.W_OldValue = "";
            this.nmbEditor.w_Tran = myNumber.Tran.None;
            this.nmbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmbEditor_KeyDown);
            this.nmbEditor.Leave += new System.EventHandler(this.nmbEditor_Leave);
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.nmbEditor);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCURR_CHANGE_Rate);
            this.Controls.Add(this.numCURR_DECIMAL);
            this.Controls.Add(this.txtCURR_SMPL);
            this.Controls.Add(this.txtCURR_NOTE);
            this.Controls.Add(this.txtCurr_name);
            this.Controls.Add(this.dgvCurrencies);
            this.Controls.Add(this.ckbIsInvCurr);
            this.Controls.Add(this.ckbIsMainCurr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCurrency";
            this.Tag = "frmCurrency";
            this.Text = "إدارة العملات";
            this.Titel = "إدارة العملات";
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ckbIsMainCurr, 0);
            this.Controls.SetChildIndex(this.ckbIsInvCurr, 0);
            this.Controls.SetChildIndex(this.dgvCurrencies, 0);
            this.Controls.SetChildIndex(this.txtCurr_name, 0);
            this.Controls.SetChildIndex(this.txtCURR_NOTE, 0);
            this.Controls.SetChildIndex(this.txtCURR_SMPL, 0);
            this.Controls.SetChildIndex(this.numCURR_DECIMAL, 0);
            this.Controls.SetChildIndex(this.numCURR_CHANGE_Rate, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.nmbEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCURR_DECIMAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCURR_CHANGE_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbIsMainCurr;
        private System.Windows.Forms.CheckBox ckbIsInvCurr;
        private myDataGrid dgvCurrencies;
        private myText txtCurr_name;
        private myText txtCURR_NOTE;
        private myText txtCURR_SMPL;
        private myNumber numCURR_DECIMAL;
        private myNumber numCURR_CHANGE_Rate;
        private SmallButton btnAdd;
        private myText txtPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrDecimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInvCurr;
        private System.Windows.Forms.DataGridViewImageColumn clmUpdateCurrency;
        private myNumber nmbEditor;
    }
}
