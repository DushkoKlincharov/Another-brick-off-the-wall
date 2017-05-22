namespace Another_Brick_Off_The_Wall
{
    partial class ExitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to exit?";
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.Transparent;
            this.lblYes.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.White;
            this.lblYes.Location = new System.Drawing.Point(57, 107);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(49, 36);
            this.lblYes.TabIndex = 1;
            this.lblYes.Text = "Yes";
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            this.lblYes.MouseLeave += new System.EventHandler(this.lblYes_MouseLeave);
            this.lblYes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblYes_MouseMove);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(247, 107);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(44, 36);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "No";
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            this.lblNo.MouseLeave += new System.EventHandler(this.lblNo_MouseLeave);
            this.lblNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNo_MouseMove);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Another_Brick_Off_The_Wall.Properties.Resources.newGame_window_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(369, 180);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.label1);
            this.Name = "ExitForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exit game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
    }
}