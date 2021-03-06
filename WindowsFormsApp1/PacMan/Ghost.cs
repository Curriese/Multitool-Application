using System;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class Ghost
    {
        private int xLocation;
        private int yLocation;

        //Change to change the ghost speed;
        private int speed;

        private String name;

        private char direction;
        private char nextDirection;

        private bool isScared;

        public Ghost(int startingX, int startingY, String ghostName)
        {
            xLocation = startingX;
            yLocation = startingY;
            isScared = false;
            name = ghostName;
            speed = 1;
        }

        public Ghost(int startingX, int startingY, String ghostName, char startingDirection)
        {
            xLocation = startingX;
            yLocation = startingY;
            isScared = false;
            name = ghostName;
            direction = startingDirection;
            speed = 1;
        }


        





        public void updateDirection()
        {
            direction = nextDirection;
            nextDirection = '-';
        }


        #region Getters
        public int getX()
        {
            return xLocation;
        }
        public int getY()
        {
            return yLocation;
        }
        public char getDirection()
        {
            return direction;
        }
        public char getNextDirection()
        {
            return nextDirection;
        }
        public bool getIsScared()
        {
            return isScared;
        }
        public String getName()
        {
            return name;
        }
        public int getSpeed()
        {
            return speed;
        }


        #endregion
        #region Setters

        public void setSpeed(int newSpeed)
        {
            speed = newSpeed;
        }

        public void setLocation(int newX, int newY)
        {
            xLocation = newX;
            yLocation = newY;
        }
        public void setDirection(char newDirection)
        {
            direction = newDirection;
        }
        public void setNextDirection(char newNextDirection)
        {
            nextDirection = newNextDirection;
        }


        #endregion

    }
}
