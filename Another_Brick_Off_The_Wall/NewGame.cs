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
        //private Slider slider;
        //private Ball ball;

        public NewGame(Level level)
        {
            InitializeComponent();
            //ball = new Ball(pbNewGame, Level.BallSpeeds.MEDIUM);
            //slider = new Slider(Level.SliderLengths.LARGE);
            //DoubleBuffered = true;
            //this.BackgroundImage = Resources.newGame_window_background;
        }

        

        private void timerForBall_Tick(object sender, EventArgs e)
        {
            /*ball.Move();
            Invalidate(true);*/
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.Clear(Color.White);
            ball.Draw(e.Graphics);*/
        }

        



        

        

        

    }
}
