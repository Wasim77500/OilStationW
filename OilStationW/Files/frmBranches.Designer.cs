namespace OilStationW.Files
{
    partial class frmBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranches));
            this.btnFind = new SmallButton();
            this.txtBranchNo = new myText();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new myText();
            this.txtBranchName = new myText();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtPkid = new myText();
            this.SuspendLayout();
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
            this.btnFind.Location = new System.Drawing.Point(5, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(26, 26);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtBranchNo
            // 
            this.txtBranchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBranchNo.Location = new System.Drawing.Point(33, 32);
            this.txtBranchNo.Name = "txtBranchNo";
            this.txtBranchNo.Size = new System.Drawing.Size(226, 26);
            this.txtBranchNo.TabIndex = 50;
            this.txtBranchNo.W_ColumnName = "";
            this.txtBranchNo.W_OldValue = "";
            this.txtBranchNo.w_Tran = myText.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(263, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "رقم الفرع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(263, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "اسم الفرع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(263, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "ملاحظات";
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNote.Location = new System.Drawing.Point(5, 98);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(254, 26);
            this.txtNote.TabIndex = 54;
            this.txtNote.W_ColumnName = "";
            this.txtNote.W_OldValue = "";
            this.txtNote.w_Tran = myText.Tran.None;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBranchName.Location = new System.Drawing.Point(5, 66);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(254, 26);
            this.txtBranchName.TabIndex = 55;
            this.txtBranchName.W_ColumnName = "";
            this.txtBranchName.W_OldValue = "";
            this.txtBranchName.w_Tran = myText.Tran.None;
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
            this.btnUpdate.Location = new System.Drawing.Point(99, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 59;
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
            this.btnClose.Location = new System.Drawing.Point(23, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 58;
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
            this.btnSave.Location = new System.Drawing.Point(175, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 57;
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
            this.btnNew.Location = new System.Drawing.Point(251, 136);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(150, 32);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(66, 26);
            this.txtPkid.TabIndex = 60;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtBranchNo);
            this.Controls.Add(this.label1);
            this.Name = "frmBranches";
            this.Tag = "frmBranches";
            this.Text = "الفروع";
            this.Titel = "الفروع";
            this.Load += new System.EventHandler(this.frmBranches_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBranchNo, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.txtBranchName, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmallButton btnFind;
        private myText txtBranchNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private myText txtNote;
        private myText txtBranchName;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtPkid;
    }
}
