namespace OilStationW.Sales
{
    partial class frmCustomers
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
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.btnFind = new SmallButton();
            this.txtAddress2 = new myText();
            this.txtTel2 = new myText();
            this.txtCustName = new myText();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustNote = new myText();
            this.lstAccName = new myList();
            this.lstAccNo = new myList();
            this.txtAddress1 = new myText();
            this.txtTel1 = new myText();
            this.txtCustNo = new myText();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPkid = new myText();
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
            this.btnUpdate.Location = new System.Drawing.Point(197, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 99;
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
            this.btnClose.Location = new System.Drawing.Point(121, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 98;
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
            this.btnSave.Location = new System.Drawing.Point(273, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 97;
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
            this.btnNew.Location = new System.Drawing.Point(349, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 96;
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
            this.btnFind.Image = global::OilStationW.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(291, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 95;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(4, 59);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(193, 26);
            this.txtAddress2.TabIndex = 94;
            this.txtAddress2.W_ColumnName = "";
            this.txtAddress2.W_OldValue = "";
            this.txtAddress2.w_Tran = myText.Tran.None;
            // 
            // txtTel2
            // 
            this.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTel2.Location = new System.Drawing.Point(4, 88);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(193, 26);
            this.txtTel2.TabIndex = 93;
            this.txtTel2.W_ColumnName = "";
            this.txtTel2.W_OldValue = "";
            this.txtTel2.w_Tran = myText.Tran.None;
            // 
            // txtCustName
            // 
            this.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustName.Location = new System.Drawing.Point(4, 30);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(193, 26);
            this.txtCustName.TabIndex = 92;
            this.txtCustName.W_ColumnName = "";
            this.txtCustName.W_OldValue = "";
            this.txtCustName.w_Tran = myText.Tran.None;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(200, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 91;
            this.label8.Text = "العنوان الثاني";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(203, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "رقم التلفون2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(203, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 89;
            this.label6.Text = "اسم العميل";
            // 
            // txtCustNote
            // 
            this.txtCustNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustNote.Location = new System.Drawing.Point(4, 146);
            this.txtCustNote.Name = "txtCustNote";
            this.txtCustNote.Size = new System.Drawing.Size(444, 26);
            this.txtCustNote.TabIndex = 88;
            this.txtCustNote.W_ColumnName = "";
            this.txtCustNote.W_OldValue = "";
            this.txtCustNote.w_Tran = myText.Tran.None;
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(4, 117);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(316, 26);
            this.lstAccName.TabIndex = 87;
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
            this.lstAccNo.Location = new System.Drawing.Point(321, 117);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(127, 26);
            this.lstAccNo.TabIndex = 86;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(291, 59);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(157, 26);
            this.txtAddress1.TabIndex = 85;
            this.txtAddress1.W_ColumnName = "";
            this.txtAddress1.W_OldValue = "";
            this.txtAddress1.w_Tran = myText.Tran.None;
            // 
            // txtTel1
            // 
            this.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTel1.Location = new System.Drawing.Point(291, 88);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(157, 26);
            this.txtTel1.TabIndex = 84;
            this.txtTel1.W_ColumnName = "";
            this.txtTel1.W_OldValue = "";
            this.txtTel1.w_Tran = myText.Tran.None;
            // 
            // txtCustNo
            // 
            this.txtCustNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCustNo.Location = new System.Drawing.Point(321, 30);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(127, 26);
            this.txtCustNo.TabIndex = 83;
            this.txtCustNo.W_ColumnName = "";
            this.txtCustNo.W_OldValue = "";
            this.txtCustNo.w_Tran = myText.Tran.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(462, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 82;
            this.label5.Text = "ملاحظات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(469, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 81;
            this.label4.Text = "الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(455, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "رقم التلفون1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(457, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 79;
            this.label2.Text = "العنوان الاول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(462, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "رقم العميل";
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(380, 30);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(35, 26);
            this.txtPkid.TabIndex = 100;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 221);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustNote);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomers";
            this.Tag = "frmCustomers";
            this.Text = "العملاء";
            this.Titel = "العملاء";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCustNo, 0);
            this.Controls.SetChildIndex(this.txtTel1, 0);
            this.Controls.SetChildIndex(this.txtAddress1, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtCustNote, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtCustName, 0);
            this.Controls.SetChildIndex(this.txtTel2, 0);
            this.Controls.SetChildIndex(this.txtAddress2, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private SmallButton btnFind;
        private myText txtAddress2;
        private myText txtTel2;
        private myText txtCustName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private myText txtCustNote;
        private myList lstAccName;
        private myList lstAccNo;
        private myText txtAddress1;
        private myText txtTel1;
        private myText txtCustNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private myText txtPkid;
    }
}
