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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.Menu_button = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_button)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_button.Image")));
            this.Menu_button.Location = new System.Drawing.Point(1008, 35);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(229, 69);
            this.Menu_button.TabIndex = 1;
            this.Menu_button.TabStop = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1014, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wynik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1130, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
    }
}