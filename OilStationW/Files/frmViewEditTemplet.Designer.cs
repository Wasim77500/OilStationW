namespace OilStationW.Files
{
    partial class frmViewEditTemplet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstEditor = new myList();
            this.txtFormId = new myText();
            this.txtForm_type = new myText();
            this.txtFormEnName = new myText();
            this.txtFormName = new myText();
            this.label49 = new System.Windows.Forms.Label();
            this.dgvTempHeader = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG1TempName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProperities = new myDataGrid();
            this.dgvTempDetails = new myDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG3Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG3control_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG3en_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG3RealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2control_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2List_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2Free_list_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2en_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2RealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmG2Update = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lstEditor
            // 
            this.lstEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEditor.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Location = new System.Drawing.Point(44, 142);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(100, 24);
            this.lstEditor.TabIndex = 47;
            this.lstEditor.Visible = false;
            this.lstEditor.W_ColumnName = "";
            this.lstEditor.W_OldValue = "";
            this.lstEditor.w_Tran = myList.Tran.None;
            this.lstEditor.w_ValueType = myList.ValueType.TEXT;
            this.lstEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEditor_KeyDown);
            this.lstEditor.Leave += new System.EventHandler(this.lstEditor_Leave);
            // 
            // txtFormId
            // 
            this.txtFormId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormId.Location = new System.Drawing.Point(44, 84);
            this.txtFormId.Name = "txtFormId";
            this.txtFormId.Size = new System.Drawing.Size(100, 23);
            this.txtFormId.TabIndex = 46;
            this.txtFormId.Visible = false;
            this.txtFormId.W_ColumnName = "";
            this.txtFormId.W_OldValue = "";
            this.txtFormId.w_Tran = myText.Tran.None;
            // 
            // txtForm_type
            // 
            this.txtForm_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForm_type.Font = new System.Drawing.Font("Arial", 10F);
            this.txtForm_type.Location = new System.Drawing.Point(44, 113);
            this.txtForm_type.Name = "txtForm_type";
            this.txtForm_type.Size = new System.Drawing.Size(100, 23);
            this.txtForm_type.TabIndex = 45;
            this.txtForm_type.Visible = false;
            this.txtForm_type.W_ColumnName = "";
            this.txtForm_type.W_OldValue = "";
            this.txtForm_type.w_Tran = myText.Tran.None;
            // 
            // txtFormEnName
            // 
            this.txtFormEnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormEnName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormEnName.Location = new System.Drawing.Point(44, 55);
            this.txtFormEnName.Name = "txtFormEnName";
            this.txtFormEnName.Size = new System.Drawing.Size(100, 23);
            this.txtFormEnName.TabIndex = 44;
            this.txtFormEnName.Visible = false;
            this.txtFormEnName.W_ColumnName = "";
            this.txtFormEnName.W_OldValue = "";
            this.txtFormEnName.w_Tran = myText.Tran.None;
            // 
            // txtFormName
            // 
            this.txtFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFormName.Location = new System.Drawing.Point(233, 32);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(207, 23);
            this.txtFormName.TabIndex = 49;
            this.txtFormName.W_ColumnName = "";
            this.txtFormName.W_OldValue = "";
            this.txtFormName.w_Tran = myText.Tran.None;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(447, 34);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(66, 18);
            this.label49.TabIndex = 48;
            this.label49.Text = "اسم الشاشة";
            // 
            // dgvTempHeader
            // 
            this.dgvTempHeader.AllowUserToAddRows = false;
            this.dgvTempHeader.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvTempHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTempHeader.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTempHeader.ColumnHeadersHeight = 30;
            this.dgvTempHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmG1TempName});
            this.dgvTempHeader.EnableHeadersVisualStyles = false;
            this.dgvTempHeader.Location = new System.Drawing.Point(233, 61);
            this.dgvTempHeader.Name = "dgvTempHeader";
            this.dgvTempHeader.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvTempHeader.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTempHeader.Size = new System.Drawing.Size(277, 122);
            this.dgvTempHeader.TabIndex = 52;
            this.dgvTempHeader.W_ClmName = "";
            this.dgvTempHeader.W_PK = "";
            this.dgvTempHeader.W_TableName = "";
            this.dgvTempHeader.W_updValName = "";
            this.dgvTempHeader.W_ValName = "";
            this.dgvTempHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTempHeader_CellClick);
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmG1TempName
            // 
            this.clmG1TempName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmG1TempName.HeaderText = "اسم النموذج";
            this.clmG1TempName.Name = "clmG1TempName";
            this.clmG1TempName.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clmG2Value,
            this.clmG2control_type,
            this.clmG2List_id,
            this.clmG2Free_list_name,
            this.clmG2en_name,
            this.clmG2RealValue,
            this.clmG2Update});
            this.dgProperities.EnableHeadersVisualStyles = false;
            this.dgProperities.Location = new System.Drawing.Point(354, 187);
            this.dgProperities.Name = "dgProperities";
            this.dgProperities.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgProperities.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProperities.Size = new System.Drawing.Size(366, 326);
            this.dgProperities.TabIndex = 53;
            this.dgProperities.W_ClmName = "";
            this.dgProperities.W_PK = "";
            this.dgProperities.W_TableName = "";
            this.dgProperities.W_updValName = "";
            this.dgProperities.W_ValName = "";
            this.dgProperities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProperities_CellClick);
            // 
            // dgvTempDetails
            // 
            this.dgvTempDetails.AllowUserToAddRows = false;
            this.dgvTempDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgvTempDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTempDetails.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTempDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTempDetails.ColumnHeadersHeight = 30;
            this.dgvTempDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.clmG3Value,
            this.clmG3control_type,
            this.clmG3en_name,
            this.clmG3RealValue});
            this.dgvTempDetails.EnableHeadersVisualStyles = false;
            this.dgvTempDetails.Location = new System.Drawing.Point(3, 187);
            this.dgvTempDetails.Name = "dgvTempDetails";
            this.dgvTempDetails.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgvTempDetails.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTempDetails.Size = new System.Drawing.Size(345, 326);
            this.dgvTempDetails.TabIndex = 54;
            this.dgvTempDetails.W_ClmName = "";
            this.dgvTempDetails.W_PK = "";
            this.dgvTempDetails.W_TableName = "";
            this.dgvTempDetails.W_updValName = "";
            this.dgvTempDetails.W_ValName = "";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Row id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "اسم الخاصية";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // clmG3Value
            // 
            this.clmG3Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmG3Value.HeaderText = "القيــمــة";
            this.clmG3Value.Name = "clmG3Value";
            this.clmG3Value.ReadOnly = true;
            // 
            // clmG3control_type
            // 
            this.clmG3control_type.HeaderText = "Column1";
            this.clmG3control_type.Name = "clmG3control_type";
            this.clmG3control_type.ReadOnly = true;
            this.clmG3control_type.Visible = false;
            // 
            // clmG3en_name
            // 
            this.clmG3en_name.HeaderText = "Column1";
            this.clmG3en_name.Name = "clmG3en_name";
            this.clmG3en_name.ReadOnly = true;
            this.clmG3en_name.Visible = false;
            // 
            // clmG3RealValue
            // 
            this.clmG3RealValue.HeaderText = "Column1";
            this.clmG3RealValue.Name = "clmG3RealValue";
            this.clmG3RealValue.ReadOnly = true;
            this.clmG3RealValue.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Row id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الخاصية";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // clmG2Value
            // 
            this.clmG2Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmG2Value.HeaderText = "القيــمــة";
            this.clmG2Value.Name = "clmG2Value";
            this.clmG2Value.ReadOnly = true;
            // 
            // clmG2control_type
            // 
            this.clmG2control_type.HeaderText = "Column2";
            this.clmG2control_type.Name = "clmG2control_type";
            this.clmG2control_type.ReadOnly = true;
            this.clmG2control_type.Visible = false;
            // 
            // clmG2List_id
            // 
            this.clmG2List_id.HeaderText = "Column3";
            this.clmG2List_id.Name = "clmG2List_id";
            this.clmG2List_id.ReadOnly = true;
            this.clmG2List_id.Visible = false;
            // 
            // clmG2Free_list_name
            // 
            this.clmG2Free_list_name.HeaderText = "Column4";
            this.clmG2Free_list_name.Name = "clmG2Free_list_name";
            this.clmG2Free_list_name.ReadOnly = true;
            this.clmG2Free_list_name.Visible = false;
            // 
            // clmG2en_name
            // 
            this.clmG2en_name.HeaderText = "Column5";
            this.clmG2en_name.Name = "clmG2en_name";
            this.clmG2en_name.ReadOnly = true;
            this.clmG2en_name.Visible = false;
            // 
            // clmG2RealValue
            // 
            this.clmG2RealValue.HeaderText = "Column6";
            this.clmG2RealValue.Name = "clmG2RealValue";
            this.clmG2RealValue.ReadOnly = true;
            this.clmG2RealValue.Visible = false;
            // 
            // clmG2Update
            // 
            this.clmG2Update.HeaderText = "تعديل";
            this.clmG2Update.Image = global::OilStationW.Properties.Resources.Previous;
            this.clmG2Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmG2Update.Name = "clmG2Update";
            this.clmG2Update.ReadOnly = true;
            this.clmG2Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmG2Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmG2Update.Width = 50;
            // 
            // frmViewEditTemplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(724, 521);
            this.Controls.Add(this.dgvTempDetails);
            this.Controls.Add(this.dgProperities);
            this.Controls.Add(this.dgvTempHeader);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.txtFormId);
            this.Controls.Add(this.txtForm_type);
            this.Controls.Add(this.txtFormEnName);
            this.Name = "frmViewEditTemplet";
            this.Load += new System.EventHandler(this.frmViewEditTemplet_Load);
            this.Controls.SetChildIndex(this.txtFormEnName, 0);
            this.Controls.SetChildIndex(this.txtForm_type, 0);
            this.Controls.SetChildIndex(this.txtFormId, 0);
            this.Controls.SetChildIndex(this.lstEditor, 0);
            this.Controls.SetChildIndex(this.label49, 0);
            this.Controls.SetChildIndex(this.txtFormName, 0);
            this.Controls.SetChildIndex(this.dgvTempHeader, 0);
            this.Controls.SetChildIndex(this.dgProperities, 0);
            this.Controls.SetChildIndex(this.dgvTempDetails, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public myList lstEditor;
        public myText txtFormId;
        public myText txtForm_type;
        public myText txtFormEnName;
        public myText txtFormName;
        private System.Windows.Forms.Label label49;
        private myDataGrid dgvTempHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG1TempName;
        private myDataGrid dgProperities;
        private myDataGrid dgvTempDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG3Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG3control_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG3en_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG3RealValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2control_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2List_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2Free_list_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2en_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmG2RealValue;
        private System.Windows.Forms.DataGridViewImageColumn clmG2Update;
    }
}
