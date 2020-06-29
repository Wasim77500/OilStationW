using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

public class MainButton : Button
{
      
    public MainButton()
       {
         this.Size = new System.Drawing.Size(75, 35);
        this.FlatStyle = FlatStyle.Flat;
      
        this.FlatAppearance.BorderSize = 2;
        this.FlatAppearance.BorderColor = Color.Chocolate;
        this.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
        this.FlatAppearance.MouseOverBackColor = Color.Chocolate;

          this.Font = new System.Drawing.Font("Times New Roman", 14);
          this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.BackColor = System.Drawing.Color.Black;
        this.ForeColor = Color.Chocolate;
       
       
        this.Cursor = Cursors.Hand;
        
        this.MouseHover += new System.EventHandler(this.mouseHover);
        this.MouseLeave += new System.EventHandler(this.mouseLeave);
        this.EnabledChanged += MainButton_EnabledChanged;
    }

    private void MainButton_EnabledChanged(object sender, EventArgs e)
    {
        if (this.Enabled)
            this.BackColor = Color.Black;
        else
            this.BackColor = Color.Beige;
    }

    private void mouseLeave(object sender, EventArgs e)
    {
        this.FlatAppearance.BorderColor = Color.Chocolate;
        this.BackColor = Color.Black;
        this.ForeColor = Color.Chocolate;

    }
    private void mouseHover(object sender,EventArgs e)
    {
        this.FlatAppearance.BorderColor = Color.Black;
        this.BackColor = Color.Chocolate;
        this.ForeColor = Color.Black;
        
    }



}

class SmallButton : Button
{

    public SmallButton()
    {
        this.Size = new System.Drawing.Size(26, 26);

        
        this.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.BackColor = System.Drawing.Color.FromArgb(209, 174, 144); 


        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.FlatAppearance.BorderSize = 1;
        this.FlatAppearance.MouseOverBackColor = Color.Chocolate;
        this.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
        this.Cursor = Cursors.Hand;

        this.MouseHover += new System.EventHandler(this.mouseHover);
        this.MouseLeave += new System.EventHandler(this.mouseLeave);
    }


    private void mouseLeave(object sender, EventArgs e)
    {

          this.BackColor = System.Drawing.Color.FromArgb(209, 174, 144);
        

    }
    private void mouseHover(object sender, EventArgs e)
    {

        this.BackColor = Color.Chocolate;
        
        

    }



}