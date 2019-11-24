using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Level2 lvl1 = new Level2();
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
    }
}
