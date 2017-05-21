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
        private Level level;

        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 600;

            radioBtnEasy.Checked = true;
            img = Resources.newGame_window_background;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            btnNewGame.SetBounds(this.Width / 2 - 150, this.Height - 500, 325, 65);

            groupBoxRadioBtns.SetBounds(this.Width / 2 - 150, this.Height - 425, 325, 65);

            btnContinueLastGame.SetBounds(this.Width / 2 - 150, this.Height - 345, 325, 65);
            btnHighScores.SetBounds(this.Width / 2 - 150, this.Height - 265, 325, 65);
            btnAbout.SetBounds(this.Width / 2 - 150, this.Height - 185, 325, 65);
            btnExit.SetBounds(this.Width / 2 - 150, this.Height - 105, 325, 65);
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
            shf.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (radioBtnEasy.Checked)
                level = new Level1();
            else if (radioBtnMedium.Checked)
                level = new Level2();
            else
                level = new Level3();

            NewGame gf = new NewGame(level);

            this.Hide();
            this.AddOwnedForm(gf);
            gf.ShowDialog();
            this.Show();
            this.RemoveOwnedForm(gf);
        }




    }
}
