﻿using System;
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
        public int x = 5;
        public int y = 375;
        public Boolean shoot = false;
     

        public void move()
        {
            y = y - 4;

            if(y<100)
            {
                y = 375;
                shoot = false;
            }
        }
    }
}