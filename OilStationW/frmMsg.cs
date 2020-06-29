using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW
{
    public partial class frmMsg : Form
    {
        
        public frmMsg()
        {
            InitializeComponent();
        }

        private void frmMsg_Load(object sender, EventArgs e)
        {

            
            // this.Size = new System.Drawing.Size(lblMsg.Width + 10, lblMsg.Height + gbBut.Height + 60);


            // lblMsg.Left = (this.ClientSize.Width - lblMsg.Width) / 2;
            // gbBut.Top = lblMsg.Location.Y + lblMsg.Size.Height + 10;
            // gbBut.Left = (this.ClientSize.Width - gbBut.Width) / 2;
            //// lblMsg.Top = (this.ClientSize.Height - lblMsg.Height) / 2;
            // this.CenterToParent();


            this.Size = new System.Drawing.Size(lblMsg.Width + 50, lblMsg.Height + gbBut.Height + 100);


            lblMsg.Left = (this.ClientSize.Width - lblMsg.Width) / 2;
            gbBut.Top =pnlTop.Height + lblMsg.Location.Y + lblMsg.Size.Height + 10;
            gbBut.Left = (this.ClientSize.Width - gbBut.Width) / 2;
            

            Resize();
            this.CenterToParent();
            //myLabel1.Left = this.Size.Width - myLabel1.Width;


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            glb_function.blMsg = true;
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            glb_function.blMsg = false;
            this.Close();
        }

        private void pnlMessage_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Resize()
        {

            pnlTop.Width = this.Width;

            pnlTop.Top = 0;
            pnlTop.Left = 0;
          

            pnlBotom.Width = this.Width;
            pnlBotom.Left = 0;
            pnlBotom.Top = this.Height - pnlBotom.Height-2;

            pnlLeft.Height = this.Height - pnlTop.Height;
            pnlLeft.Left = 0;
            pnlLeft.Top = pnlTop.Height;

            pnlRight.Height = this.Height - pnlTop.Height;
            pnlRight.Left = this.Width - 4;
            pnlRight.Top = pnlTop.Height;




            myLabel1.Left = this.Width - myLabel1.Width;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
