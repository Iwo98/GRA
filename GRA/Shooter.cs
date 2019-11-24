﻿using System;
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
        public int x = 10;
        public int y = 670;
        private int speed;
        public bool forward = true;

        public Shooter(int speed)
        {
            this.speed = speed;
        }

        public void move()
        {
            if (forward == true)
            {
                this.x=x+5;
                if ( this.x > 880 )
                    forward = false;
            }
            else
            {
                this.x=x-5;
                if( x < 30 )
                    forward = true;
            }
  
        }
    }
}
