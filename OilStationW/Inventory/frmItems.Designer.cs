namespace OilStationW.Inventory
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemNo = new myText();
            this.txtItemName = new myText();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmbCostValue = new myNumber();
            this.nmbSellingPriceValue = new myNumber();
            this.lstItemType = new myList();
            this.lstUnits = new myList();
            this.txtItemNote = new myText();
            this.btnFind = new SmallButton();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtPkid = new myText();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCostValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSellingPriceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(463, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "رقم الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(461, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "نوع الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(462, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "سعر التكلفة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(463, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "مـلاحـظـات";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemNo.Location = new System.Drawing.Point(316, 30);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(138, 26);
            this.txtItemNo.TabIndex = 54;
            this.txtItemNo.W_ColumnName = "";
            this.txtItemNo.W_OldValue = "";
            this.txtItemNo.w_Tran = myText.Tran.None;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemName.Location = new System.Drawing.Point(6, 30);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(189, 26);
            this.txtItemName.TabIndex = 55;
            this.txtItemName.W_ColumnName = "";
            this.txtItemName.W_OldValue = "";
            this.txtItemName.w_Tran = myText.Tran.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(201, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "سعر البيع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(196, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "وحدة القياس";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(200, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "اسم الصنف";
            // 
            // nmbCostValue
            // 
            this.nmbCostValue.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbCostValue.Location = new System.Drawing.Point(287, 88);
            this.nmbCostValue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbCostValue.Name = "nmbCostValue";
            this.nmbCostValue.Size = new System.Drawing.Size(167, 26);
            this.nmbCostValue.TabIndex = 59;
            this.nmbCostValue.W_ColumnName = "";
            this.nmbCostValue.W_OldValue = "";
            this.nmbCostValue.w_Tran = myNumber.Tran.None;
            // 
            // nmbSellingPriceValue
            // 
            this.nmbSellingPriceValue.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbSellingPriceValue.Location = new System.Drawing.Point(6, 88);
            this.nmbSellingPriceValue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbSellingPriceValue.Name = "nmbSellingPriceValue";
            this.nmbSellingPriceValue.Size = new System.Drawing.Size(189, 26);
            this.nmbSellingPriceValue.TabIndex = 60;
            this.nmbSellingPriceValue.W_ColumnName = "";
            this.nmbSellingPriceValue.W_OldValue = "";
            this.nmbSellingPriceValue.w_Tran = myNumber.Tran.None;
            // 
            // lstItemType
            // 
            this.lstItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstItemType.Font = new System.Drawing.Font("Arial", 12F);
            this.lstItemType.FormattingEnabled = true;
            this.lstItemType.Location = new System.Drawing.Point(287, 59);
            this.lstItemType.Name = "lstItemType";
            this.lstItemType.Size = new System.Drawing.Size(167, 26);
            this.lstItemType.TabIndex = 61;
            this.lstItemType.W_ColumnName = "";
            this.lstItemType.W_OldValue = "";
            this.lstItemType.w_Tran = myList.Tran.None;
            this.lstItemType.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstUnits
            // 
            this.lstUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstUnits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstUnits.Font = new System.Drawing.Font("Arial", 12F);
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(6, 59);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(189, 26);
            this.lstUnits.TabIndex = 62;
            this.lstUnits.W_ColumnName = "";
            this.lstUnits.W_OldValue = "";
            this.lstUnits.w_Tran = myList.Tran.None;
            this.lstUnits.w_ValueType = myList.ValueType.TEXT;
            // 
            // txtItemNote
            // 
            this.txtItemNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemNote.Location = new System.Drawing.Point(6, 117);
            this.txtItemNote.Name = "txtItemNote";
            this.txtItemNote.Size = new System.Drawing.Size(448, 26);
            this.txtItemNote.TabIndex = 63;
            this.txtItemNote.W_ColumnName = "";
            this.txtItemNote.W_OldValue = "";
            this.txtItemNote.w_Tran = myText.Tran.None;
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
            this.btnFind.Location = new System.Drawing.Point(287, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 64;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.Location = new System.Drawing.Point(187, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClose.Location = new System.Drawing.Point(111, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 67;
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
            this.btnSave.Location = new System.Drawing.Point(263, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnNew.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNew.Location = new System.Drawing.Point(339, 151);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 65;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(371, 30);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(43, 26);
            this.txtPkid.TabIndex = 69;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(549, 195);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtItemNote);
            this.Controls.Add(this.lstUnits);
            this.Controls.Add(this.lstItemType);
            this.Controls.Add(this.nmbSellingPriceValue);
            this.Controls.Add(this.nmbCostValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmItems";
            this.Tag = "frmItems";
            this.Text = "تعريف الأصناف";
            this.Titel = "تعريف الأصناف";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtItemNo, 0);
            this.Controls.SetChildIndex(this.txtItemName, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nmbCostValue, 0);
            this.Controls.SetChildIndex(this.nmbSellingPriceValue, 0);
            this.Controls.SetChildIndex(this.lstItemType, 0);
            this.Controls.SetChildIndex(this.lstUnits, 0);
            this.Controls.SetChildIndex(this.txtItemNote, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbCostValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSellingPriceValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private myText txtItemNo;
        private myText txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private myNumber nmbCostValue;
        private myNumber nmbSellingPriceValue;
        private myList lstItemType;
        private myList lstUnits;
        private myText txtItemNote;
        private SmallButton btnFind;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtPkid;
    }
}
