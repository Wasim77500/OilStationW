namespace OilStationW
{
    partial class frmTextDetail
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
            this.txtDetails = new myText();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDetails.Location = new System.Drawing.Point(3, 26);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(412, 463);
            this.txtDetails.TabIndex = 7;
            this.txtDetails.W_ColumnName = "";
            this.txtDetails.W_OldValue = "";
            this.txtDetails.w_Tran = myText.Tran.None;
            // 
            // frmTextDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(418, 492);
            this.Controls.Add(this.txtDetails);
            this.Name = "frmTextDetail";
            this.Titel = "البيان التفصيلي";
            this.Controls.SetChildIndex(this.txtDetails, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public myText txtDetails;
    }
}
