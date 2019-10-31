using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA
{
    class Shooter
    {
        public int height = 60;
        public int width = 20;
        public int x = 5;
        public int y = 415;
        Boolean forward = true;

        public Shooter()
        {

        }

        public void move()
        {
            
            if (forward == true)
            {
                this.x=x+2;
                if (this.x > 567)
                {
                    forward = false;
                }
            }
            else
            {
                this.x=x-2;
                if( x < 30)
                {
                    forward = true;
                }
            }

            
        }
    }
}
