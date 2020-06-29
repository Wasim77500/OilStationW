namespace OilStationW.Files
{
    partial class frmFreeList
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
            this.txtPkId = new myText();
            this.txtDISPLAY_MEMBER = new myText();
            this.txtVALUE_MEMBER = new myText();
            this.lstLIST_NAME = new myList();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgFreeList = new myDataGrid();
            this.clmPkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdentifiedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValueInList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new SmallButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPkId
            // 
            this.txtPkId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPkId.Location = new System.Drawing.Point(253, 55);
            this.txtPkId.Name = "txtPkId";
            this.txtPkId.Size = new System.Drawing.Size(41, 23);
            this.txtPkId.TabIndex = 50;
            this.txtPkId.Visible = false;
            this.txtPkId.W_ColumnName = "";
            this.txtPkId.W_OldValue = "";
            this.txtPkId.w_Tran = myText.Tran.None;
            // 
            // txtDISPLAY_MEMBER
            // 
            this.txtDISPLAY_MEMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDISPLAY_MEMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDISPLAY_MEMBER.Location = new System.Drawing.Point(41, 96);
            this.txtDISPLAY_MEMBER.Name = "txtDISPLAY_MEMBER";
            this.txtDISPLAY_MEMBER.Size = new System.Drawing.Size(161, 23);
            this.txtDISPLAY_MEMBER.TabIndex = 49;
            this.txtDISPLAY_MEMBER.W_ColumnName = "";
            this.txtDISPLAY_MEMBER.W_OldValue = "";
            this.txtDISPLAY_MEMBER.w_Tran = myText.Tran.None;
            // 
            // txtVALUE_MEMBER
            // 
            this.txtVALUE_MEMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVALUE_MEMBER.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVALUE_MEMBER.Location = new System.Drawing.Point(41, 71);
            this.txtVALUE_MEMBER.Name = "txtVALUE_MEMBER";
            this.txtVALUE_MEMBER.Size = new System.Drawing.Size(161, 23);
            this.txtVALUE_MEMBER.TabIndex = 48;
            this.txtVALUE_MEMBER.W_ColumnName = "";
            this.txtVALUE_MEMBER.W_OldValue = "";
            this.txtVALUE_MEMBER.w_Tran = myText.Tran.None;
            // 
            // lstLIST_NAME
            // 
            this.lstLIST_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstLIST_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstLIST_NAME.Font = new System.Drawing.Font("Arial", 10F);
            this.lstLIST_NAME.FormattingEnabled = true;
            this.lstLIST_NAME.Location = new System.Drawing.Point(12, 32);
            this.lstLIST_NAME.Name = "lstLIST_NAME";
            this.lstLIST_NAME.Size = new System.Drawing.Size(172, 24);
            this.lstLIST_NAME.TabIndex = 47;
            this.lstLIST_NAME.W_ColumnName = "";
            this.lstLIST_NAME.W_OldValue = "";
            this.lstLIST_NAME.w_Tran = myList.Tran.None;
            this.lstLIST_NAME.w_ValueType = myList.ValueType.TEXT;
            this.lstLIST_NAME.TextChanged += new System.EventHandler(this.lstLIST_NAME_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(210, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "القيمة في القائمة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(229, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "رقم تعريف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(211, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "اسم القائمة";
            // 
            // dgFreeList
            // 
            this.dgFreeList.AllowUserToAddRows = false;
            this.dgFreeList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.dgFreeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFreeList.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFreeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFreeList.ColumnHeadersHeight = 30;
            this.dgFreeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPkid,
            this.clmIdentifiedId,
            this.clmValueInList});
            this.dgFreeList.EnableHeadersVisualStyles = false;
            this.dgFreeList.Location = new System.Drawing.Point(3, 125);
            this.dgFreeList.Name = "dgFreeList";
            this.dgFreeList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.dgFreeList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFreeList.Size = new System.Drawing.Size(301, 396);
            this.dgFreeList.TabIndex = 51;
            this.dgFreeList.W_ClmName = "";
            this.dgFreeList.W_PK = "";
            this.dgFreeList.W_TableName = "";
            this.dgFreeList.W_updValName = "";
            this.dgFreeList.W_ValName = "";
            // 
            // clmPkid
            // 
            this.clmPkid.HeaderText = "Row id";
            this.clmPkid.Name = "clmPkid";
            this.clmPkid.ReadOnly = true;
            this.clmPkid.Visible = false;
            // 
            // clmIdentifiedId
            // 
            this.clmIdentifiedId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmIdentifiedId.HeaderText = "رقم التعريف";
            this.clmIdentifiedId.Name = "clmIdentifiedId";
            this.clmIdentifiedId.ReadOnly = true;
            // 
            // clmValueInList
            // 
            this.clmValueInList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmValueInList.HeaderText = "القيمة في القائمة";
            this.clmValueInList.Name = "clmValueInList";
            this.clmValueInList.ReadOnly = true;
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
            this.btnAdd.Location = new System.Drawing.Point(9, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmFreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(307, 525);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgFreeList);
            this.Controls.Add(this.txtPkId);
            this.Controls.Add(this.txtDISPLAY_MEMBER);
            this.Controls.Add(this.txtVALUE_MEMBER);
            this.Controls.Add(this.lstLIST_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmFreeList";
            this.Load += new System.EventHandler(this.frmFreeList_Load);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lstLIST_NAME, 0);
            this.Controls.SetChildIndex(this.txtVALUE_MEMBER, 0);
            this.Controls.SetChildIndex(this.txtDISPLAY_MEMBER, 0);
            this.Controls.SetChildIndex(this.txtPkId, 0);
            this.Controls.SetChildIndex(this.dgFreeList, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgFreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myText txtPkId;
        private myText txtDISPLAY_MEMBER;
        private myText txtVALUE_MEMBER;
        private myList lstLIST_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private myDataGrid dgFreeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentifiedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValueInList;
        private SmallButton btnAdd;
    }
}
