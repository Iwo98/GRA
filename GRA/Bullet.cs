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
        public int healthies = 0;

        public void hitbox(List<Target> targety, List<Target> targetyNo)
        {
            foreach (Target target in targety)
            {
                if (target != null && x >= target.x && x <= (target.x + target.width) && y <= (target.y + target.height) && shoot == true)
                {
                    int index;
                    string nazwa = target.name;
                    target.hit = true;
                    hit = true;
                    shoot = false;
                    checkIfHealthy(target);
                    index = (targetyNo.FindIndex(t => t.name == nazwa));
                    if (target != null && target.healthy==1 )
                        targetyNo[index].height -= 50;
                }
            }
        }

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

        public void move()
        {
            y = y - 12;
            if (y < 150)
                shoot = false;
        }

    }
}
