namespace Another_Brick_Off_The_Wall
{
    partial class Form1
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinueLastGame = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radioBtnEasy = new System.Windows.Forms.RadioButton();
            this.radioBtnMedium = new System.Windows.Forms.RadioButton();
            this.radioBtnHard = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioBtns = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(186, 28);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(154, 47);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinueLastGame
            // 
            this.btnContinueLastGame.AutoEllipsis = true;
            this.btnContinueLastGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinueLastGame.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueLastGame.Location = new System.Drawing.Point(186, 153);
            this.btnContinueLastGame.Name = "btnContinueLastGame";
            this.btnContinueLastGame.Size = new System.Drawing.Size(154, 47);
            this.btnContinueLastGame.TabIndex = 1;
            this.btnContinueLastGame.Text = "Continue last game";
            this.btnContinueLastGame.UseVisualStyleBackColor = false;
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(186, 206);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(154, 47);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "High scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(186, 259);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(154, 47);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(186, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radioBtnEasy
            // 
            this.radioBtnEasy.AutoSize = true;
            this.radioBtnEasy.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEasy.Location = new System.Drawing.Point(6, 19);
            this.radioBtnEasy.Name = "radioBtnEasy";
            this.radioBtnEasy.Size = new System.Drawing.Size(80, 40);
            this.radioBtnEasy.TabIndex = 5;
            this.radioBtnEasy.TabStop = true;
            this.radioBtnEasy.Text = "Easy";
            this.radioBtnEasy.UseVisualStyleBackColor = true;
            // 
            // radioBtnMedium
            // 
            this.radioBtnMedium.AutoSize = true;
            this.radioBtnMedium.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMedium.Location = new System.Drawing.Point(119, 19);
            this.radioBtnMedium.Name = "radioBtnMedium";
            this.radioBtnMedium.Size = new System.Drawing.Size(119, 40);
            this.radioBtnMedium.TabIndex = 6;
            this.radioBtnMedium.TabStop = true;
            this.radioBtnMedium.Text = "Medium";
            this.radioBtnMedium.UseVisualStyleBackColor = true;
            // 
            // radioBtnHard
            // 
            this.radioBtnHard.AutoSize = true;
            this.radioBtnHard.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnHard.Location = new System.Drawing.Point(244, 19);
            this.radioBtnHard.Name = "radioBtnHard";
            this.radioBtnHard.Size = new System.Drawing.Size(87, 40);
            this.radioBtnHard.TabIndex = 7;
            this.radioBtnHard.TabStop = true;
            this.radioBtnHard.Text = "Hard";
            this.radioBtnHard.UseVisualStyleBackColor = true;
            // 
            // groupBoxRadioBtns
            // 
            this.groupBoxRadioBtns.Controls.Add(this.radioBtnEasy);
            this.groupBoxRadioBtns.Controls.Add(this.radioBtnHard);
            this.groupBoxRadioBtns.Controls.Add(this.radioBtnMedium);
            this.groupBoxRadioBtns.Location = new System.Drawing.Point(186, 81);
            this.groupBoxRadioBtns.Name = "groupBoxRadioBtns";
            this.groupBoxRadioBtns.Size = new System.Drawing.Size(362, 66);
            this.groupBoxRadioBtns.TabIndex = 8;
            this.groupBoxRadioBtns.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBoxRadioBtns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnContinueLastGame);
            this.Controls.Add(this.btnNewGame);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Brick Breaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBoxRadioBtns.ResumeLayout(false);
            this.groupBoxRadioBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinueLastGame;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioBtnEasy;
        private System.Windows.Forms.RadioButton radioBtnMedium;
        private System.Windows.Forms.RadioButton radioBtnHard;
        private System.Windows.Forms.GroupBox groupBoxRadioBtns;
    }
}

