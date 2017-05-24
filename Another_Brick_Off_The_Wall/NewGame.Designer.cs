namespace Another_Brick_Off_The_Wall
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerForBall = new System.Windows.Forms.Timer(this.components);
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.pbPoints = new System.Windows.Forms.PictureBox();
            this.pbLives = new System.Windows.Forms.PictureBox();
            this.pbNewGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // timerForBall
            // 
            this.timerForBall.Interval = 15;
            this.timerForBall.Tick += new System.EventHandler(this.timerForBall_Tick);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.White;
            this.lblCountdown.Location = new System.Drawing.Point(415, 227);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(47, 56);
            this.lblCountdown.TabIndex = 1;
            this.lblCountdown.Text = "3";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(128, 546);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(30, 36);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "0";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(258, 546);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(30, 36);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(663, 546);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 36);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00 : 00";
            // 
            // pbTime
            // 
            this.pbTime.BackColor = System.Drawing.Color.Transparent;
            this.pbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTime.Location = new System.Drawing.Point(597, 537);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(60, 50);
            this.pbTime.TabIndex = 6;
            this.pbTime.TabStop = false;
            // 
            // pbPoints
            // 
            this.pbPoints.BackColor = System.Drawing.Color.Transparent;
            this.pbPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPoints.Location = new System.Drawing.Point(192, 537);
            this.pbPoints.Name = "pbPoints";
            this.pbPoints.Size = new System.Drawing.Size(60, 50);
            this.pbPoints.TabIndex = 3;
            this.pbPoints.TabStop = false;
            // 
            // pbLives
            // 
            this.pbLives.BackColor = System.Drawing.Color.Transparent;
            this.pbLives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLives.Location = new System.Drawing.Point(62, 537);
            this.pbLives.Name = "pbLives";
            this.pbLives.Size = new System.Drawing.Size(60, 50);
            this.pbLives.TabIndex = 2;
            this.pbLives.TabStop = false;
            // 
            // pbNewGame
            // 
            this.pbNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pbNewGame.Location = new System.Drawing.Point(40, 20);
            this.pbNewGame.Name = "pbNewGame";
            this.pbNewGame.Size = new System.Drawing.Size(800, 520);
            this.pbNewGame.TabIndex = 0;
            this.pbNewGame.TabStop = false;
            this.pbNewGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbNewGame_Paint);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 596);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.pbPoints);
            this.Controls.Add(this.pbLives);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.pbNewGame);
            this.Name = "NewGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ANOTHER BRICK OFF THE WALL";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNewGame;

        private System.Windows.Forms.Timer timerForBall;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.PictureBox pbLives;
        private System.Windows.Forms.PictureBox pbPoints;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.Label lblTime;

    }
}