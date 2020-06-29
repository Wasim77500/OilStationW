namespace OilStationW.Reports
{
    partial class frmItemTrans
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstWarehouses = new myList();
            this.lstItems = new myList();
            this.btnClose = new MainButton();
            this.btnPrint = new MainButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(266, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(267, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 76;
            this.label1.Text = "المخزن";
            // 
            // lstWarehouses
            // 
            this.lstWarehouses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstWarehouses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWarehouses.Font = new System.Drawing.Font("Arial", 12F);
            this.lstWarehouses.FormattingEnabled = true;
            this.lstWarehouses.Location = new System.Drawing.Point(12, 38);
            this.lstWarehouses.Name = "lstWarehouses";
            this.lstWarehouses.Size = new System.Drawing.Size(249, 26);
            this.lstWarehouses.TabIndex = 77;
            this.lstWarehouses.W_ColumnName = "";
            this.lstWarehouses.W_OldValue = "";
            this.lstWarehouses.w_Tran = myList.Tran.None;
            this.lstWarehouses.w_ValueType = myList.ValueType.TEXT;
            // 
            // lstItems
            // 
            this.lstItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstItems.Font = new System.Drawing.Font("Arial", 12F);
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 67);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(249, 26);
            this.lstItems.TabIndex = 78;
            this.lstItems.W_ColumnName = "";
            this.lstItems.W_OldValue = "";
            this.lstItems.w_Tran = myList.Tran.None;
            this.lstItems.w_ValueType = myList.ValueType.TEXT;
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
            this.btnClose.Location = new System.Drawing.Point(104, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPrint.Location = new System.Drawing.Point(180, 113);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmItemTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(358, 167);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lstWarehouses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmItemTrans";
            this.Tag = "frmItemTrans";
            this.Text = "متابعة حركة الأصناف";
            this.Titel = "متابعة حركة الأصناف";
            this.Load += new System.EventHandler(this.frmItemTrans_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lstWarehouses, 0);
            this.Controls.SetChildIndex(this.lstItems, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private myList lstWarehouses;
        private myList lstItems;
        private MainButton btnClose;
        private MainButton btnPrint;
    }
}
