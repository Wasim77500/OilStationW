using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationW
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void myForm_Load(object sender, EventArgs e)
        {

        }
        public string Titel
        {
            get { return this.myLabel1.Text; }
            set { this.myLabel1.Text = value; }

        }
        private void myForm_Resize(object sender, EventArgs e)
        {
           
            pnlTop.Width = this.Width;

            pnlTop.Top = 0;
            pnlTop.Left = 0;
            pictureBox1.Top = pnlTop.Height / 2 - pictureBox1.Height / 2;
            pictureBox1.Left = pnlRight.Width;
          
            pnlBotom.Width = this.Width;
            pnlBotom.Left = 0;
            pnlBotom.Top = this.Height - pnlBotom.Height;

            pnlLeft.Height = this.Height - pnlTop.Height;
            pnlLeft.Left = 0;
            pnlLeft.Top = pnlTop.Height;

            pnlRight.Height = this.Height - pnlTop.Height;
            pnlRight.Left = this.Width - 2;
            pnlRight.Top = pnlTop.Height;


            pictureBox2.Left = this.Width - pictureBox2.Width - pnlLeft.Width;
            pictureBox2.Top = pnlTop.Height / 2 - pictureBox2.Height / 2;

            myLabel1.Left = this.Width - myLabel1.Width - pictureBox2.Width;

        }
        private bool mouseIsDown = false;
        private Point firstPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                firstPoint = e.Location;
                mouseIsDown = true;


            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown == true)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void lstTemplet_MorePrivilleges(object sender, EventArgs e)
        {
            //تستخدم هذه الدالة للتعامل مع الصلاحيات الخاصة للشاشة
        }


    }
}
