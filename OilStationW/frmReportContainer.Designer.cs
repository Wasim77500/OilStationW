namespace OilStationW
{
    partial class frmReportContainer
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
            this.CrystalReportsViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalReportsViewer1
            // 
            this.CrystalReportsViewer1.ActiveViewIndex = -1;
            this.CrystalReportsViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportsViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReportsViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReportsViewer1.Location = new System.Drawing.Point(0, 0);
            this.CrystalReportsViewer1.Name = "CrystalReportsViewer1";
            this.CrystalReportsViewer1.ShowCloseButton = false;
            this.CrystalReportsViewer1.ShowLogo = false;
            this.CrystalReportsViewer1.ShowParameterPanelButton = false;
            this.CrystalReportsViewer1.ShowTextSearchButton = false;
            this.CrystalReportsViewer1.ShowZoomButton = false;
            this.CrystalReportsViewer1.Size = new System.Drawing.Size(800, 450);
            this.CrystalReportsViewer1.TabIndex = 0;
            this.CrystalReportsViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrystalReportsViewer1);
            this.Name = "frmReportContainer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportsViewer1;
    }
}