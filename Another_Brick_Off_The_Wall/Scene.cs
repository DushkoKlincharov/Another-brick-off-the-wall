using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Another_Brick_Off_The_Wall
{
    public class Scene
    {
        // static variables used for dimensions
        public static readonly int UNIT = 10;
        public static readonly int ROW_BOXES = 52;
        public static readonly int COLUMN_BOXES = 80;
        public static readonly int WIDTH = COLUMN_BOXES * UNIT;
        public static readonly int HEIGHT = ROW_BOXES * UNIT;
       
        // Objects of the scene
        public Ball Ball { get; set; }
        public Slider Slider { get; set; }
        public List<Tile> Tiles { get; set; }
        public Reward Reward { get; set; }

        // Variables used for sending arguments to the objects
        public Level Level { get; set; }
        public PictureBox PictureBox { get; set; }

        // helping variables in the scene
        public bool MoveLeftSlider { get; set; }
        public bool MoveRightSlider { get; set; }
        private bool SliderToMove;
        public int RewardCounter { get; set; }

        // constructor of the scene
        public Scene(Level lvl, PictureBox picBox)
        {
            PictureBox = picBox;
            Level = lvl;
            Ball = new Ball(PictureBox, Level);
            Slider = new Slider(Level.SliderLength);
            Tiles = Level.getTiles();
            Reward = null;
            MoveLeftSlider = MoveRightSlider = false;
            SliderToMove = false;
            RewardCounter = 0;
        }

        // draw method
        public void Draw(Graphics g)
        {
            foreach (Tile tile in Tiles) // First drawing the tiles
            {
                tile.Draw(g);
            }
            if (Reward != null) Reward.Draw(g); // if there is reward draw it
            Ball.Draw(g); // draw the ball
            Slider.Draw(g); // draw the slider
        }

        // method when the timer ticks in 15 milliseconds

        public void TimerTick()
        {
            if (RewardCounter > 0)
            {
                RewardCounter--;
                if (RewardCounter == 0) RewardTheUser(Reward.Rwd, false);
            }

            Ball.Move(); // the moving of the ball
            Ball.SliderCollider(Slider); // condition if ball touches with slider
            if (Ball.OutOfBounds(Slider))
                Ball = new Ball(PictureBox, new Level3());

            TilesCollisions();


            if (Reward != null) // if there is reward it should move downwards 
            {
                Reward.Move(Slider);
                if (Reward.forDelete) Reward = null; // set the reward to null if it is below slider
            }
           // if (SliderToMove) // every second timer the slider moves if it should
           // {
            MoveSlider();
           // }
            /*if (Slider.touchReward(Reward))
            {
                RewardCounter = 2000;
                RewardTheUser(Reward.Rwd,true);
            }*/
            //SliderToMove = !SliderToMove; // change the turn of slider whether it should move
        }

        private bool TilesCollisions()
        {
            for (int i = Tiles.Count - 1; i >= 0; i--)
            {
                if(Ball.collides(Tiles[i]))
                {
                    Tiles.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // method for getting rewards
        private void RewardTheUser(Rewards reward, bool ok)
        {
            int Unit = UNIT;
            int Speed = 2;
            if (!ok)
            {
                Unit = -Unit;
                Speed = -Speed;
                Reward = null;
            }
            if (reward == Rewards.BIGGER_SLIDER) Slider.ChangeLength(Unit);
            else if (reward == Rewards.SMALLER_SLIDER) Slider.ChangeLength(-Unit);
        }


        // method for moving slider
        public void MoveSlider()
        {
            if (MoveLeftSlider) Slider.Move(-UNIT);
            if (MoveRightSlider) Slider.Move(UNIT);
            //Slider.Move(10);
        }
        
    }
}
