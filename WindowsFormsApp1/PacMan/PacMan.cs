using MultiToolApplication.PacMan;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MultiToolApplication
{
    class PacManGame

    {
        private int score;
        private int lives;
        private int dotsLeft;
        private int pacmanSpeed  = 10;
        private int ghostSpeed = 10;
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
            populateMaze();
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
            //width of the  game gridx = 30
            //height of the  game gridy = 31

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

            TextReader pathLocation = File.OpenText("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\PacMan\\Pathabletiles.txt");
            TextReader dotLocation = File.OpenText("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\PacMan\\Dotlocations.txt");


            for (int k = 0; k < 304; k++)
            {
                //read in the tiles dot locations and update the tiles in the grid

                int xDot = int.Parse(dotLocation.ReadLine());
                int yDot = int.Parse(dotLocation.ReadLine());
                dotLocation.ReadLine();


                int xPath = int.Parse(pathLocation.ReadLine());
                int yPath = int.Parse(pathLocation.ReadLine());
                pathLocation.ReadLine();

                for (int i = 0; i < 29; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {

                        //read in pathable tiles and update the grid

                        if (i == xPath && j == yPath)
                        {
                            grid[i][j].changePath(true);


                            //change with item
                            grid[i][j].changeEmpty();
                        }
                        if(i == xDot && j == yDot)
                        {
                            grid[i][j].changeEmpty();
                            grid[i][j].updateItem('D');
                        }
                        if (i == 2 && j == 4 || i == 2 && j == 24 || i == 27 && j == 4 || i == 27 && j == 24)
                        {
                            grid[i][j].changeEmpty();
                            grid[i][j].updateItem('P');
                        }
                    }
                }
            }
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
