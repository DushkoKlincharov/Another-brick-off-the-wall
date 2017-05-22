using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Another_Brick_Off_The_Wall
{
    public enum Rewards
    {
        BIGGER_SLIDER, SMALLER_SLIDER, FASTER_SPEED,
        SLOWER_SPEED, LIFE
    } 

    public class Reward
    {
        // upper-left point of the reward
        public float X { get; set; }
        public float Y { get; set; }

        // the side of the square
        public static int SIDE = 15;

        public bool forDelete { get; set; }
        public Rewards Rwd { get; set; }

        public static Color[] COLORS = { Color.Red, Color.Green, Color.BurlyWood, Color.Blue, Color.Chocolate };
        public Color Color { get; set; }

        Random rand = new Random();

        public Reward(float x, float y,bool isLife)
        {
            X = x;
            Y = y;
            if (isLife) Color = COLORS[4];
            else
                Color = COLORS[rand.Next(4)];
            forDelete = false;
            if (Color == COLORS[0]) Rwd = Rewards.BIGGER_SLIDER;
            else if (Color == COLORS[1]) Rwd = Rewards.SLOWER_SPEED;
            else if (Color == COLORS[2]) Rwd = Rewards.FASTER_SPEED;
            else if (Color == COLORS[3]) Rwd = Rewards.SLOWER_SPEED;
            else if (Color == COLORS[4]) Rwd = Rewards.LIFE;
        }

        public void Draw(Graphics g)
        {

            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, SIDE, SIDE);
            }

        }

        public void Move(Slider slider)
        {
            Y += 1;

            if (Y + SIDE >= slider.Y)
                forDelete = true;
        }

                                                  




    }
}
