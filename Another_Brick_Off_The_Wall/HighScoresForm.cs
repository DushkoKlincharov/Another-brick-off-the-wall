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
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
            this.Font = new Font("Segoe print", 10.75F);
        }

        private void labelOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelOk_MouseMove(object sender, MouseEventArgs e)
        {
            labelOk.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void labelOk_MouseLeave(object sender, EventArgs e)
        {
            labelOk.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }
    }
}
