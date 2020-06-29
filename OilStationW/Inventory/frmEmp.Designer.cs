namespace OilStationW.Inventory
{
    partial class frmEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtEmpNo = new myText();
            this.txtAddress = new myText();
            this.txtEmpName = new myText();
            this.txtTel = new myText();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFind = new SmallButton();
            this.lstBranches = new myList();
            this.lstAccNo = new myList();
            this.lstAccName = new myList();
            this.txtEmpNote = new myText();
            this.txtPkid = new myText();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(461, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "رقم العامل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(462, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(465, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "الفــرع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(461, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "رقم الحساب";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(461, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "مـلاحـظـات";
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
            this.btnUpdate.Location = new System.Drawing.Point(201, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 63;
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
            this.btnClose.Location = new System.Drawing.Point(125, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 62;
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
            this.btnSave.Location = new System.Drawing.Point(277, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 61;
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
            this.btnNew.Location = new System.Drawing.Point(353, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 60;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpNo.Location = new System.Drawing.Point(313, 32);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(142, 26);
            this.txtEmpNo.TabIndex = 64;
            this.txtEmpNo.W_ColumnName = "";
            this.txtEmpNo.W_OldValue = "";
            this.txtEmpNo.w_Tran = myText.Tran.None;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress.Location = new System.Drawing.Point(285, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 26);
            this.txtAddress.TabIndex = 65;
            this.txtAddress.W_ColumnName = "";
            this.txtAddress.W_OldValue = "";
            this.txtAddress.w_Tran = myText.Tran.None;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpName.Location = new System.Drawing.Point(8, 32);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(187, 26);
            this.txtEmpName.TabIndex = 66;
            this.txtEmpName.W_ColumnName = "";
            this.txtEmpName.W_OldValue = "";
            this.txtEmpName.w_Tran = myText.Tran.None;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTel.Location = new System.Drawing.Point(8, 61);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(187, 26);
            this.txtTel.TabIndex = 67;
            this.txtTel.W_ColumnName = "";
            this.txtTel.W_OldValue = "";
            this.txtTel.w_Tran = myText.Tran.None;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(201, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "اسم العامل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(201, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 69;
            this.label7.Text = "رقم التلفون";
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
            this.btnFind.Location = new System.Drawing.Point(285, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 70;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstBranches
            // 
            this.lstBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBranches.Font = new System.Drawing.Font("Arial", 12F);
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(285, 90);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(170, 26);
            this.lstBranches.TabIndex = 71;
            this.lstBranches.W_ColumnName = "";
            this.lstBranches.W_OldValue = "";
            this.lstBranches.w_Tran = myList.Tran.None;
            this.lstBranches.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstAccNo
            // 
            this.lstAccNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccNo.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccNo.FormattingEnabled = true;
            this.lstAccNo.Location = new System.Drawing.Point(285, 119);
            this.lstAccNo.Name = "lstAccNo";
            this.lstAccNo.Size = new System.Drawing.Size(170, 26);
            this.lstAccNo.TabIndex = 72;
            this.lstAccNo.W_ColumnName = "";
            this.lstAccNo.W_OldValue = "";
            this.lstAccNo.w_Tran = myList.Tran.None;
            this.lstAccNo.w_ValueType = myList.ValueType.TEXT;
            this.lstAccNo.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // lstAccName
            // 
            this.lstAccName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstAccName.Font = new System.Drawing.Font("Arial", 12F);
            this.lstAccName.FormattingEnabled = true;
            this.lstAccName.Location = new System.Drawing.Point(8, 119);
            this.lstAccName.Name = "lstAccName";
            this.lstAccName.Size = new System.Drawing.Size(275, 26);
            this.lstAccName.TabIndex = 73;
            this.lstAccName.W_ColumnName = "";
            this.lstAccName.W_OldValue = "";
            this.lstAccName.w_Tran = myList.Tran.None;
            this.lstAccName.w_ValueType = myList.ValueType.TEXT;
            this.lstAccName.SelectedIndexChanged += new System.EventHandler(this.lstAccNo_SelectedIndexChanged);
            // 
            // txtEmpNote
            // 
            this.txtEmpNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmpNote.Location = new System.Drawing.Point(8, 148);
            this.txtEmpNote.Name = "txtEmpNote";
            this.txtEmpNote.Size = new System.Drawing.Size(447, 26);
            this.txtEmpNote.TabIndex = 74;
            this.txtEmpNote.W_ColumnName = "";
            this.txtEmpNote.W_OldValue = "";
            this.txtEmpNote.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(353, 32);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(67, 26);
            this.txtPkid.TabIndex = 75;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 222);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.txtEmpNote);
            this.Controls.Add(this.lstAccName);
            this.Controls.Add(this.lstAccNo);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmp";
            this.Tag = "frmEmp";
            this.Text = "أمناء المخازن والعمال";
            this.Titel = "أمناء المخازن والعمال";
            this.Load += new System.EventHandler(this.frmEmp_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtEmpNo, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.txtEmpName, 0);
            this.Controls.SetChildIndex(this.txtTel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.lstBranches, 0);
            this.Controls.SetChildIndex(this.lstAccNo, 0);
            this.Controls.SetChildIndex(this.lstAccName, 0);
            this.Controls.SetChildIndex(this.txtEmpNote, 0);
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
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtEmpNo;
        private myText txtAddress;
        private myText txtEmpName;
        private myText txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private SmallButton btnFind;
        private myList lstBranches;
        private myList lstAccNo;
        private myList lstAccName;
        private myText txtEmpNote;
        private myText txtPkid;
    }
}
