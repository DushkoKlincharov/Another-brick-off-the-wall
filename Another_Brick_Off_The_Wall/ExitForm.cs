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

        private void btnYES_Click(object sender, EventArgs e)
        {
            Exit = true;
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            Exit = false;
            this.Close();
        }
    }
}
