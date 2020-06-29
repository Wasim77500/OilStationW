namespace OilStationW.Files
{
    partial class frmTempletManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormArName = new myText();
            this.txtTempletName = new myText();
            this.btnFind = new SmallButton();
            this.dgvForms = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormEnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMultiForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormTypeAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormTypeEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormArName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShow = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgProperities = new myDataGrid();
            this.clmDetailPkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcontrol_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFreeListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmen_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPkId = new myText();
            this.lstEditor = new myList();
            this.lstMultiEditor = new System.Windows.Forms.CheckedListBox();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(703, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الشاشة(عربي)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(266, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم النموذج";
            // 
            // txtFormArName
            // 
            this.txtFormArName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormArName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFormArName.Location = new System.Drawing.Point(482, 32);
            this.txtFormArName.Name = "txtFormArName";
            this.txtFormArName.Size = new System.Drawing.Size(215, 26);
            this.txtFormArName.TabIndex = 10;
            this.txtFormArName.W_ColumnName = "";
            this.txtFormArName.W_OldValue = "";
            this.txtFormArName.w_Tran = myText.Tran.None;
            // 
            // txtTempletName
            // 
            this.txtTempletName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempletName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTempletName.Location = new System.Drawing.Point(43, 32);
            this.txtTempletName.Name = "txtTempletName";
            this.txtTempletName.Size = new System.Drawing.Size(215, 26);
            this.txtTempletName.TabIndex = 11;
            this.txtTempletName.W_ColumnName = "";
            this.txtTempletName.W_OldValue = "";
            this.txtTempletName.w_Tran = myText.Tran.None;
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
            this.btnFind.Image = global::OilStationW.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(454, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 12;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.clmFormEnName,
            this.clmMultiForm,
            this.clmFormTypeAr,
            this.clmFormTypeEn,
            this.clmFormArName,
            this.clmShow});
            this.dgvForms.EnableHeadersVisualStyles = false;
            this.dgvForms.Location = new System.Drawing.Point(389, 64);
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvForms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvForms.Size = new System.Drawing.Size(444, 420);
            this.dgvForms.TabIndex = 51;
            this.dgvForms.W_ClmName = "";
            this.dgvForms.W_PK = "";
            this.dgvForms.W_TableName = "";
            this.dgvForms.W_updValName = "";
            this.dgvForms.W_ValName = "";
            this.dgvForms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForms_CellClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmFormEnName
            // 
            this.clmFormEnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFormEnName.HeaderText = "اسم الشاشة في البرنامج";
            this.clmFormEnName.Name = "clmFormEnName";
            this.clmFormEnName.ReadOnly = true;
            this.clmFormEnName.Visible = false;
            // 
            // clmMultiForm
            // 
            this.clmMultiForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMultiForm.HeaderText = "يقبل اكثر من شاشة";
            this.clmMultiForm.Name = "clmMultiForm";
            this.clmMultiForm.ReadOnly = true;
            this.clmMultiForm.Visible = false;
            // 
            // clmFormTypeAr
            // 
            this.clmFormTypeAr.HeaderText = "نوع الشاشة عربي";
            this.clmFormTypeAr.Name = "clmFormTypeAr";
            this.clmFormTypeAr.ReadOnly = true;
            this.clmFormTypeAr.Visible = false;
            // 
            // clmFormTypeEn
            // 
            this.clmFormTypeEn.HeaderText = "إنجليزي نوع الشاشة";
            this.clmFormTypeEn.Name = "clmFormTypeEn";
            this.clmFormTypeEn.ReadOnly = true;
            this.clmFormTypeEn.Visible = false;
            // 
            // clmFormArName
            // 
            this.clmFormArName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFormArName.HeaderText = "اسم الشاشة";
            this.clmFormArName.Name = "clmFormArName";
            this.clmFormArName.ReadOnly = true;
            // 
            // clmShow
            // 
            this.clmShow.HeaderText = "النماذج";
            this.clmShow.Image = global::OilStationW.Properties.Resources.Open16;
            this.clmShow.Name = "clmShow";
            this.clmShow.ReadOnly = true;
            // 
            // dgProperities
            // 
            this.dgProperities.AllowUserToAddRows = false;
            this.dgProperities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgProperities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProperities.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProperities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProperities.ColumnHeadersHeight = 30;
            this.dgProperities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDetailPkId,
            this.clmPropertyName,
            this.clmPropertyValue,
            this.clmcontrol_type,
            this.clmListId,
            this.clmFreeListName,
            this.clmen_name,
            this.clmRealValue});
            this.dgProperities.EnableHeadersVisualStyles = false;
            this.dgProperities.Location = new System.Drawing.Point(8, 64);
            this.dgProperities.Name = "dgProperities";
            this.dgProperities.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgProperities.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProperities.Size = new System.Drawing.Size(375, 376);
            this.dgProperities.TabIndex = 52;
            this.dgProperities.W_ClmName = "";
            this.dgProperities.W_PK = "";
            this.dgProperities.W_TableName = "";
            this.dgProperities.W_updValName = "";
            this.dgProperities.W_ValName = "";
            this.dgProperities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProperities_CellClick);
            // 
            // clmDetailPkId
            // 
            this.clmDetailPkId.HeaderText = "Row id";
            this.clmDetailPkId.Name = "clmDetailPkId";
            this.clmDetailPkId.ReadOnly = true;
            this.clmDetailPkId.Visible = false;
            // 
            // clmPropertyName
            // 
            this.clmPropertyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPropertyName.HeaderText = "اسم الخاصية";
            this.clmPropertyName.Name = "clmPropertyName";
            this.clmPropertyName.ReadOnly = true;
            // 
            // clmPropertyValue
            // 
            this.clmPropertyValue.HeaderText = "القيمة";
            this.clmPropertyValue.Name = "clmPropertyValue";
            this.clmPropertyValue.ReadOnly = true;
            this.clmPropertyValue.Width = 186;
            // 
            // clmcontrol_type
            // 
            this.clmcontrol_type.HeaderText = "Column1";
            this.clmcontrol_type.Name = "clmcontrol_type";
            this.clmcontrol_type.ReadOnly = true;
            this.clmcontrol_type.Visible = false;
            // 
            // clmListId
            // 
            this.clmListId.HeaderText = "clmListId";
            this.clmListId.Name = "clmListId";
            this.clmListId.ReadOnly = true;
            this.clmListId.Visible = false;
            // 
            // clmFreeListName
            // 
            this.clmFreeListName.HeaderText = "clmFreeListName";
            this.clmFreeListName.Name = "clmFreeListName";
            this.clmFreeListName.ReadOnly = true;
            this.clmFreeListName.Visible = false;
            // 
            // clmen_name
            // 
            this.clmen_name.HeaderText = "clmen_name";
            this.clmen_name.Name = "clmen_name";
            this.clmen_name.ReadOnly = true;
            this.clmen_name.Visible = false;
            // 
            // clmRealValue
            // 
            this.clmRealValue.HeaderText = "clmRealValue";
            this.clmRealValue.Name = "clmRealValue";
            this.clmRealValue.ReadOnly = true;
            this.clmRealValue.Visible = false;
            // 
            // txtPkId
            // 
            this.txtPkId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPkId.Location = new System.Drawing.Point(34, 32);
            this.txtPkId.Name = "txtPkId";
            this.txtPkId.Size = new System.Drawing.Size(43, 23);
            this.txtPkId.TabIndex = 53;
            this.txtPkId.Visible = false;
            this.txtPkId.W_ColumnName = "";
            this.txtPkId.W_OldValue = "";
            this.txtPkId.w_Tran = myText.Tran.None;
            // 
            // lstEditor
            // 
            this.lstEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Location = new System.Drawing.Point(168, 265);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(121, 24);
            this.lstEditor.TabIndex = 291;
            this.lstEditor.Visible = false;
            this.lstEditor.W_ColumnName = "";
            this.lstEditor.W_OldValue = "";
            this.lstEditor.w_Tran = myList.Tran.None;
            this.lstEditor.w_ValueType = myList.ValueType.TEXT;
            this.lstEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.lstEditor.Leave += new System.EventHandler(this.lstEditor_Leave);
            // 
            // lstMultiEditor
            // 
            this.lstMultiEditor.BackColor = System.Drawing.SystemColors.Window;
            this.lstMultiEditor.CheckOnClick = true;
            this.lstMultiEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMultiEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstMultiEditor.Location = new System.Drawing.Point(185, 165);
            this.lstMultiEditor.Name = "lstMultiEditor";
            this.lstMultiEditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstMultiEditor.Size = new System.Drawing.Size(104, 94);
            this.lstMultiEditor.TabIndex = 290;
            this.lstMultiEditor.ThreeDCheckBoxes = true;
            this.lstMultiEditor.Visible = false;
            this.lstMultiEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMultiEditor_KeyDown);
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
            this.btnClose.Location = new System.Drawing.Point(8, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 293;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSave.Location = new System.Drawing.Point(84, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 292;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTempletManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(836, 490);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.lstMultiEditor);
            this.Controls.Add(this.txtPkId);
            this.Controls.Add(this.dgProperities);
            this.Controls.Add(this.dgvForms);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtTempletName);
            this.Controls.Add(this.txtFormArName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTempletManagement";
            this.Tag = "frmTempletManagement";
            this.Text = "إدارة النماذج";
            this.Titel = "إدارة النماذج";
            this.Load += new System.EventHandler(this.frmTempletManagement_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtFormArName, 0);
            this.Controls.SetChildIndex(this.txtTempletName, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.dgvForms, 0);
            this.Controls.SetChildIndex(this.dgProperities, 0);
            this.Controls.SetChildIndex(this.txtPkId, 0);
            this.Controls.SetChildIndex(this.lstMultiEditor, 0);
            this.Controls.SetChildIndex(this.lstEditor, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private myText txtFormArName;
        private myText txtTempletName;
        private SmallButton btnFind;
        private myDataGrid dgvForms;
        private myDataGrid dgProperities;
        private myText txtPkId;
        private myList lstEditor;
        private System.Windows.Forms.CheckedListBox lstMultiEditor;
        private MainButton btnClose;
        private MainButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormEnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMultiForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormTypeAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormTypeEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormArName;
        private System.Windows.Forms.DataGridViewImageColumn clmShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetailPkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPropertyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcontrol_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFreeListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmen_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRealValue;
    }
}
