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

    /// Klasa w której znajdują się niezbędne funkcje i zmienne do utworzenia i działania całego poziomu pierwszego.
    public partial class Level1 : Form
    {

        /// Zmienna opisująca status gry - wygrana (win==true) lub w trakcie rozgrywki (win==false)
        private bool win = false;

        /// <summary>
        /// Utworzenie obiektu klasy Shooter i nadanie mu prędkości poruszania
        /// </summary>
        Shooter shooter = new Shooter(8);
        /// <summary>
        /// Utworzenie obiektu klasy Bullet i nadanie mu prędkości poruszania
        /// </summary>
        Bullet bullet = new Bullet(15);

        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target = new Target(45, 152, 60, 60, -1, "salt");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target1 = new Target(145, 152, 60, 60, 0, "broccoli");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target2 = new Target(245, 152, 60, 60, 0, "garlic");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target3 = new Target(345, 152, 60, 60, -1, "sugar");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target4 = new Target(445, 152, 60, 60, -1, "salt");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target5 = new Target(545, 152, 60, 60, 0, "onion");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target6 = new Target(645, 152, 60, 60, -1, "sugar");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target7 = new Target(745, 152, 60, 60, 0, "avocado");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target8 = new Target(845, 152, 60, 60, -1, "salt");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target9 = new Target(95, 252, 60, 60, 1, "banana");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target10 = new Target(195, 252, 60, 60, 0, "leek");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target11 = new Target(295, 252, 60, 60, -1, "sugar");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target12 = new Target(395, 252, 60, 60, 1, "peanuts");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target13 = new Target(495, 252, 60, 60, -1, "sugar");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target14 = new Target(595, 252, 60, 60, 1, "strawberry");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target15 = new Target(695, 252, 60, 60, -1, "salt");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target16 = new Target(795, 252, 60, 60, 1, "apple");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target17 = new Target(45, 352, 60, 60, -1, "sugar");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target18 = new Target(145, 352, 60, 60, 0, "chicken");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target19 = new Target(245, 352, 60, 60, 1, "kiwi");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target20 = new Target(345, 352, 60, 60, -1, "salt");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target21 = new Target(445, 352, 60, 60, 0, "eggplant");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target22 = new Target(545, 352, 60, 60, 0, "hot_pepper");
        
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target23 = new Target(645, 352, 60, 60, 0, "olive_oil");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target24 = new Target(745, 352, 60, 60, -1, "sugar");
       
        ///Utworzenie obiektu klasy Target, który będzie możliwy do zestrzelenia przez gracza.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę "-1", "1" lub "0" potrzebną do identyfikacji oraz nazwę
        Target target25 = new Target(845, 352, 60, 60, 0, "beans");


        ///tworzenie obiektu klasy Target, obiekt ten tylko ilustruje do którego produktu gracz ma strzelać.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę - w tym wypadku tylko "1" - potrzebną do identyfikacji oraz nazwę
        Target targetNo1 = new Target(51, 51, 60, 60, 1, "banana");
        
        ///tworzenie obiektu klasy Target, obiekt ten tylko ilustruje do którego produktu gracz ma strzelać.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę - w tym wypadku tylko "1" - potrzebną do identyfikacji oraz nazwę
        Target targetNo2 = new Target(201, 51, 60, 60, 1, "peanuts");
        
        ///tworzenie obiektu klasy Target, obiekt ten tylko ilustruje do którego produktu gracz ma strzelać.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę - w tym wypadku tylko "1" - potrzebną do identyfikacji oraz nazwę
        Target targetNo3 = new Target(351, 51, 60, 60, 1, "strawberry");
        
        ///tworzenie obiektu klasy Target, obiekt ten tylko ilustruje do którego produktu gracz ma strzelać.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę - w tym wypadku tylko "1" - potrzebną do identyfikacji oraz nazwę
        Target targetNo4 = new Target(501, 51, 60, 60, 1, "kiwi");
        
        ///tworzenie obiektu klasy Target, obiekt ten tylko ilustruje do którego produktu gracz ma strzelać.
        ///
        ///Nadanie mu współrzędnych X i Y, rozmarów w pionie i poziomie, odpowiednią flagę - w tym wypadku tylko "1" - potrzebną do identyfikacji oraz nazwę
        Target targetNo5 = new Target(651, 51, 60, 60, 1, "apple");
        
        ///Utworzenie listy z obiektami klasy Target.
        ///
        ///Lista z obiektami, do których gracz strzela
        List<Target> targety = new List<Target>();

        ///Utworzenie listy z obiektami klasy Target
        ///
        ///Lista z obiektami, które gracz ma zestrzelić, aby zdobyć punkty
        List<Target> targetyNo = new List<Target>(); 
        
        /// <summary>
        /// Utworzenie obiektu klasy Pen do narysowania czarnej ramki, oraz nadanie jej grubości
        /// </summary>
        Pen Black = new Pen(Color.Black, 2);
        /// <summary>
        /// Utworzenie obiektu klasy Pen do narysowania złotej ramki, oraz nadanie jej grubości
        /// </summary>
        Pen Hit = new Pen(Color.Gold, 5);
        /// <summary>
        /// Utworzenie obiektu klasy Pen do narysowania srebrnej ramki, oraz nadanie jej grubości
        /// </summary>
        Pen NotHit = new Pen(Color.Silver, 5);
        /// <summary>
        /// Utworzenie obiektu klasy Font do pisania na planszy, nadanie jej odpowiedniej czcionki, rozmiaru i stylu
        /// </summary>
        Font font = new Font("Lucida Sans", 40, FontStyle.Bold);
        /// <summary>
        /// Utworzenie obiektu klasy SolidBrush - potrzebny do utworzenia tekstu, nadanie mu czarnego koloru
        /// </summary>
        SolidBrush brush = new SolidBrush(Color.Black);

        

        /// <summary>
        /// Konstruktor służący do dodania wszystkich obiektów do odpowiednich list i zainicjalizowania komponentów.
        /// </summary>
        public Level1()
        {
            InitializeComponent();
            
            DoubleBuffered = true; 

            targety.Add(target);
            targety.Add(target1);
            targety.Add(target2);
            targety.Add(target3);
            targety.Add(target4);
            targety.Add(target5);
            targety.Add(target6);
            targety.Add(target7);
            targety.Add(target8);
            targety.Add(target9);
            targety.Add(target10);
            targety.Add(target11);
            targety.Add(target12);
            targety.Add(target13);
            targety.Add(target14);
            targety.Add(target15);
            targety.Add(target16);
            targety.Add(target17);
            targety.Add(target18);
            targety.Add(target19);
            targety.Add(target20);
            targety.Add(target21);
            targety.Add(target22);
            targety.Add(target23);
            targety.Add(target24);
            targety.Add(target25);

 
            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            

            countHealthies(targety);
        }

       
        /// <summary>
        /// Funkcja ta odpowiedzialna jest za całą dynamiczną grafikę w formie.
        /// 
        /// 1.Rysuje ramki na planszy (główne ramki jak i pomniejsze - srebrne lub złote przy obiektach, które mają być trafione lub zostały już trafione przez gracza).
        /// 
        /// 2.Wyrysowywuje odpowiednie obiekty (warzywa i produkty widoczne na planszy), na podstawie ich ustalonych nazw (Target.name).
        /// 
        /// 3.Rysuje puchar na całej planszy gry gracz wygra - zmienna win zmieni sie na true.
        /// @see win, Target.name
        /// </summary>      
        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                      
                e.Graphics.DrawRectangle(Black, 30, 150, 901, 610);                     
                e.Graphics.DrawImage(new Bitmap("Resources/fork.bmp"), shooter.x, shooter.y, shooter.width, shooter.height); 

                foreach (Target target in targety)                  
                {
                    if (target != null)
                    {
                            e.Graphics.DrawImage(new Bitmap("Resources/" + target.name + ".bmp"), target.x, target.y, target.width, target.height); 
                    }
                }

                foreach (Target targetNo in targetyNo)             
                {
                    e.Graphics.DrawImage(new Bitmap("Resources/" + targetNo.name + ".bmp"), targetNo.x, targetNo.y, targetNo.width, targetNo.height);

                    if (targetNo.hit == false)
                    {
                        e.Graphics.DrawRectangle(NotHit, targetNo.x - 5, targetNo.y - 5, targetNo.width + 10, targetNo.height + 10);
                    }
                    else
                        e.Graphics.DrawRectangle(Hit, targetNo.x - 5, targetNo.y - 5, targetNo.width + 10, targetNo.height + 10); 
                }


                if (bullet.shoot == true)
                    e.Graphics.DrawImage(new Bitmap("Resources/peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); 


                if (win == true)                                            
                {       
                    e.Graphics.DrawImage(new Bitmap("Resources/cup.png"), 30, 94, 901, 610);
                    e.Graphics.DrawString("Twój wynik to: " + users_score.Text, font, brush, 220, 410);
                    restart.Visible = true; 
                    restart.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Licznik czasu, który dzięki funkcji updating, odświeża mape co 3 milisekudny, przestaje odświeżać, gdy zmienna win zmieni sie na true
        /// 
        /// @see updating() , win
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)   
        {
            if (win == false)
                updating();

            Invalidate();
        }

        /// <summary>
        /// Funkcja ta odświeża pozycje strzelającego (shooter) oraz pocisku (bullet), dodatkowo usuwa obiekty zestrzelone obiekty, uaktualnia wynik gracza(users_score)
        /// oraz sprawdza czy gracz zbił już wszystkie obiekty (bullet.healthies równe zero), które miał zbić, jeśli tak zmienia zmienną win na true
        /// </summary>
        /// @see shooter, bullet, win, users_score, targetyNo, Bullet.healthies
        private void updating()
        {
            shooter.move();

            if (bullet.shoot == true)
            {
                bullet.move();
                bullet.collision(targety, targetyNo);
                if (bullet.healthies == 0)
                    win = true;
            }

            else
            {
                bullet.x = shooter.x;
                bullet.y = 640;
            }

            users_score.Text = bullet.points;


            int e = (targety.FindIndex(t => t.hit == true));

            if (e != -1)
                targety.RemoveAt(e);
        }

        /// <summary>
        /// Funckja ta zlicza "zdrowe produkty", czyli liczy ile obiektów gracz musi zbić (aby ukończyć dany poziom) i przypisuje je do zmiennej bullet.healthies.
        /// </summary>
        /// <param name="targety">
        /// parametrem jest lista wszystkich obiektów, które gracz może zbić podczas rozgrywki.
        /// </param>
        /// @see targety,  Bullet.healthies
        private void countHealthies(List<Target> targety)
        {
            int i = 0;
            foreach (Target target in targety)
            {
                if (target.healthy == 1)
                    i++;
            }
            bullet.healthies = i;
        }

        /// <summary>
        /// Funkcja sprawia, że po naciśnieciu przez gracza spacji zaczyna lecieć pocisk w stronę produktów
        /// </summary>
        private void Level1_shot(object sender, KeyEventArgs e) 
        {
            int keyIndex = e.KeyValue;

            if (keyIndex == 32)
                bullet.shoot = true;
        }

        /// <summary>
        /// Funkcja działa tak, że gracz w każdym momencie gry może wrócić do Menu, aby wybrać inny lub ten sam poziom (Level1, Level2, Level3) lub zobaczyć instrukcję (Manual)
        /// </summary>
        private void Menu_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        /// <summary>
        /// Funkcja działa tak, że gdy gracz ukończy poziom, może ponownie uruchomić poziom, który właśnie ukończył.
        /// </summary>
        private void restart_Click(object sender, EventArgs e)
        {
            Level1 lvl1 = new Level1();
            lvl1.Show();
            lvl1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        /// <summary>
        /// Funkcja sprawia, że po naciśnieciu "krzyżyka" na pasku z grą, aplikacja wyłączy się
        /// </summary>
        private void Level1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Application.Exit();
        }       
    }
}
