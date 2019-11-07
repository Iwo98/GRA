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
        int i = 0;
        public int healthies = 0;




        public void move()
        {
            y = y - 10;

            if(y<150)
            {
                
                shoot = false;
                
            }
        }

        public void hitbox(List<Target> targety)
        {

            foreach (Target target in targety)
            {
                if (target != null && x >= target.x && x <= (target.x + target.width) && y <= (target.y + target.height) && shoot == true)
                {
                    
                    target.hit = true;
                    i++;
                    Console.WriteLine(i);
                    if(target.healthy==1)
                    {
                        healthies--;
                    }
                    hit = true;
                    shoot = false;
                    if (target.healthy == 1)
                    {
                        int buf = Int32.Parse(points);
                        buf += 100;
                        points = Convert.ToString(buf);
                    }
                    else if (target.healthy == -1)
                    {
                        int buf = Int32.Parse(points);
                        buf -= 30;
                        points = Convert.ToString(buf);
                    }
                    else
                    {
                        int buf = Int32.Parse(points);
                        buf -= 10;
                        points = Convert.ToString(buf);
                    }

                

                }
            }

           
        }

        public void delete(Target target)
        {
            target = null;
        }
    }
}
