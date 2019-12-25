namespace GRA
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.menu = new System.Windows.Forms.PictureBox();
            this.manual_text = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual_text)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(1006, 26);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(229, 80);
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // manual_text
            // 
            this.manual_text.Image = ((System.Drawing.Image)(resources.GetObject("manual_text.Image")));
            this.manual_text.Location = new System.Drawing.Point(113, 191);
            this.manual_text.Name = "manual_text";
            this.manual_text.Size = new System.Drawing.Size(1052, 668);
            this.manual_text.TabIndex = 1;
            this.manual_text.TabStop = false;
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.manual_text);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Manual";
            this.Text = "Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manual_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual_text)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// PictureBox z guzikiem do przejścia do Menu
        /// </summary>
        private System.Windows.Forms.PictureBox menu;
        /// <summary>
        /// PictureBox z napisaną instrukcją do gry
        /// </summary>
        private System.Windows.Forms.PictureBox manual_text;
    }
}