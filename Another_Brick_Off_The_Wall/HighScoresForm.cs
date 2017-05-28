using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Another_Brick_Off_The_Wall
{
    public partial class HighScoresForm : Form
    {
        public List<Score> Top5Scores { get; set; }
        public HighScoresForm(List<Score> List)
        {
            InitializeComponent();
            this.Font = new Font("Segoe print", 10.75F);
            Top5Scores = List;
            makeChanges();
        }

        private void makeChanges()
        {
            if (Top5Scores.Count > 0)
            {
                lblPlayer1.Text = string.Format("{0}", Top5Scores[0].Name);
                lblScore1.Text = string.Format("{0}", Top5Scores[0].Points);
            }
            if (Top5Scores.Count > 1)
            {
                lblPlayer2.Text = string.Format("{0}", Top5Scores[1].Name);
                lblScore2.Text = string.Format("{0}", Top5Scores[1].Points);
            }
            if (Top5Scores.Count > 2)
            {
                lblPlayer3.Text = string.Format("{0}", Top5Scores[2].Name);
                lblScore3.Text = string.Format("{0}", Top5Scores[2].Points);
            }
            if (Top5Scores.Count > 3)
            {
                lblPlayer4.Text = string.Format("{0}", Top5Scores[3].Name);
                lblScore4.Text = string.Format("{0}", Top5Scores[3].Points);
            }
            if (Top5Scores.Count > 4)
            {
                lblPlayer5.Text = string.Format("{0}", Top5Scores[4].Name);
                lblScore5.Text = string.Format("{0}", Top5Scores[4].Points);
            }
        }

        private void labelOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelOk_MouseMove(object sender, MouseEventArgs e)
        {
            labelOk.ForeColor = Color.SlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void labelOk_MouseLeave(object sender, EventArgs e)
        {
            labelOk.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }
    }
}
