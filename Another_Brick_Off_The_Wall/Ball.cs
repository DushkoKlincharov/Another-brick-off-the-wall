using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    [Serializable]
    public class Ball
    {
        private static Random firstDirection = new Random();
        private static Color BallColor = Color.Red;
        private static float Radius = 10;
        public static PictureBox Bounder;

        public float X { get; set; }
        public float Y { get; set; }
        public int Speed { get; set; }
        public float Angle { get; set; }

        private float SpeedX, SpeedY;

        public Ball(PictureBox bounder, Level.BallSpeeds speed)
        {
            Bounder = bounder;
            X = bounder.Width / 2 - Radius;  // upper-left
            Y = bounder.Height - 100;
            Speed = (int)speed;
            Angle = (float)(Math.PI * 1 / 4 + firstDirection.NextDouble() * Math.PI * 1 / 2);
            SpeedX = (float)Math.Cos(Angle) * Speed;
            SpeedY = (float)Math.Sin(Angle) * Speed;
        }

        public void Draw(Graphics g)
        {
            using (Brush b = new SolidBrush(BallColor))
            {
                g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
            }
        }

        public void Move()
        {
            float nextX = X + SpeedX;
            float nextY = Y + SpeedY;
            if (nextX <= 0 || nextX + Radius * 2 >= Scene.WIDTH)
            {
                SpeedX = -SpeedX;
            }
            if (nextY <= Bounder.Top-20 || nextY + Radius * 2 >= Scene.HEIGHT)
            {
                SpeedY = -SpeedY;
            }
            X += SpeedX;
            Y += SpeedY;
        }

        public bool SliderCollider(Slider slider)
        {
            if (Y + Radius * 2 == slider.Y && slider.X < X + Radius && X + Radius < slider.X + slider.Width ) // if they touch
            {
                SpeedY = -SpeedY;
                return true;
            }

            return false;
        }

        public bool OutOfBounds(Slider slider)
        {
            return Y + Radius * 2 > slider.Y;
        }
    }
}
