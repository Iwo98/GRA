using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    class Bullet
    {
        public int height = 20;
        public int width = 20;
        public int x = 10;
        public int y = 660;
        public Boolean shoot = false;
        public Boolean hit = false;
     

        public void move()
        {
            y = y - 4;

            if(y<150)
            {
                
                shoot = false;
                
            }
        }

        public void hitbox(Target target)
        {
            if (x >= target.x && x <= (target.x + target.width) && y <= ( target.y + target.height) && shoot == true )
            {
                target.hit = true;
                target.x = 1000;
                hit = true;
                shoot = false;
               

            }
          
        }
    }
}
