using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Another_Brick_Off_The_Wall
{
    public partial class ExitForm : Form
    {
        public bool Exit { get; set; }

        public ExitForm()
        {
            Exit = false;
            InitializeComponent();
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            Exit = false;
            this.Close();
        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            Exit = true;
            this.Close();
        }

        private void lblNo_MouseMove(object sender, MouseEventArgs e)
        {
            lblNo.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void lblNo_MouseLeave(object sender, EventArgs e)
        {
            lblNo.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lblYes_MouseLeave(object sender, EventArgs e)
        {
            lblYes.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lblYes_MouseMove(object sender, MouseEventArgs e)
        {
            lblYes.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }
    }
}
