namespace GRA
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Menu_button = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.users_score = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.Menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_button.Image")));
            this.Menu_button.Location = new System.Drawing.Point(1006, 26);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(229, 80);
            this.Menu_button.TabIndex = 2;
            this.Menu_button.TabStop = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(999, 121);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(129, 38);
            this.score.TabIndex = 3;
            this.score.Text = "Wynik:";
            // 
            // users_score
            // 
            this.users_score.AutoSize = true;
            this.users_score.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_score.Location = new System.Drawing.Point(1129, 120);
            this.users_score.Name = "users_score";
            this.users_score.Size = new System.Drawing.Size(38, 38);
            this.users_score.TabIndex = 4;
            this.users_score.Text = "0";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.LemonChiffon;
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.Enabled = false;
            this.restart.Image = ((System.Drawing.Image)(resources.GetObject("restart.Image")));
            this.restart.Location = new System.Drawing.Point(497, 823);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(290, 76);
            this.restart.TabIndex = 5;
            this.restart.TabStop = false;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.users_score);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Menu_button);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Level1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_shot);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Wymagany do poprawnego działania timer_Tick()
        /// </summary>
        private System.Windows.Forms.Timer timer;
        /// <summary>
        /// PictureBox z guzikiem do przejścia do Menu
        /// </summary>
        private System.Windows.Forms.PictureBox Menu_button;
        /// <summary>
        /// Label wyświetlający napis "Wynik:"
        /// </summary>
        private System.Windows.Forms.Label score;
        /// <summary>
        /// Label wyświetlający aktualny wynik gracza przechowywany w bullet.points
        /// </summary>
        /// @see Bullet.points
        private System.Windows.Forms.Label users_score;
        /// <summary>
        /// PictureBox z guzikiem do ponownego uruchomienia tego samego poziomu (Level1)
        /// </summary>
        private System.Windows.Forms.PictureBox restart;
    }
}