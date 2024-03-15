using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        private int transparencyLevel = 100;
        private Color backgroundColor = Color.LightGray;

        public Form1()
        {
            InitializeComponent();
            btnTransparency.Click += new EventHandler(btnControl_Click);
            btnColor.Click += new EventHandler(btnControl_Click);
            btnHelloWorld.Click += new EventHandler(btnControl_Click);
            btnSuperMegaButton.Click += new EventHandler(btnControl_Click);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (sender == btnTransparency)
            {
                ChangeTransparency();
            }
            else if (sender == btnColor)
            {
                ChangeBackgroundColor();
            }
            else if (sender == btnHelloWorld)
            {
                ShowHelloWorldMessage();
            }
            else if (sender == btnSuperMegaButton)
            {
                CheckChoose(e);
            }
        }
        private void ChangeTransparency()
        {
            transparencyLevel = (transparencyLevel == 100) ? 50 : 100;
            this.Opacity = transparencyLevel / 100.0;
        }

        private void ChangeBackgroundColor()
        {
            backgroundColor = (backgroundColor == Color.LightGray) ? Color.Yellow : Color.LightGray;
            this.BackColor = backgroundColor;
        }

        private void ShowHelloWorldMessage()
        {
            MessageBox.Show("Hello, World!");
        }
        private void CheckChoose(EventArgs e)
        {
            if (chkChangeTransparency.Checked)
            {
                btnControl_Click(btnTransparency, e);
            }
            if (chkChangeColor.Checked)
            {
                btnControl_Click(btnColor, e);
            }
            if (chkChangeHelloWorld.Checked)
            {
                btnControl_Click(btnHelloWorld, e);
            }
        }

        private void btnSuperMegaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am the super mega button!\nYou can't get rid of me!");
        }

    }
}