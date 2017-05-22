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
    public partial class Form1 : Form
    {
        private Level level;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            if (radioBtnEasy.Checked)
                level = new Level1();
            else if (radioBtnMedium.Checked)
                level = new Level2();
            else
                level = new Level3();

            NewGame ng = new NewGame(level);

            this.AddOwnedForm(ng);
            this.Hide();
            ng.ShowDialog();
            this.Show();
            this.RemoveOwnedForm(ng);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            ExitForm ef = new ExitForm();
            this.AddOwnedForm(ef);
            ef.ShowDialog();
            this.RemoveOwnedForm(ef);
            if (ef.Exit)
                this.Close();
        }

        private void lblHighScores_Click(object sender, EventArgs e)
        {
            HighScoresForm hsf = new HighScoresForm();
            this.AddOwnedForm(hsf);
            hsf.ShowDialog();
            this.RemoveOwnedForm(hsf);
        }

        private void LabelMouseMove(Label label)
        {
            label.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void LabelMouseLeave(Label label)
        {
            label.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lblNewGame_MouseMove(object sender, MouseEventArgs e)
        {
            this.LabelMouseMove(lblNewGame);
        }

        private void lblNewGame_MouseLeave(object sender, EventArgs e)
        {
            this.LabelMouseLeave(lblNewGame);
        }

        private void lblContinueLastGame_MouseMove(object sender, MouseEventArgs e)
        {
            this.LabelMouseMove(lblContinueLastGame);
        }

        private void lblContinueLastGame_MouseLeave(object sender, EventArgs e)
        {
            this.LabelMouseLeave(lblContinueLastGame);
        }

        private void lblHighScores_MouseMove(object sender, MouseEventArgs e)
        {
            this.LabelMouseMove(lblHighScores);
        }

        private void lblHighScores_MouseLeave(object sender, EventArgs e)
        {
            this.LabelMouseLeave(lblHighScores);
        }

        private void lblAbout_MouseMove(object sender, MouseEventArgs e)
        {
            this.LabelMouseMove(lblAbout);
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            this.LabelMouseLeave(lblAbout);
        }

        private void lblExit_MouseMove(object sender, MouseEventArgs e)
        {
            this.LabelMouseMove(lblExit);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            this.LabelMouseLeave(lblExit);
        }

        private void RadioButtonMouseMove(RadioButton radioButton)
        {
            radioButton.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void RadioButtonMouseLeave(RadioButton radioButton)
        {
            radioButton.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void radioBtnEasy_MouseMove(object sender, MouseEventArgs e)
        {
            this.RadioButtonMouseMove(radioBtnEasy);
        }

        private void radioBtnEasy_MouseLeave(object sender, EventArgs e)
        {
            this.RadioButtonMouseLeave(radioBtnEasy);
        }

        private void radioBtnMedium_MouseMove(object sender, MouseEventArgs e)
        {
            this.RadioButtonMouseMove(radioBtnMedium);
        }

        private void radioBtnMedium_MouseLeave(object sender, EventArgs e)
        {
            this.RadioButtonMouseLeave(radioBtnMedium);
        }

        private void radioBtnHard_MouseMove(object sender, MouseEventArgs e)
        {
            this.RadioButtonMouseMove(radioBtnHard);
        }

        private void radioBtnHard_MouseLeave(object sender, EventArgs e)
        {
            this.RadioButtonMouseLeave(radioBtnHard);
        }

        private void ResizeLabels()
        {
            lblTitle.SetBounds((int)(this.Width * 0.5) - lblTitle.Width / 2, (int)(this.Height * 0.1), (int)(this.Width * 0.9), (int)(this.Height * 0.9));

            lblNewGame.SetBounds(this.Width / 2 - lblNewGame.Width / 2, (int)(this.Height * 0.3),
                lblNewGame.Width, lblNewGame.Height);

            lblContinueLastGame.SetBounds(this.Width / 2 - lblContinueLastGame.Width / 2, (int)(this.Height * 0.5),
                lblContinueLastGame.Width, lblContinueLastGame.Height);

            lblHighScores.SetBounds(this.Width / 2 - lblHighScores.Width / 2, (int)(this.Height * 0.6),
                lblHighScores.Width, lblHighScores.Height);

            lblAbout.SetBounds(this.Width / 2 - lblAbout.Width / 2, (int)(this.Height * 0.7),
                lblAbout.Width, lblAbout.Height);

            lblExit.SetBounds(this.Width / 2 - lblExit.Width / 2, (int)(this.Height * 0.8),
                lblExit.Width, lblExit.Height);
        }

        private void ResizeRadioButtons()
        {
            radioBtnEasy.SetBounds(lblContinueLastGame.Location.X, (int)(this.Height * 0.4), radioBtnEasy.Width, radioBtnEasy.Height);
            radioBtnMedium.SetBounds(lblContinueLastGame.Location.X + radioBtnEasy.Width, (int)(this.Height * 0.4), radioBtnMedium.Width, radioBtnMedium.Height);
            radioBtnHard.SetBounds(lblContinueLastGame.Location.X + radioBtnEasy.Width + radioBtnMedium.Width, (int)(this.Height * 0.4), radioBtnHard.Width, radioBtnHard.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.ResizeLabels();
            this.ResizeRadioButtons();
        }
    }
}
