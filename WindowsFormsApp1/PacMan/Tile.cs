using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MultiToolApplication.PacMan
{
    class Tile
    {
        private int xValue, yValue;
        private bool isEmpty, pathable;
        private Image image;



        //Either (PacMan = P or Ghost = G)
        private char occupiedBy;

        //Tiles items (Dot = D, Pellet = P, Fruit = F, Empty = E)
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

        public void changePathTrue()
        {
            pathable = true;
        }

        public char getItem()
        {
            return tileItem;
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
        public bool isTileEmpty()
        {
            return isEmpty;
        }


        public void setImage(string imagePath)
        {
            image = Image.FromFile(imagePath);
        }

        public void setOccupied(char character)
        {
            occupiedBy = character;
        }

        public void setItem(char newItem)
        {
            tileItem = newItem;
        }

        public void removeItem()
        {
            tileItem = 'E';
        }



        public bool getPathable()
        {
            return pathable;
        }

        



    }
}
