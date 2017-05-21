using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Another_Brick_Off_The_Wall.Properties;

namespace Another_Brick_Off_The_Wall
{
    public partial class Form1 : Form
    {
        private Image img;

        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            this.Width = 900;
            this.Height = 600;

            img = Resources.newGame_window_background;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            btnNewGame.SetBounds(this.Width / 2 - 150, this.Height - 500, 250, 65);
            btnContinueLastGame.SetBounds(this.Width / 2 - 150, this.Height - 425, 250, 65);
            btnHighScores.SetBounds(this.Width / 2 - 150, this.Height - 345, 250, 65);
            btnAbout.SetBounds(this.Width / 2 - 150, this.Height - 265, 250, 65);
            btnExit.SetBounds(this.Width / 2 - 150, this.Height - 185, 250, 65);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = img;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm ef = new ExitForm();
            this.AddOwnedForm(ef);
            ef.ShowDialog();
            if (ef.Exit)
                this.Close();
            this.RemoveOwnedForm(ef);
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScoresForm shf = new HighScoresForm();
            this.AddOwnedForm(shf);
            shf.ShowDialog();
            this.RemoveOwnedForm(shf);
        }




    }
}
