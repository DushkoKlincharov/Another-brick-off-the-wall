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

        private void lblEnter_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            PlayerName = tbEnterName.Text;
            DialogResult = DialogResult.OK;
        }

        private void lblEnter_MouseMove(object sender, MouseEventArgs e)
        {
            lblEnter.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void lblEnter_MouseLeave(object sender, EventArgs e)
        {
            lblEnter.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void tbEnterName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lblEnter_Click(null, null);
        }

        private void tbEnterName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = tbEnterName.Text.Trim().Length == 0 ? true : false;
            errorProvider.SetError(tbEnterName, e.Cancel ? "Внесете име" : "");
        }
    }
}
