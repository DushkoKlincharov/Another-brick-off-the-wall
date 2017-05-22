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
            this.pbNewGame = new System.Windows.Forms.PictureBox();
            this.timerForBall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNewGame
            // 
            this.pbNewGame.Location = new System.Drawing.Point(40, 20);
            this.pbNewGame.Name = "pbNewGame";
            this.pbNewGame.Size = new System.Drawing.Size(800, 520);
            this.pbNewGame.TabIndex = 0;
            this.pbNewGame.TabStop = false;
            this.pbNewGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbNewGame_Paint);
            // 
            // timerForBall
            // 
            this.timerForBall.Enabled = true;
            this.timerForBall.Tick += new System.EventHandler(this.timerForBall_Tick);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pbNewGame);
            this.Name = "NewGame";
            this.Text = "ANOTHER BRICK OFF THE WALL";
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNewGame;
        private System.Windows.Forms.Timer timerForBall;
    }
}