﻿using System;
using System.Windows.Forms;

namespace GRA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            Level2 lvl3 = new Level2();
            lvl3.Show();
            lvl3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            Level2 lvl2 = new Level2();
            lvl2.Show();
            lvl2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void level1_Click(object sender, EventArgs e)
        {
            Level1 lvl1 = new Level1();
            lvl1.Show();
            lvl1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void manual_Click(object sender, EventArgs e)
        {
            Manual man = new Manual();
            man.Show();
            man.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
