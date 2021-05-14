using System;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class Tile
    {
        private int xValue, yValue;
        private bool isEmpty, pathable;




        //Tiles items (Dot = D, Pellet = P, Fruit = F)
        private char tileItem;


        public Tile(int x, int y, bool empty)
        {
            xValue = x;
            yValue = y;
            isEmpty = empty;
        }

        public Tile(int x, int y, bool empty, char item)
        {
            xValue = x;
            yValue = y;
            isEmpty = empty;
            tileItem = item;
        }

        public void changePath(bool path)
        {
            pathable = path;
        }

        public void updateItem(char item)
        {
            tileItem = item;
        }



        public void changeEmpty()
        {
            if(isEmpty == true)
            {
                isEmpty = false;
            }
            if(isEmpty == false)
            {
                isEmpty = true;
            }
        }


        public string ToString() 
        {
            return "X = " + xValue + " & Y = " + yValue;
        }



    }
}
