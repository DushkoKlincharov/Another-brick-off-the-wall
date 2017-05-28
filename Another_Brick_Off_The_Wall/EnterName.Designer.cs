namespace Another_Brick_Off_The_Wall
{
    partial class EnterName
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name:";
            // 
            // tbEnterName
            // 
            this.tbEnterName.BackColor = System.Drawing.Color.Black;
            this.tbEnterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnterName.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterName.ForeColor = System.Drawing.Color.White;
            this.tbEnterName.Location = new System.Drawing.Point(177, 26);
            this.tbEnterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(195, 34);
            this.tbEnterName.TabIndex = 1;
            this.tbEnterName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEnterName_KeyUp);
            this.tbEnterName.Validating += new System.ComponentModel.CancelEventHandler(this.tbEnterName_Validating);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(211, 80);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(97, 47);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter";
            this.lblEnter.Click += new System.EventHandler(this.lblEnter_Click);
            this.lblEnter.MouseLeave += new System.EventHandler(this.lblEnter_MouseLeave);
            this.lblEnter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEnter_MouseMove);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Another_Brick_Off_The_Wall.Properties.Resources.newGame_window_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(407, 161);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.tbEnterName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnterName";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter your name";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterName_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEnterName;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}