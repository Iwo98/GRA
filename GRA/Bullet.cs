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
        public string points = "0";
        
       
     

        public void move()
        {
            y = y - 6;

            if(y<150)
            {
                
                shoot = false;
                
            }
        }

        public void hitbox(List<Target> targety)
        {
            foreach(Target target in targety)
            if (x >= target.x && x <= (target.x + target.width) && y <= ( target.y + target.height) && shoot == true )
            {
                
                target.hit = true;
                target.x = 2000;
                hit = true;
                shoot = false;
                if(target.healthy == true)
                {
                        int buf = Int32.Parse(points);
                        buf += 50;
                        points = Convert.ToString(buf);
                }
                else if(target.healthy == false)
                {
                        int buf = Int32.Parse(points);
                        buf -= 20;
                        points = Convert.ToString(buf);
                }
            }
          
        }
    }
}
