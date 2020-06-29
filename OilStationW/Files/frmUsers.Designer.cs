namespace OilStationW.Files
{
    partial class frmUsers
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tvTempletTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.lstBranches = new myList();
            this.txtUserName = new myText();
            this.txtUserLogin = new myText();
            this.txtPassword = new myText();
            this.txtNote = new myText();
            this.txtPkid = new myText();
            this.btnNew = new MainButton();
            this.btnChangePassword = new SmallButton();
            this.btnFind = new SmallButton();
            this.btnSave = new MainButton();
            this.btnClose = new MainButton();
            this.btnUpdate = new MainButton();
            ((System.ComponentModel.ISupportInitialize)(this.tvTempletTree)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(294, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(302, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "اسم الدخول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(305, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "كلمة السر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(317, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "الفــرع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(308, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "ملاحظات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(299, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "الصلاحيات";
            // 
            // tvTempletTree
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            treeNodeAdvStyleInfo1.ShowCheckBox = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.tvTempletTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvTempletTree.BeforeTouchSize = new System.Drawing.Size(277, 278);
            this.tvTempletTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvTempletTree.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tvTempletTree.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tvTempletTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvTempletTree.HelpTextControl.Name = "helpText";
            this.tvTempletTree.HelpTextControl.TabIndex = 0;
            this.tvTempletTree.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvTempletTree.Location = new System.Drawing.Point(8, 184);
            this.tvTempletTree.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvTempletTree.Name = "tvTempletTree";
            this.tvTempletTree.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvTempletTree.Size = new System.Drawing.Size(277, 278);
            this.tvTempletTree.TabIndex = 36;
            // 
            // 
            // 
            this.tvTempletTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvTempletTree.ToolTipControl.Name = "toolTip";
            this.tvTempletTree.ToolTipControl.TabIndex = 1;
            // 
            // lstBranches
            // 
            this.lstBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBranches.Font = new System.Drawing.Font("Arial", 12F);
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(8, 125);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(277, 26);
            this.lstBranches.TabIndex = 38;
            this.lstBranches.W_ColumnName = "";
            this.lstBranches.W_OldValue = "";
            this.lstBranches.w_Tran = myList.Tran.None;
            this.lstBranches.w_ValueType = myList.ValueType.TEXT;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUserName.Location = new System.Drawing.Point(36, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(249, 26);
            this.txtUserName.TabIndex = 39;
            this.txtUserName.W_ColumnName = "";
            this.txtUserName.W_OldValue = "";
            this.txtUserName.w_Tran = myText.Tran.None;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUserLogin.Location = new System.Drawing.Point(8, 65);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(277, 26);
            this.txtUserLogin.TabIndex = 40;
            this.txtUserLogin.W_ColumnName = "";
            this.txtUserLogin.W_OldValue = "";
            this.txtUserLogin.w_Tran = myText.Tran.None;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPassword.Location = new System.Drawing.Point(36, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(249, 26);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.Text = "123";
            this.txtPassword.W_ColumnName = "";
            this.txtPassword.W_OldValue = "";
            this.txtPassword.w_Tran = myText.Tran.None;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNote.Location = new System.Drawing.Point(8, 154);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(277, 26);
            this.txtNote.TabIndex = 42;
            this.txtNote.W_ColumnName = "";
            this.txtNote.W_OldValue = "";
            this.txtNote.w_Tran = myText.Tran.None;
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(302, 233);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(66, 26);
            this.txtPkid.TabIndex = 45;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
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
            this.btnNew.Location = new System.Drawing.Point(236, 464);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(174)))), ((int)(((byte)(144)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.Location = new System.Drawing.Point(8, 95);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(26, 26);
            this.btnChangePassword.TabIndex = 47;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
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
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(8, 35);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 48;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnSave.Location = new System.Drawing.Point(160, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(8, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(84, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(386, 511);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.tvTempletTree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsers";
            this.Tag = "frmUsers";
            this.Text = "مستخدمي النظام";
            this.Titel = "مستخدمي النظام";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tvTempletTree, 0);
            this.Controls.SetChildIndex(this.lstBranches, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtUserLogin, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnChangePassword, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tvTempletTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvTempletTree;
        private myList lstBranches;
        private myText txtUserName;
        private myText txtUserLogin;
        private myText txtPassword;
        private myText txtNote;
        private myText txtPkid;
        private MainButton btnNew;
        private SmallButton btnChangePassword;
        private SmallButton btnFind;
        private MainButton btnSave;
        private MainButton btnClose;
        private MainButton btnUpdate;
    }
}
