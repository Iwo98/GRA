using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    /// Klasa w której znajdują się niezbędne zmienne do utworzenia i działania obiektu target
    class Target
    {
        /// <summary>
        /// Zmienna opisująca współrzędną X celu
        /// </summary>
        public int x;
        /// <summary>
        /// Zmienna opisująca współrzędną Y celu
        /// </summary>
        public int y;
        /// <summary>
        /// Zmienna opisująca wysokość celu
        /// </summary>
        public int height = 20;
        /// <summary>
        /// Zmienna opisująca szerokość celu
        /// </summary>
        public int width = 20;
        /// <summary>
        /// Zmienna określająca czy dany cel został już trafiony - aby można go na tej podstawie usunąć z planszy
        /// </summary>
        public bool hit = false;
        /// <summary>
        /// Zmienna potrzebna do klasyfikacji obiektu podczas zbijania.
        /// 
        /// 1. healthy == 0 - oznacza, że cel jest neutralny i gracz za jego zbicie ma stracić 10 punktów.
        /// 
        /// 2. healthy == -1 - oznacza, że cel jest szkodliwy i gracz za jego zbicie ma stracić 50 punktów.
        /// 
        /// 3. healthy == 1 - oznacza, że cel jest zdrowotny i gracz za jego zbicie ma zyskać 100 punktów.
        /// </summary>
        /// @see Bullet.checkIfHealthy
        public int healthy = 0;
        /// <summary>
        /// Zmienna, w  której przechowywana jest nazwa produktu potrzebna między innymi do wyrysowania odpowiedniego obrazka na planszy.
        /// </summary>
        public string name;


        /// <summary>
        /// Konstrukor klasy Target
        /// </summary>
        /// <param name="x">
        /// współrzędna x celu
        /// </param>
        /// <param name="y">
        /// współrzędna y celu
        /// </param>
        /// <param name="height">
        /// wysokość celu
        /// </param>
        /// <param name="width">
        /// szerokość celu
        /// </param>
        /// <param name="healthy">
        /// klasyfikacja celu
        /// </param>
        /// <param name="name">
        /// nazwa celu
        /// </param>
        /// @see name, x, y, height, width, healthy, name
        public Target(int x, int y, int height, int width, int healthy, string name) 
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.healthy = healthy;
            this.name = name;
        }
    }
}
