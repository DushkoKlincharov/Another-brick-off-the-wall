using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Another_Brick_Off_The_Wall
{
    public static class Top5
    {
        public static List<Score> Top5Scores = new List<Score>();

        public static void startScores()
        {
            if (File.Exists("scores.txt"))
            {
                loadScores();
            }
            else
            {
                   
                File.WriteAllText("scores.txt", "");
            }
        }

        public static void Add(string name, int points)
        {
            Top5Scores.Add(new Score(name,points));
            List<Score> sortedList = Top5Scores.OrderBy(o => o.Points).ToList();
            sortedList.Reverse();
            Top5Scores = sortedList;
            if (Top5Scores.Count > 5) Top5Scores.RemoveAt(5);
        }

        public static void loadScores()
        {
            if (File.ReadAllText("scores.txt").Length != 0)
            {
                string[] players = File.ReadAllText("scores.txt").Split('\n');
                foreach (string player in players)
                {
                    string[] parts = player.Split(',');
                    Add(parts[0], int.Parse(parts[1]));
                }
            }
        }

        public static void saveScores()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Score score in Top5Scores)
                sb.Append(score.ToString());
            sb.Remove(sb.Length - 1, 1);
            File.WriteAllText("scores.txt", sb.ToString());
        }



    }
}
