namespace GRA
{
    partial class Level2
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
            this.score = new System.Windows.Forms.Label();
            this.users_score = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Menu_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_button)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(1014, 117);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(110, 38);
            this.score.TabIndex = 2;
            this.score.Text = "Wynik:";
            // 
            // users_score
            // 
            this.users_score.AutoSize = true;
            this.users_score.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_score.Location = new System.Drawing.Point(1130, 117);
            this.users_score.Name = "users_score";
            this.users_score.Size = new System.Drawing.Size(40, 53);
            this.users_score.TabIndex = 3;
            this.users_score.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_button.Image = global::GRA.Properties.Resources.menu;
            this.Menu_button.Location = new System.Drawing.Point(1008, 35);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(229, 69);
            this.Menu_button.TabIndex = 1;
            this.Menu_button.TabStop = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.users_score);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Menu_button);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Level2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level2_FormClosing);
            this.Load += new System.EventHandler(this.Level2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level2_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_shot);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Menu_button;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label users_score;
        private System.Windows.Forms.Timer timer;
    }
}