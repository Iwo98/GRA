using System;
using System.Collections.Generic;


namespace GRA
{
    ///Klasa w której znajdują się niezbędne funkcje i zmienne do utworzenia i działania obiektu bullet
    class Bullet
    {
        /// <summary>
        /// Zmienna opisująca wysokość pocisku
        /// </summary>
        public int height = 30;
        /// <summary>
        /// Zmienna opisująca szerokość pocisku
        /// </summary>
        public int width = 20;
        /// <summary>
        /// Zmienna opisująca współrzędną X pocisku
        /// </summary>
        public int x = 10;
        /// <summary>
        /// Zmienna opisująca współrzędną Y pocisku
        /// </summary>
        public int y = 640;
        /// <summary>
        /// Zmienna opisująca szybość poruszania się pocisku
        /// </summary>
        private int speed;
        /// <summary>
        /// Zmienna opisująca czy pocisk został wystrzelony
        /// </summary>
        public bool shoot = false;
        /// <summary>
        /// Zmienna przetrzymująca aktualny wynik gracza
        /// </summary>
        public string points = "0";
        /// <summary>
        /// Zmienna przetrzymująca liczbę obiektów, które gracz musi zbić
        /// </summary>
        public int healthies = 0;

        /// <summary>
        /// Konstruktor, klasy Bullet
        /// </summary>
        /// <param name="speed">
        /// Ten parametr odpowiedzialny jest za prędkość poruszania się pocisku
        /// </param>
        /// @see speed
        public Bullet(int speed)    
        {
            this.speed = speed;
        }

        /// <summary>
        /// Funkcja ta przyjmuje za argument dwie listy - listę obiektów, które gracz ma zestrzelić (targety.No) oraz liste wszystkich obiektów(targety).
        /// 
        /// Funkcja sprawdza czy pocisk uderzył, w któryś obiekt porównując współrzedne pocisku z kolejnymi współrzednymi obietów z listy targety (które stworzone są z klasy Target).
        /// 
        /// Następnie jeśli doszło do zderzenia klasyfikuje za pomocą funkcji checkIfHealthy, ile punktów należy za to zbicie dodać lub odjąć oraz trafiony obiekt oznacza, aby można było usunąć go z planszy.
        /// </summary>
        /// <param name="targety">
        /// lista wszystkich obiektów
        /// </param>
        /// <param name="targetyNo">
        /// lista obiektów, które musi zbić gracz by wygrać
        /// </param>
        /// @see  x, y, Level1.targetyNo, Level1.targety
        public void collision(List<Target> targety, List<Target> targetyNo) 
        {                                                                  
            foreach (Target target in targety)
            {
                if (target != null && (x+width) >= target.x && x <= (target.x + target.width) && y <= (target.y + target.height) && shoot == true) 
                {                                                                                                                                  
                    int index;
                    string nazwa = target.name;
                    target.hit = true;
                    shoot = false;
                    checkIfHealthy(target); 
                    index = (targetyNo.FindIndex(t => t.name == nazwa)); 
                    if (target != null && target.healthy==1 )
                        targetyNo[index].hit = true;            
                }
            }
        }


        /// <summary>
        /// Funkcja ta klasyfikuje obiekt klasy Target, a następnie uaktualnia punkty gracza (points), w zależności od klasyfikacji (Target.healthy)
        /// </summary>
        /// <param name="target">
        /// Obiekt klasy Target
        /// </param>
        /// @see Target.healthy, points
        private void checkIfHealthy(Target target)  
        {
            if (target.healthy == 1)
            {
                healthies--;
                int buf = Int32.Parse(points);
                buf += 100;
                points = Convert.ToString(buf);
            }
            else if (target.healthy == -1)
            {
                int buf = Int32.Parse(points);
                buf -= 50;
                points = Convert.ToString(buf);
            }
            else
            {
                int buf = Int32.Parse(points);
                buf -= 10;
                points = Convert.ToString(buf);
            }
        }

        /// <summary>
        /// Funkcja zmienia współrzędne Y pocisku, czyli sprawia, że się porusza
        /// </summary>
        /// @see y
        public void move()  
        {
            y = y - speed;
            if (y < 150)
                shoot = false;
        }
    }
}
