using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    /// Klasa w której znajdują się niezbędne funkcje i zmienne do utworzenia i działania obiektu shooter
    class Shooter
    {
        /// <summary>
        /// Zmienna opisująca wysokość strzelającego obiektu
        /// </summary>
        public int height = 80;
        /// <summary>
        /// Zmienna opisująca szerokość strzelającego obiektu
        /// </summary>
        public int width = 40;
        /// <summary>
        /// Zmienna opisująca współrzędną X strzelającego obiektu
        /// </summary>
        /// 
        public int x = 40;
        /// <summary>
        /// Zmienna opisująca współrzędną Y strzelającego obiektu
        /// </summary>
        public int y = 670;
        /// <summary>
        /// Zmienna opisująca prędkość poruszania się strzelającego obiektu
        /// </summary>
        private int speed;
        /// <summary>
        /// Zmienna opisująca kierunek poruszania się strzelającego obiektu (forward==true - porusza sie od lewej do prawej)
        /// </summary>
        public bool forward = true;

        /// <summary>
        /// Konstruktor, klasy Shooter
        /// </summary>
        /// <param name="speed">
        /// Ten parametr odpowiedzialny jest za prędkość poruszania się strzelającego obiektu
        /// </param>
        /// @see speed
        public Shooter(int speed)
        {
            this.speed = speed; 
        }

        /// <summary>
        /// Funkcja zmienia współrzędne X strzelającego obiektu, czyli sprawia, że się porusza
        /// </summary>
        /// @see x
        public void move()    
        {
            if (forward == true)
            {
                this.x=x+speed;
                if ( this.x >= 880 )
                    forward = false;
            }
            else
            {
                this.x=x-speed;
                if( x <= 40 )
                    forward = true;
            }
        }
    }
}
