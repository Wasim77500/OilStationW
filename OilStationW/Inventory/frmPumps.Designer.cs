namespace OilStationW.Inventory
{
    partial class frmPumps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPumps));
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.btnFind = new SmallButton();
            this.txtPumpNote = new myText();
            this.lstPumpStat = new myList();
            this.nmbPumpCounter = new myNumber();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPumpName = new myText();
            this.txtPumpNo = new myText();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstWareHouse = new myList();
            this.lstItems = new myList();
            this.txtPkid = new myText();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPumpCounter)).BeginInit();
            this.SuspendLayout();
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
            this.btnUpdate.Location = new System.Drawing.Point(189, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 87;
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
            this.btnClose.Location = new System.Drawing.Point(113, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 86;
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
            this.btnSave.Location = new System.Drawing.Point(265, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 85;
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
            this.btnNew.Location = new System.Drawing.Point(341, 153);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 84;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnFind.Location = new System.Drawing.Point(289, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 83;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPumpNote
            // 
            this.txtPumpNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPumpNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPumpNote.Location = new System.Drawing.Point(8, 119);
            this.txtPumpNote.Name = "txtPumpNote";
            this.txtPumpNote.Size = new System.Drawing.Size(448, 26);
            this.txtPumpNote.TabIndex = 82;
            this.txtPumpNote.W_ColumnName = "";
            this.txtPumpNote.W_OldValue = "";
            this.txtPumpNote.w_Tran = myText.Tran.None;
            // 
            // lstPumpStat
            // 
            this.lstPumpStat.AutoCompleteCustomSource.AddRange(new string[] {
            "متاحة",
            "شغالة",
            "موقفة"});
            this.lstPumpStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstPumpStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstPumpStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPumpStat.Font = new System.Drawing.Font("Arial", 12F);
            this.lstPumpStat.FormattingEnabled = true;
            this.lstPumpStat.Items.AddRange(new object[] {
            "متاحة",
            "شغالة",
            "موقفة"});
            this.lstPumpStat.Location = new System.Drawing.Point(289, 61);
            this.lstPumpStat.Name = "lstPumpStat";
            this.lstPumpStat.Size = new System.Drawing.Size(167, 26);
            this.lstPumpStat.TabIndex = 80;
            this.lstPumpStat.W_ColumnName = "";
            this.lstPumpStat.W_OldValue = "";
            this.lstPumpStat.w_Tran = myList.Tran.None;
            this.lstPumpStat.w_ValueType = myList.ValueType.TEXT;
            // 
            // nmbPumpCounter
            // 
            this.nmbPumpCounter.Font = new System.Drawing.Font("Arial", 12F);
            this.nmbPumpCounter.Location = new System.Drawing.Point(8, 61);
            this.nmbPumpCounter.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nmbPumpCounter.Name = "nmbPumpCounter";
            this.nmbPumpCounter.Size = new System.Drawing.Size(189, 26);
            this.nmbPumpCounter.TabIndex = 79;
            this.nmbPumpCounter.W_ColumnName = "";
            this.nmbPumpCounter.W_OldValue = "";
            this.nmbPumpCounter.w_Tran = myNumber.Tran.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(203, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "اسم الصنف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(198, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 76;
            this.label6.Text = "القراءة الحالية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(202, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 75;
            this.label7.Text = "اسم الطرمبة";
            // 
            // txtPumpName
            // 
            this.txtPumpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPumpName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPumpName.Location = new System.Drawing.Point(8, 32);
            this.txtPumpName.Name = "txtPumpName";
            this.txtPumpName.Size = new System.Drawing.Size(189, 26);
            this.txtPumpName.TabIndex = 74;
            this.txtPumpName.W_ColumnName = "";
            this.txtPumpName.W_OldValue = "";
            this.txtPumpName.w_Tran = myText.Tran.None;
            // 
            // txtPumpNo
            // 
            this.txtPumpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPumpNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPumpNo.Location = new System.Drawing.Point(318, 32);
            this.txtPumpNo.Name = "txtPumpNo";
            this.txtPumpNo.Size = new System.Drawing.Size(138, 26);
            this.txtPumpNo.TabIndex = 73;
            this.txtPumpNo.W_ColumnName = "";
            this.txtPumpNo.W_OldValue = "";
            this.txtPumpNo.w_Tran = myText.Tran.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(465, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "مـلاحـظـات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(464, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "المخزن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(463, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "الحالة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(460, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "رقم الطرمبة";
            // 
            // lstWareHouse
            // 
            this.lstWareHouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstWareHouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWareHouse.Font = new System.Drawing.Font("Arial", 12F);
            this.lstWareHouse.FormattingEnabled = true;
            this.lstWareHouse.Location = new System.Drawing.Point(289, 90);
            this.lstWareHouse.Name = "lstWareHouse";
            this.lstWareHouse.Size = new System.Drawing.Size(167, 26);
            this.lstWareHouse.TabIndex = 88;
            this.lstWareHouse.W_ColumnName = "";
            this.lstWareHouse.W_OldValue = "";
            this.lstWareHouse.w_Tran = myList.Tran.None;
            this.lstWareHouse.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstItems
            // 
            this.lstItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstItems.Font = new System.Drawing.Font("Arial", 12F);
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(8, 90);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(189, 26);
            this.lstItems.TabIndex = 89;
            this.lstItems.W_ColumnName = "";
            this.lstItems.W_OldValue = "";
            this.lstItems.w_Tran = myList.Tran.None;
            this.lstItems.w_ValueType = myList.ValueType.TEXT;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(372, 32);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(59, 26);
            this.txtPkid.TabIndex = 90;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmPumps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lstWareHouse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPumpNote);
            this.Controls.Add(this.lstPumpStat);
            this.Controls.Add(this.nmbPumpCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPumpName);
            this.Controls.Add(this.txtPumpNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPumps";
            this.Tag = "frmPumps";
            this.Text = "تعريف الطرمبات";
            this.Titel = "تعريف الطرمبات";
            this.Load += new System.EventHandler(this.frmPumps_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPumpNo, 0);
            this.Controls.SetChildIndex(this.txtPumpName, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nmbPumpCounter, 0);
            this.Controls.SetChildIndex(this.lstPumpStat, 0);
            this.Controls.SetChildIndex(this.txtPumpNote, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.lstWareHouse, 0);
            this.Controls.SetChildIndex(this.lstItems, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmbPumpCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private SmallButton btnFind;
        private myText txtPumpNote;
        private myList lstPumpStat;
        private myNumber nmbPumpCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private myText txtPumpName;
        private myText txtPumpNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private myList lstWareHouse;
        private myList lstItems;
        private myText txtPkid;
    }
}
