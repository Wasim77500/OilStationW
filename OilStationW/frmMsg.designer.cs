namespace OilStationW
{
    partial class frmMsg
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.gbBut = new System.Windows.Forms.GroupBox();
            this.btnOk = new MainButton();
            this.btnYes = new MainButton();
            this.btnNO = new MainButton();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBotom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.myLabel1 = new System.Windows.Forms.Label();
            this.gbBut.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblMsg.ForeColor = System.Drawing.Color.Maroon;
            this.lblMsg.Location = new System.Drawing.Point(41, 55);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(36, 25);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "....";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBut
            // 
            this.gbBut.BackColor = System.Drawing.Color.Transparent;
            this.gbBut.Controls.Add(this.btnOk);
            this.gbBut.Controls.Add(this.btnYes);
            this.gbBut.Controls.Add(this.btnNO);
            this.gbBut.Location = new System.Drawing.Point(115, 109);
            this.gbBut.Name = "gbBut";
            this.gbBut.Size = new System.Drawing.Size(174, 57);
            this.gbBut.TabIndex = 4;
            this.gbBut.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnOk.ForeColor = System.Drawing.Color.Chocolate;
            this.btnOk.Location = new System.Drawing.Point(41, 13);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnYes.FlatAppearance.BorderSize = 2;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnYes.ForeColor = System.Drawing.Color.Chocolate;
            this.btnYes.Location = new System.Drawing.Point(87, 13);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 35);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "نعم";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Black;
            this.btnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNO.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnNO.FlatAppearance.BorderSize = 2;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNO.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnNO.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNO.Location = new System.Drawing.Point(6, 13);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 35);
            this.btnNO.TabIndex = 4;
            this.btnNO.Text = "لا";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.Beige;
            this.pnlMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessage.Controls.Add(this.pnlLeft);
            this.pnlMessage.Controls.Add(this.pnlBotom);
            this.pnlMessage.Controls.Add(this.pnlRight);
            this.pnlMessage.Controls.Add(this.pnlTop);
            this.pnlMessage.Controls.Add(this.gbBut);
            this.pnlMessage.Controls.Add(this.lblMsg);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessage.Location = new System.Drawing.Point(0, 0);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(407, 192);
            this.pnlMessage.TabIndex = 5;
            this.pnlMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessage_Paint);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Location = new System.Drawing.Point(331, 22);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(2, 41);
            this.pnlLeft.TabIndex = 9;
            // 
            // pnlBotom
            // 
            this.pnlBotom.BackColor = System.Drawing.Color.Black;
            this.pnlBotom.Location = new System.Drawing.Point(60, 185);
            this.pnlBotom.Name = "pnlBotom";
            this.pnlBotom.Size = new System.Drawing.Size(273, 2);
            this.pnlBotom.TabIndex = 7;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Black;
            this.pnlRight.Location = new System.Drawing.Point(337, 67);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(2, 41);
            this.pnlRight.TabIndex = 8;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.myLabel1);
            this.pnlTop.Location = new System.Drawing.Point(3, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(399, 26);
            this.pnlTop.TabIndex = 5;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(68, 3);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(76, 21);
            this.myLabel1.TabIndex = 7;
            this.myLabel1.Text = "رسالة تنبية";
            // 
            // frmMsg
            // 
            this.ClientSize = new System.Drawing.Size(407, 192);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMsg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".";
            this.Load += new System.EventHandler(this.frmMsg_Load);
            this.gbBut.ResumeLayout(false);
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox gbBut;
        private System.Windows.Forms.Panel pnlMessage;
        public MainButton btnOk;
        public MainButton btnYes;
        public MainButton btnNO;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label myLabel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBotom;
        private System.Windows.Forms.Panel pnlRight;
    }
}
