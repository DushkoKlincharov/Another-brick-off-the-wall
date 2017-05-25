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
        private Random firstDirection = new Random(); // initial direction of the ball
        private static Color BallColor = Color.Red;
        private static float Radius = 10;
        public static PictureBox Bounder;

        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public float Angle { get; set; }  // in radians [0-2Pi]

        private float SpeedX, SpeedY;

        private int delta;  // if the distance between two objects is less than delta then they collide
        private static float corner = 10; // the corner of the tiles part
        private static int sliderDelta = 3;
        public Ball(PictureBox bounder, Level lvl)
        {
            Bounder = bounder;
            X = (int)(bounder.Width / 2 - Radius);  // upper-left
            Y = bounder.Height - 250;
            Speed = (int)lvl.BallSpeed;
            //Angle = -(float)(Math.PI * 13 / 48);
            Angle = (float)(Math.PI * 1 / 4 + firstDirection.NextDouble() * Math.PI * 1 / 2);
            SpeedX = (float)Math.Cos(Angle) * Speed;
            SpeedY = (float)Math.Sin(Angle) * Speed;
            delta = (int)lvl.Delta;
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
            if (Math.Abs(Y + Radius * 2 - slider.Y) < Ball.sliderDelta)
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
            return Y > slider.Y + Radius;
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
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && Math.Abs(X + Radius - tile.X) <= corner * 2
                || Math.Abs(X + Radius * 2 - tile.X) < delta && Math.Abs(Y + Radius - tile.Y - Tile.HEIGHT) <= corner;
        }
        private bool collideDown(Tile tile)
        {
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && tile.X + corner * 2 <= X + Radius
                && X + Radius <= tile.X + tile.Width - corner * 2;
        }
        private bool collideDownRight(Tile tile)
        {
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && Math.Abs(X + Radius - tile.X - tile.Width) <= corner * 2
                || Math.Abs(X - tile.X - tile.Width) < delta && Math.Abs(Y + Radius - tile.Y - Tile.HEIGHT) <= corner;
        }
        private bool collideRight(Tile tile)
        {
            return Math.Abs(X - tile.X - tile.Width) < delta && tile.Y + corner < Y + Radius
                && Y + Radius <= tile.Y + Tile.HEIGHT - corner;
        }

        private bool collideLeft(Tile tile)
        {
            return Math.Abs(X + Radius * 2 - tile.X) < delta && tile.Y + corner <= Y + Radius &&
                Y + Radius <= tile.Y + Tile.HEIGHT - corner;
        }
        private bool collideUpLeft(Tile tile)
        {
            return Math.Abs(X + Radius * 2 - tile.X) < delta && Math.Abs(tile.Y - Y - Radius) <= corner
                || Math.Abs(Y + Radius * 2 - tile.Y) < delta && Math.Abs(X + Radius - tile.X) <= corner * 2;
        }
        private bool collideUp(Tile tile)
        {
            return Math.Abs(Y + Radius * 2 - tile.Y) < delta && tile.X + corner * 2 <= X + Radius
                && X + Radius <= tile.X + tile.Width - corner * 2;
        }
         
        private bool collideUpRight(Tile tile)
        {
            return Math.Abs(Y + Radius * 2 - tile.Y) < delta && Math.Abs(X + Radius - tile.X - tile.Width) <= corner * 2
                || Math.Abs(X - tile.X - tile.Width) < delta && Math.Abs(tile.Y - Y - Radius) <= corner;
        }

        

        
    }
}
