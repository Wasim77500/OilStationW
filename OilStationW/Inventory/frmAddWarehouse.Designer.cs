namespace OilStationW.Inventory
{
    partial class frmAddWarehouse
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstBranches = new myList();
            this.txtWareHouseNo = new myText();
            this.txtWareHouseName = new myText();
            this.txtWarehouseNote = new myText();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new MainButton();
            this.btnClose = new MainButton();
            this.btnSave = new MainButton();
            this.btnNew = new MainButton();
            this.txtPkid = new myText();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(226, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 293;
            this.label2.Text = "الفــــرع";
            // 
            // lstBranches
            // 
            this.lstBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBranches.Font = new System.Drawing.Font("Arial", 12F);
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(12, 36);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(196, 26);
            this.lstBranches.TabIndex = 294;
            this.lstBranches.W_ColumnName = "";
            this.lstBranches.W_OldValue = "";
            this.lstBranches.w_Tran = myList.Tran.None;
            this.lstBranches.w_ValueType = myList.ValueType.TEXT;
            this.lstBranches.SelectedIndexChanged += new System.EventHandler(this.lstBranches_SelectedIndexChanged);
            // 
            // txtWareHouseNo
            // 
            this.txtWareHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWareHouseNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWareHouseNo.Location = new System.Drawing.Point(12, 65);
            this.txtWareHouseNo.Name = "txtWareHouseNo";
            this.txtWareHouseNo.Size = new System.Drawing.Size(196, 26);
            this.txtWareHouseNo.TabIndex = 295;
            this.txtWareHouseNo.W_ColumnName = "";
            this.txtWareHouseNo.W_OldValue = "";
            this.txtWareHouseNo.w_Tran = myText.Tran.None;
            this.txtWareHouseNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWareHouseNo_KeyDown);
            // 
            // txtWareHouseName
            // 
            this.txtWareHouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWareHouseName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWareHouseName.Location = new System.Drawing.Point(12, 94);
            this.txtWareHouseName.Name = "txtWareHouseName";
            this.txtWareHouseName.Size = new System.Drawing.Size(196, 26);
            this.txtWareHouseName.TabIndex = 296;
            this.txtWareHouseName.W_ColumnName = "";
            this.txtWareHouseName.W_OldValue = "";
            this.txtWareHouseName.w_Tran = myText.Tran.None;
            // 
            // txtWarehouseNote
            // 
            this.txtWarehouseNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseNote.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWarehouseNote.Location = new System.Drawing.Point(12, 123);
            this.txtWarehouseNote.Name = "txtWarehouseNote";
            this.txtWarehouseNote.Size = new System.Drawing.Size(196, 26);
            this.txtWarehouseNote.TabIndex = 297;
            this.txtWarehouseNote.W_ColumnName = "";
            this.txtWarehouseNote.W_OldValue = "";
            this.txtWarehouseNote.w_Tran = myText.Tran.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(213, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 298;
            this.label1.Text = "مـلاحـظـات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(214, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 299;
            this.label3.Text = "اسم المخزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(214, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 300;
            this.label4.Text = "رقم المخزن";
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
            this.btnUpdate.Location = new System.Drawing.Point(81, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 304;
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
            this.btnClose.Location = new System.Drawing.Point(5, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 303;
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
            this.btnSave.Location = new System.Drawing.Point(157, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 302;
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
            this.btnNew.Location = new System.Drawing.Point(233, 157);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 301;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPkid
            // 
            this.txtPkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPkid.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPkid.Location = new System.Drawing.Point(68, 65);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(46, 26);
            this.txtPkid.TabIndex = 305;
            this.txtPkid.Visible = false;
            this.txtPkid.W_ColumnName = "";
            this.txtPkid.W_OldValue = "";
            this.txtPkid.w_Tran = myText.Tran.None;
            // 
            // frmAddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(315, 196);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWarehouseNote);
            this.Controls.Add(this.txtWareHouseName);
            this.Controls.Add(this.txtWareHouseNo);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.label2);
            this.Name = "frmAddWarehouse";
            this.Tag = "frmAddWarehouse";
            this.Text = "تعريف المخازن";
            this.Titel = "تعريف المخازن";
            this.Load += new System.EventHandler(this.frmAddWarehouse_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lstBranches, 0);
            this.Controls.SetChildIndex(this.txtWareHouseNo, 0);
            this.Controls.SetChildIndex(this.txtWareHouseName, 0);
            this.Controls.SetChildIndex(this.txtWarehouseNote, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtPkid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private myList lstBranches;
        private myText txtWareHouseNo;
        private myText txtWareHouseName;
        private myText txtWarehouseNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MainButton btnUpdate;
        private MainButton btnClose;
        private MainButton btnSave;
        private MainButton btnNew;
        private myText txtPkid;
    }
}
