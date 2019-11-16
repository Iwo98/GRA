using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    class Target
    {
        public int x;
        public int y;
        public int height = 20;
        public int width = 20;
        public bool hit = false;
        public int healthy = 0;
        public string name;
        


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
