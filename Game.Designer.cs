namespace Snake
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.snake_color = new System.Windows.Forms.Label();
            this.check_rgb = new System.Windows.Forms.CheckBox();
            this.trackspeed = new System.Windows.Forms.TrackBar();
            this.speedoption = new System.Windows.Forms.Label();
            this.autospeed = new System.Windows.Forms.CheckBox();
            this.rr_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackspeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Black;
            this.pbCanvas.Location = new System.Drawing.Point(-1, -3);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(698, 658);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(703, 9);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(703, 62);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 37);
            this.Score.TabIndex = 4;
            this.Score.Visible = false;
            // 
            // snake_color
            // 
            this.snake_color.AutoSize = true;
            this.snake_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.snake_color.Location = new System.Drawing.Point(709, 71);
            this.snake_color.Name = "snake_color";
            this.snake_color.Size = new System.Drawing.Size(249, 37);
            this.snake_color.TabIndex = 5;
            this.snake_color.Text = "Color for Snake:";
            this.snake_color.Visible = false;
            // 
            // check_rgb
            // 
            this.check_rgb.AutoSize = true;
            this.check_rgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.check_rgb.Location = new System.Drawing.Point(716, 112);
            this.check_rgb.Name = "check_rgb";
            this.check_rgb.Size = new System.Drawing.Size(104, 41);
            this.check_rgb.TabIndex = 6;
            this.check_rgb.Text = "RGB";
            this.check_rgb.UseVisualStyleBackColor = true;
            this.check_rgb.Visible = false;
            // 
            // trackspeed
            // 
            this.trackspeed.Location = new System.Drawing.Point(716, 205);
            this.trackspeed.Maximum = 40;
            this.trackspeed.Minimum = 10;
            this.trackspeed.Name = "trackspeed";
            this.trackspeed.Size = new System.Drawing.Size(242, 45);
            this.trackspeed.TabIndex = 8;
            this.trackspeed.Value = 25;
            this.trackspeed.Visible = false;
            // 
            // speedoption
            // 
            this.speedoption.AutoSize = true;
            this.speedoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.speedoption.Location = new System.Drawing.Point(709, 155);
            this.speedoption.Name = "speedoption";
            this.speedoption.Size = new System.Drawing.Size(173, 37);
            this.speedoption.TabIndex = 9;
            this.speedoption.Text = "Set Speed:";
            // 
            // autospeed
            // 
            this.autospeed.AutoSize = true;
            this.autospeed.Checked = true;
            this.autospeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autospeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.autospeed.Location = new System.Drawing.Point(716, 256);
            this.autospeed.Name = "autospeed";
            this.autospeed.Size = new System.Drawing.Size(203, 41);
            this.autospeed.TabIndex = 10;
            this.autospeed.Text = "Auto Speed";
            this.autospeed.UseVisualStyleBackColor = true;
            this.autospeed.Visible = false;
            // 
            // rr_btn
            // 
            this.rr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.rr_btn.Location = new System.Drawing.Point(729, 7);
            this.rr_btn.Name = "rr_btn";
            this.rr_btn.Size = new System.Drawing.Size(153, 61);
            this.rr_btn.TabIndex = 11;
            this.rr_btn.Text = "Retry";
            this.rr_btn.UseVisualStyleBackColor = true;
            this.rr_btn.Visible = false;
            this.rr_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(994, 658);
            this.Controls.Add(this.rr_btn);
            this.Controls.Add(this.autospeed);
            this.Controls.Add(this.speedoption);
            this.Controls.Add(this.trackspeed);
            this.Controls.Add(this.check_rgb);
            this.Controls.Add(this.snake_color);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackspeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        public System.Windows.Forms.PictureBox pbCanvas;
        public System.Windows.Forms.Label lblGameOver;
        public System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label snake_color;
        private System.Windows.Forms.CheckBox check_rgb;
        private System.Windows.Forms.TrackBar trackspeed;
        private System.Windows.Forms.Label speedoption;
        private System.Windows.Forms.CheckBox autospeed;
        private System.Windows.Forms.Button rr_btn;
    }
}

