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
    public partial class GameForm : Form
    {
        private Scene scene;

        public GameForm(Level level)
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Width = this.Owner.Width;
            this.Height = this.Owner.Height;
        }
    }
}
