using System;
using System.Collections.Generic;


namespace GRA
{
    class Bullet
    {
        public int height = 30;
        public int width = 20;
        public int x = 10;
        public int y = 640;
        private int speed;
        public bool shoot = false;
        public string points = "0";
        public int healthies = 0;

        public Bullet(int speed)    //giving a proper speed to the bullet
        {
            this.speed = speed;
        }

        public void collision(List<Target> targety, List<Target> targetyNo) //this function takes as arguments two lists of obejcts
        {                                                                  
            foreach (Target target in targety)
            {
                if (target != null && (x+width) >= target.x && x <= (target.x + target.width) && y <= (target.y + target.height) && shoot == true) //condition of hitting
                {                                                                                                                                  //the object by bullet
                    int index;
                    string nazwa = target.name;
                    target.hit = true;
                    shoot = false;
                    checkIfHealthy(target); //check if the object was "healthy" -- if it has the flag set on "1", "0", "-1" to properly give points for it
                    index = (targetyNo.FindIndex(t => t.name == nazwa)); //if we find a target of the same name in lists of targetNo -- we know that it was a healhty object.
                    if (target != null && target.healthy==1 )
                        targetyNo[index].hit = true;            //if the object exist and it healthy flag is on "1" then change it's hit flag to true so we can highlight the frame later.
                }
            }
        }

        private void checkIfHealthy(Target target)  //function checks the healthy flag so it can give a user a proper amount of points
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

        public void move()  //moving the object
        {
            y = y - speed;
            if (y < 150)
                shoot = false;
        }
    }
}
