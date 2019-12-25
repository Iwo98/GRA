using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    class Shooter
    {
        public int height = 80;
        public int width = 40;
        public int x = 40;
        public int y = 670;
        private int speed;
        public bool forward = true; //the flag that says if the obejct is going back or forward

        public Shooter(int speed)
        {
            this.speed = speed; //giving a proper speed to the shooter
        }

        public void move()    //funtion that moves the shooter forward and back
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
