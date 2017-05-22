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
        //private Ball ball;
        private Slider slider;
        List<Tile> tiles;
        Level level;
	

        public NewGame(Level level)
        {
            InitializeComponent();

            //ball = new Ball(pbNewGame, Level.BallSpeeds.MEDIUM);
            
            level = new Level1();
            tiles = level.getTiles();
            slider = new Slider(Level.SliderLengths.LARGE);

            //DoubleBuffered = true;
            //this.BackgroundImage = Resources.newGame_window_background;
        }

        private void pbNewGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.SlateGray);
            Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        {
            foreach (Tile t in tiles)
            {
                t.Draw(g);
            }
            slider.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                slider.Move(-10);
            else if (e.KeyCode == Keys.Right)
                slider.Move(10);
            Invalidate(true);
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
