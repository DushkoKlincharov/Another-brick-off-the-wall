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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lblOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOk_MouseMove(object sender, MouseEventArgs e)
        {
            lblOk.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void lblOk_MouseLeave(object sender, EventArgs e)
        {
            lblOk.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

    }
}
