namespace OilStationW
{
    partial class myForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.myLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBotom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.myLabel1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Location = new System.Drawing.Point(12, 7);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(373, 26);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.myLabel1.ForeColor = System.Drawing.Color.Chocolate;
            this.myLabel1.Location = new System.Drawing.Point(68, 3);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(91, 21);
            this.myLabel1.TabIndex = 7;
            this.myLabel1.Text = "عنوان الشاشة";
            this.myLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.myLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.myLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OilStationW.Properties.Resources.Delete;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(175, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::OilStationW.Properties.Resources.Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(264, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Location = new System.Drawing.Point(321, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(2, 41);
            this.pnlLeft.TabIndex = 6;
            // 
            // pnlBotom
            // 
            this.pnlBotom.BackColor = System.Drawing.Color.Black;
            this.pnlBotom.Location = new System.Drawing.Point(55, 216);
            this.pnlBotom.Name = "pnlBotom";
            this.pnlBotom.Size = new System.Drawing.Size(273, 2);
            this.pnlBotom.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Black;
            this.pnlRight.Location = new System.Drawing.Point(327, 117);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(2, 41);
            this.pnlRight.TabIndex = 4;
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(492, 347);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBotom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myForm";
            this.Load += new System.EventHandler(this.myForm_Load);
            this.Resize += new System.EventHandler(this.myForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBotom;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label myLabel1;
    }
}