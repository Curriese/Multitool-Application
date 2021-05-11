using MultiToolApplication.PacMan;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication
{
    class PacManGame

    {
        private int score;
        private int lives;
        private int dotsLeft;
        private char direction;
        public bool isUp, isDown, isLeft, isRight, isGameOver, atStart;
        public bool noUp, noDown, noLeft, noRight;
        private Tile[][] grid = new Tile[30][];
        //private ArrayList xTiles = new ArrayList();
        //private ArrayList yTiles = new ArrayList();

        //x = 30
        //y = 31


        //this is a Test comment for git practice




        public PacManGame()
        {
            NewGame();


        }


        public void NewGame()
        {
            score = 0;
            lives = 3;
            dotsLeft = 244;
            isGameOver = false;
            atStart = true;
            setUpMaze();
        }

        public void nextLevel()
        {
            dotsLeft = 244;
            atStart = true;
        }


        public void addScore(int x)
        {
            score += x;
        }

        public void subtractDotsLeft()
        {
            dotsLeft -= 1;
        }

        public void setUpMaze()
        {
            //x = 30
            //y = 31


            for (int i = 0; i < 29; i++)
            {
                grid[i] = new Tile[30];

                for(int j = 0; j < 30; j++)
                {
                    grid[i][j] = new Tile(i, j, true);
                }
                
            }

        }

        public void populateMaze()
        {
            //manuel populate the maze of dots with loops
        }















        public int getDotsLeft()
        {
            return dotsLeft;
        }

        public char getDirection()
        {
            return direction;
        }



        public int getScore()
        {
            return score;
        }

        #region Setters
        public void setisUp(bool x)
        {
            isUp = x;
        }
        public void setisDown(bool x)
        {
            isDown = x;
        }
        public void setisLeft(bool x)
        {
            isLeft = x;
        }
        public void setisRight(bool x)
        {
            isRight = x;
        }

        public void setDirection(char x)
        {
            direction = x;
        }

        #endregion
    }
}
