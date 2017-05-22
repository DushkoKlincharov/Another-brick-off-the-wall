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

        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public float Angle { get; set; }

        private float SpeedX, SpeedY;

        public Ball(PictureBox bounder, Level.BallSpeeds speed)
        {
            Bounder = bounder;
            X = (int)(bounder.Width / 2 - Radius);  // upper-left
            Y = bounder.Height - 200;
            Speed = (int)speed;
            Angle = (float)(-Math.PI * 1 / 4 - firstDirection.NextDouble() * Math.PI * 1 / 2);
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
            if (nextY <= 0 || nextY + Radius * 2 >= Scene.HEIGHT)
            {
                SpeedY = -SpeedY;
            }
            X += (int)SpeedX;
            Y += (int)SpeedY;
        }

        public bool SliderCollider(Slider slider)
        {
            if (Y + Radius * 2 == slider.Y && slider.X < X + Radius && X + Radius < slider.X + slider.Width) // if they touch
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

        internal bool collides(Tile tile)
        {

            if (collideUp(tile) || collideDown(tile))
            {
                SpeedY = -SpeedY;
                return true;
            }
            if (collideLeft(tile) || collideRight(tile))
            {
                SpeedX = -SpeedX;
                return true;
            }
            /*if (collideDownLeft(tile) || collideDownRight(tile) || collideUpLeft(tile) || collideUpRight(tile))
            {
                SpeedX = -SpeedX;
                SpeedY = -SpeedY;
                return true;
            }*/

            
            return false;
        }
        private static int d = 0;
        private bool collideLeft(Tile tile)
        {
            return X + Radius * 2 == tile.X && tile.Y + d <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT - d;
        }

        private bool collideUpLeft(Tile tile)
        {
            return (X + Radius * 2 == tile.X && tile.Y - d <= Y + Radius && Y + Radius <= tile.Y + d)
                || (Y + Radius * 2 == tile.Y && tile.X - d <= X + Radius && X + Radius <= tile.X + d);
        }

        private bool collideUpRight(Tile tile)
        {
            return (X == tile.X + tile.Width && tile.Y - d <= Y + Radius && Y + Radius <= tile.Y + d)
                || (Y + Radius * 2 == tile.Y && tile.X + tile.Width - d <= X + Radius && X + Radius <= tile.X + tile.Width + d);
        }

        private bool collideDownRight(Tile tile)
        {
            return (Y == tile.Y + Tile.HEIGHT && tile.X + tile.Width - d <= X + Radius && X + Radius <= tile.X + tile.Width + d)
                || (X == tile.X + tile.Width && tile.Y + Tile.HEIGHT - d <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT + d);
        }

        private bool collideDownLeft(Tile tile)
        {
            return (Y == tile.Y + Tile.HEIGHT && tile.X - d <= X + Radius && X + Radius <= tile.X + d)
                || (X + Radius * 2 == tile.X && tile.Y + Tile.HEIGHT - d <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT + d);

        }

        private bool collideRight(Tile tile)
        {
            return X == tile.X + tile.Width && tile.Y + 5 <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT - 5;
        }

        private bool collideDown(Tile tile)
        {
            return Y == tile.Y + Tile.HEIGHT && tile.X + 5 <= X + Radius && X + Radius <= tile.X + tile.Width - 5;
        }

        private bool collideUp(Tile tile)
        {
            return Y + Radius * 2 == tile.Y && tile.X + 5 <= X + Radius && X + Radius <= tile.X + tile.Width - 5;
        }
    }
}
