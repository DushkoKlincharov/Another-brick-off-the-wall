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
    public partial class NewGame : Form
    {
        public Scene Scene { get; set; }
        public Level Level { get; set; }
        public PictureBox PictureBox { get; set; }
        public int countdown;
        public int secondsCounter;
        public int seconds;

        public NewGame(Level level)
        {
            InitializeComponent();
            Level = level;
            PictureBox = pbNewGame;
            Scene = new Scene(Level, PictureBox);
            lblCountdown.Location = new Point(417, 230);
            countdown = 3;
            seconds = 0;
            secondsCounter = 0;
            DoubleBuffered = true;
            this.BackgroundImage = Resources.newGame_window_background;
            pbPoints.Image = Resources.coin;
            lblPoints.Text = string.Format("{0}", Scene.Points);
            pbLives.Image = Resources.heart;
            lblLives.Text = string.Format("{0}",Scene.Lives);
            pbTime.Image = Resources.time;
            lblTime.Text = string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
            // lblCountdown.BackColor = Color.SlateGray;
            lblCountdown.Text = countdown.ToString();
            Scene.Draw(e.Graphics);
        }

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            if (secondsCounter == 67)
            {
                secondsCounter = 0;
                ++seconds;
            }
            Scene.TimerTick();
            if (Scene.loseLife)
            {
                beginCountdown();
            }
            if (Scene.endGame)
            {
                EndGame();
            }
            lblLives.Text = string.Format("{0}", Scene.Lives);
            lblPoints.Text = string.Format("{0}", Scene.Points);
            lblTime.Text = string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
            Invalidate(true);
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (countdown == 0)
            {
                timerCountdown.Stop();
                lblCountdown.Hide();
                timerForBall.Start();
            }
            else
            {
                countdown--;

            }
            Invalidate(true);
        }

        private void EndGame()
        {
            timerForBall.Stop();
            lblLives.Text = string.Format("{0}", Scene.Lives);
            lblPoints.Text = string.Format("{0}", Scene.Points);
            lblTime.Text = string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
            Invalidate(true);
            Scene.EndGame(seconds);
            string Name = "";
            EnterName enterName = new EnterName();
            this.AddOwnedForm(enterName);
            if (enterName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Name = enterName.PlayerName;
            }
            this.RemoveOwnedForm(enterName);
            Top5.Add(Name, Scene.Points);
            Top5.saveScores();
            this.Close();
        }

        private void beginCountdown()
        {
            timerForBall.Stop();
            countdown = 3;
            Scene.NewGame();
            if (Scene.endGame)
            {
                EndGame();
                return;
            }
            lblCountdown.Show();
            timerCountdown.Start();
        }

        // Slider moving methods

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.MoveLeftSlider = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MoveRightSlider = true;
            }
        }

        private void NewGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.MoveLeftSlider = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MoveRightSlider = false;
            }

        }
    }
}