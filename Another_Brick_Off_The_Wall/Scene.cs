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
        public Random Random = new Random();

        // helping variables in the scene
        public bool MoveLeftSlider { get; set; }
        public bool MoveRightSlider { get; set; }
        public int RewardCounter { get; set; }
        public bool loseLife { get; set; }
        public bool endGame { get; set; }

        // Lifes and points
        public int Lives { get; set; }
        public int Points { get; set; }

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
            RewardCounter = 0;
            Lives = 3;
            Points = 0;
            loseLife = false;
            endGame = false;
        }

        // draw method
        public void Draw(Graphics g)
        {
            foreach (Tile tile in Tiles) // First drawing the tiles
            {
                tile.Draw(g);
            }
            if (Reward!= null && !Reward.forDelete) Reward.Draw(g); // if there is reward draw it
            Ball.Draw(g); // draw the ball
            Slider.Draw(g); // draw the slider
        }

        // method when the timer ticks in 15 milliseconds

        public void TimerTick()
        {
            if (RewardCounter > 0)
            {
                RewardCounter--;
                if (RewardCounter == 0)
                {
                    RewardTheUser(Reward.Rwd, false);
                }
            }

            Ball.Move(); // the moving of the ball
            Ball.SliderCollider(Slider); // condition if ball touches with slider
            if (Ball.OutOfBounds(Slider))
                loseLife = true;
            
            MoveSlider(); // move the slider
            TilesCollisions(); // check for collisions of the ball with tiles
            if (Reward != null) // if there is reward it should move downwards 
            {
                Reward.Move(Slider);
                if (!Reward.forDelete && Slider.touchReward(Reward))
                {  // if slider touches the reward get the reward
                    RewardCounter = 350;
                    RewardTheUser(Reward.Rwd, true);
                    Reward.forDelete = true;
                }
                if (Reward.toNull && RewardCounter == 0) Reward = null;
            }
            
        }

        // method which is invoked every time life is lost
        public void NewGame()
        {
            Lives--;
            if (Lives == 0)
                endGame = true;
            Ball = new Ball(PictureBox, Level);
            Slider = new Slider(Level.SliderLength);
            loseLife = false;
            if (Reward != null) RewardTheUser(Reward.Rwd, false);
            Reward = null;
            RewardCounter = 0;
        }

        public void EndGame(int seconds)
        {
            int bonusTime = 180 - seconds;
            int bonusPoints = 0;
            if (bonusTime > 0)
                bonusPoints = Lives * bonusTime * 2;
            Points += bonusPoints;
            endGame = false;
        }


        // method to check if there is collision of the ball and tiles
        private bool TilesCollisions()
        {
            if (Tiles.Count == 0) endGame = true;
            for (int i = Tiles.Count - 1; i >= 0; i--)
            {
                if(Ball.collides(Tiles[i]))
                {
                    Points += Tiles[i].getPoints(Level);
                    checkForReward(Tiles[i]);
                    Tiles.RemoveAt(i);                  
                    return true;
                }
            }
            return false;
        }

        // method to check if there should fall reward after breaking a tile
        private void checkForReward(Tile tile)
        {
            if (Reward != null) return;
            int number = Random.Next(1000);
            if (number % 20 == 0)
                Reward = new Reward(tile.X + tile.Width/2, tile.Y + Tile.HEIGHT, true);
            else if (number % 10 == 0)
                Reward = new Reward(tile.X + tile.Width / 2, tile.Y + Tile.HEIGHT, false);
        }

        // method for getting rewards
        private void RewardTheUser(Rewards reward, bool ok)
        {
            int Unit = UNIT;
            if (!ok)
            {
                Unit = -Unit;
                Reward = null;
            }
            if (reward == Rewards.BIGGER_SLIDER) Slider.ChangeLength(Unit);
            else if (reward == Rewards.SMALLER_SLIDER) Slider.ChangeLength(-1 *Unit);
            else if (ok && reward == Rewards.LIFE) Lives++;
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
