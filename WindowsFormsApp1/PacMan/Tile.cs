using System;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class Tile
    {
        private int xValue, yValue;
        private bool isEmpty, pathable;
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



        public void changeEmpty()
        {
            if(isEmpty == true)
            {
                isEmpty = false;
            }
            else
            {
                isEmpty = true;
            }
        }



    }
}
