using System;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class Location
    {
        int x;
        int y;

        public Location(int newX, int newY)
        {
            x = newX;
            y = newY;
        }


        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }


    }
}
