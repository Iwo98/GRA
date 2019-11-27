namespace GRA
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.level1 = new System.Windows.Forms.PictureBox();
            this.level3 = new System.Windows.Forms.PictureBox();
            this.level2 = new System.Windows.Forms.PictureBox();
            this.manual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual)).BeginInit();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1.Image = ((System.Drawing.Image)(resources.GetObject("level1.Image")));
            this.level1.Location = new System.Drawing.Point(419, 344);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(437, 99);
            this.level1.TabIndex = 3;
            this.level1.TabStop = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level3
            // 
            this.level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3.Image = ((System.Drawing.Image)(resources.GetObject("level3.Image")));
            this.level3.Location = new System.Drawing.Point(419, 687);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(437, 98);
            this.level3.TabIndex = 2;
            this.level3.TabStop = false;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level2
            // 
            this.level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level2.Image = ((System.Drawing.Image)(resources.GetObject("level2.Image")));
            this.level2.Location = new System.Drawing.Point(419, 516);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(437, 106);
            this.level2.TabIndex = 1;
            this.level2.TabStop = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // manual
            // 
            this.manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manual.Image = ((System.Drawing.Image)(resources.GetObject("manual.Image")));
            this.manual.ImageLocation = "";
            this.manual.Location = new System.Drawing.Point(376, 126);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(525, 105);
            this.manual.TabIndex = 0;
            this.manual.TabStop = false;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.manual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox manual;
        private System.Windows.Forms.PictureBox level2;
        private System.Windows.Forms.PictureBox level3;
        private System.Windows.Forms.PictureBox level1;
    }
}