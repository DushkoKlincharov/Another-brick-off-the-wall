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

        private static int delta = 5;
        private static int corner = 7;

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
            if (Math.Abs(Y + Radius * 2 - slider.Y) < delta)
            {
                if (slider.X - corner <= X + Radius && X + Radius <= slider.X + corner * 3)
                {
                    Angle = -(float)Math.PI * 3 / 4;
                    SpeedX = (float)Math.Cos(Angle) * Speed;
                    SpeedY = (float)Math.Sin(Angle) * Speed;
                    return true;
                }
                if (slider.X + corner * 3 <= X + Radius && X + Radius <= slider.X + slider.Width - corner * 3)
                {
                    SpeedY = -SpeedY;
                    return true;
                }
                if (slider.X + slider.Width - corner * 3 <= X + Radius && X + Radius <= slider.X + slider.Width + corner)
                {
                    Angle = -(float)Math.PI * 1 / 4;
                    SpeedX = (float)Math.Cos(Angle) * Speed;
                    SpeedY = (float)Math.Sin(Angle) * Speed;
                    return true;
                }
            }
            return false;
        }

        public bool OutOfBounds(Slider slider)
        {
            return Y + Radius * 2 > slider.Y;
        }

        internal bool collides(Tile tile)
        {
            
            if (collideDown(tile) || collideUp(tile))
            {
                SpeedY = -SpeedY;
                return true;
            }
            if (collideLeft(tile) || collideRight(tile))
            {
                SpeedX = -SpeedX;
                return true;
            }
            if (collideDownRight(tile))
            {
                Angle = -(float)Math.PI * 7 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if(collideDownLeft(tile))
            {
                Angle = -(float)Math.PI * 5 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if (collideUpRight(tile))
            {
                Angle = -(float)Math.PI * 1 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if (collideUpLeft(tile))
            {
                Angle = -(float)Math.PI * 3 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            return false;
        }

        private bool collideDownLeft(Tile tile)
        {
            if (Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta)
            {
                return tile.X - corner <= X + Radius && X + Radius <= tile.X + corner;
            }
            if (Math.Abs(X + Radius * 2 - tile.X) < delta)
            {
                return tile.Y + Tile.HEIGHT <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT + corner;
            }
            return false;
        }
        private bool collideDown(Tile tile)
        {
            if (Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta)
            {
                return tile.X + corner <= X + Radius && X + Radius <= tile.X + tile.Width - corner;
            }
            return false;
        }
        private bool collideDownRight(Tile tile)
        {
            if (Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta)
            {
                return tile.X + tile.Width - corner <= X + Radius && X + Radius <= tile.X + tile.Width + corner;
            }
            if (Math.Abs(X - tile.X - tile.Width) < delta)
            {
                return tile.Y + Tile.HEIGHT <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT + corner;
            }
            return false;
        }
        private bool collideRight(Tile tile)
        {
            if (Math.Abs(X - tile.X - tile.Width) < delta)
            {
                return tile.Y <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT;
            }
            return false;
        }

        private bool collideLeft(Tile tile)
        {
            if (Math.Abs(X + Radius * 2 - tile.X) < delta)
            {
                return tile.Y <= Y + Radius && Y + Radius <= tile.Y + Tile.HEIGHT;
            }
            return false;
        }
        private bool collideUpLeft(Tile tile)
        {
            if (Math.Abs(Y + Radius * 2 - tile.Y) < delta)
            {
                return tile.X - corner <= X + Radius && X + Radius <= tile.X + corner;
            }
            if (Math.Abs(X + Radius * 2 - tile.X) < delta)
            {
                return tile.Y - corner <= Y + Radius && Y + Radius <= tile.Y;
            }
            return false;
        }
        private bool collideUp(Tile tile)
        {
            if (Math.Abs(Y + Radius * 2 - tile.Y) < delta)
            {
                return tile.X + corner <= X + Radius && X + Radius <= tile.X + tile.Width - corner;

            }
            return false;
        }
         
        private bool collideUpRight(Tile tile)
        {
            if (Math.Abs(Y + Radius * 2 - tile.Y) < delta)
            {
                return tile.X + tile.Width - corner <= X + Radius && X + Radius <= tile.X + tile.Width + corner;

            }
            if (Math.Abs(X - tile.X - tile.Width) < delta)
            {
                return tile.Y - corner <= Y + Radius && Y + Radius <= tile.Y;
            }
            return false;
        }

        

        
    }
}
