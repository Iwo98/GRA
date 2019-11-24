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
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Manual_Load(object sender, EventArgs e)
        {
            pilot.Text = "Instrukcja";
        }

        private void Manual_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }
}
