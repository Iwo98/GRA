using System;
using System.Windows.Forms;

namespace GRA
{
    /// Klasa w której znajdują się niezbędne funkcje i zmienne do utworzenia i działania obiektu menu
    public partial class Menu : Form
    {
        /// <summary>
        /// Konstruktor klasy Menu, inicjalizuje wszystkie komponenty
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja, która przy kliknięciu lewym przyciskie myszki na guzik z poziomem trzecim (Level3), włącza ten poziom.
        /// </summary>
        private void level3_Click(object sender, EventArgs e)
        {
            Level3 lvl3 = new Level3();
            lvl3.Show();
            lvl3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        /// <summary>
        /// Funkcja, która przy kliknięciu lewym przyciskie myszki na guzik z poziomem drugim (Level2), włącza ten poziom.
        /// </summary>
        private void level2_Click(object sender, EventArgs e)
        {
            Level2 lvl2 = new Level2();
            lvl2.Show();
            lvl2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        /// <summary>
        /// Funkcja, która przy kliknięciu lewym przyciskie myszki na guzik z poziomem pierwszym (Level1), włącza ten poziom.
        /// </summary>
        private void level1_Click(object sender, EventArgs e)
        {
            Level1 lvl1 = new Level1();
            lvl1.Show();
            lvl1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
        /// <summary>
        /// Funkcja, która przy kliknięciu lewym przyciskie myszki na guzik z instrukcją (Manual), otwiera ją.
        /// </summary>
        private void manual_Click(object sender, EventArgs e)
        {
            Manual man = new Manual();
            man.Show();
            man.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        /// <summary>
        /// Funkcja sprawia, że po naciśnieciu "krzyżyka" na pasku z grą, aplikacja wyłączy się
        /// </summary>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
