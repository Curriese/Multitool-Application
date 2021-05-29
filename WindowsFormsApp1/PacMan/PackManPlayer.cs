using System;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class PackManPlayer
    {
        int xLocation;
        int yLocation;
        


        public PackManPlayer(int startingX, int startingY)
        {
            xLocation = startingX;
            yLocation = startingY;
        }


        public void setLocation(int newXLocation, int newYLocation)
        {
            xLocation = newXLocation;
            yLocation = newYLocation;
        }

        public int getXLocation()
        {
            return xLocation;
        }

        public int getYLocation()
        {
            return yLocation;
        }






    }
}
