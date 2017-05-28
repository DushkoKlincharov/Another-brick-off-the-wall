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
    public partial class EnterName : Form
    {
        public string PlayerName { get; set; }

        public EnterName()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            PlayerName = tbEnterName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
