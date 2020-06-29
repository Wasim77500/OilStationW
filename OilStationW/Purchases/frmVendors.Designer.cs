namespace OilStationW.Purchases
{
    partial class frmVendors
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendorNo = new myText();
            this.txtTel1 = new myText();
            this.txtAddress1 = new myText();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.txtVendorNote = new myText();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVendorName = new myText();
            this.txtTel2 = new myText();
            this.txtAddress2 = new myText();
            this.smallButton1 = new SmallButton();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtPkid = new myText();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(461, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "رقم المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(456, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "العنوان الاول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(454, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "رقم التلفون1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(468, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "الحساب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(461, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "ملاحظات";
            // 
            // txtVendorNo
            // 
            this.txtVendorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVendorNo.Location = new System.Drawing.Point(320, 31);
            this.txtVendorNo.Name = "txtVendorNo";
            this.txtVendorNo.Size = new System.Drawing.Size(127, 26);
            this.txtVendorNo.TabIndex = 61;
            this.txtVendorNo.W_ColumnName = "";
            this.txtVendorNo.W_OldValue = "";
            this.txtVendorNo.w_Tran = myText.Tran.None;
            // 
            // txtTel1
            // 
            this.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTel1.Location = new System.Drawing.Point(290, 89);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(157, 26);
            this.txtTel1.TabIndex = 62;
            this.txtTel1.W_ColumnName = "";
            this.txtTel1.W_OldValue = "";
            this.txtTel1.w_Tran = myText.Tran.None;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(290, 60);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(157, 26);
            this.txtAddress1.TabIndex = 63;
            this.txtAddress1.W_ColumnName = "";
            this.txtAddress1.W_OldValue = "";
            this.txtAddress1.w_Tran = myText.Tran.None;
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(3, 118);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(316, 26);
            this.lstAccName.TabIndex = 65;
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
            this.lstAccNo.Location = new System.Drawing.Point(320, 118);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(127, 26);
            this.lstAccNo.TabIndex = 64;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtVendorNote
            // 
            this.txtVendorNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVendorNote.Location = new System.Drawing.Point(3, 147);
            this.txtVendorNote.Name = "txtVendorNote";
            this.txtVendorNote.Size = new System.Drawing.Size(444, 26);
            this.txtVendorNote.TabIndex = 66;
            this.txtVendorNote.W_ColumnName = "";
            this.txtVendorNote.W_OldValue = "";
            this.txtVendorNote.w_Tran = myText.Tran.None;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(202, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "اسم المورد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(202, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "رقم التلفون2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(199, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 69;
            this.label8.Text = "العنوان الثاني";
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVendorName.Location = new System.Drawing.Point(3, 31);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(193, 26);
            this.txtVendorName.TabIndex = 70;
            this.txtVendorName.W_ColumnName = "";
            this.txtVendorName.W_OldValue = "";
            this.txtVendorName.w_Tran = myText.Tran.None;
            // 
            // txtTel2
            // 
            this.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTel2.Location = new System.Drawing.Point(3, 89);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(193, 26);
            this.txtTel2.TabIndex = 71;
            this.txtTel2.W_ColumnName = "";
            this.txtTel2.W_OldValue = "";
            this.txtTel2.w_Tran = myText.Tran.None;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(3, 60);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(193, 26);
            this.txtAddress2.TabIndex = 72;
            this.txtAddress2.W_ColumnName = "";
            this.txtAddress2.W_OldValue = "";
            this.txtAddress2.w_Tran = myText.Tran.None;
            // 
            // smallButton1
            // 
            this.smallButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.smallButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smallButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.smallButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.smallButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.smallButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallButton1.Image = global::OilStationW.Properties.Resources.Search;
            this.smallButton1.Location = new System.Drawing.Point(290, 30);
            this.smallButton1.Name = "smallButton1";
            this.smallButton1.Size = new System.Drawing.Size(26, 26);
            this.smallButton1.TabIndex = 73;
            this.smallButton1.UseVisualStyleBackColor = false;
            this.smallButton1.Click += new System.EventHandler(this.smallButton1_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(196, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 77;
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
            this.btnClose.Location = new System.Drawing.Point(120, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 76;
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
            this.btnSave.Location = new System.Drawing.Point(272, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 75;
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
            this.btnNew.Location = new System.Drawing.Point(348, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 74;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(363, 31);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(45, 26);
            this.txtPkid.TabIndex = 78;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 221);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.smallButton1);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVendorNote);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtVendorNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVendors";
            this.Tag = "frmVendors";
            this.Text = "الموردين";
            this.Titel = "الموردين";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtVendorNo, 0);
            this.Controls.SetChildIndex(this.txtTel1, 0);
            this.Controls.SetChildIndex(this.txtAddress1, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtVendorNote, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtVendorName, 0);
            this.Controls.SetChildIndex(this.txtTel2, 0);
            this.Controls.SetChildIndex(this.txtAddress2, 0);
            this.Controls.SetChildIndex(this.smallButton1, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private myText txtVendorNo;
        private myText txtTel1;
        private myText txtAddress1;
        private myList lstAccName;
        private myList lstAccNo;
        private myText txtVendorNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private myText txtVendorName;
        private myText txtTel2;
        private myText txtAddress2;
        private SmallButton smallButton1;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtPkid;
    }
}
