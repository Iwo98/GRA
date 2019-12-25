using System;

using System.Windows.Forms;

namespace GRA
{
    /// Klasa w której znajdują się niezbędne funkcje i zmienne do utworzenia i działania obiektu manual
    public partial class Manual : Form
    {

        /// <summary>
        /// Konstruktor klasy Manual, inicjalizuje wszystkie komponenty
        /// </summary>
        public Manual()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja sprawia, że po naciśnieciu "krzyżyka" na pasku z grą, aplikacja wyłączy się
        /// </summary>
        private void Manual_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Funkcja, która przy kliknięciu lewym przyciskie myszki na guzik z menu (Menu), otwierzy je.
        /// </summary>
        private void menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }
}
