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
        private char nextDirection = '-';
        public bool isUp, isDown, isLeft, isRight, isGameOver, atStart;
        public bool upFlag, DownFlag, LeftFlag, RightFlag;
        
        

        private PackManPlayer player;
        private Tile[][] grid = new Tile[31][];
        //private ArrayList xTiles = new ArrayList();
        //private ArrayList yTiles = new ArrayList();

        //x = 30
        //y = 31






        public PacManGame()
        {
            NewGame();

        }


        public void NewGame()
        {
            score = 0;
            lives = 3;
            isGameOver = false;
            atStart = true;
            setUpMaze();
            populateMaze();
            player = new PackManPlayer(15, 24);
            //grid[15][24].setOccupied('P');
            direction = 'R';

        }

        public void nextLevel()
        {
            
            atStart = true;
        }

        public void setUpMaze()
        {
            //width of the  game gridx = 30
            //height of the  game gridy = 31

            TextReader pathLocation = File.OpenText("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\PacMan\\Pathabletiles.txt");

            
            for (int i = 0; i < 31; i++)
            {
                grid[i] = new Tile[32];

                for (int j = 0; j < 32; j++)
                {
                    Tile newTile = new Tile(i, j, true);
                    grid[i][j] = newTile;
                }
            }

            for (int k = 0; k < 305; k++)
            {
                int xPath = int.Parse(pathLocation.ReadLine());
                int yPath = int.Parse(pathLocation.ReadLine());
                pathLocation.ReadLine();

                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        if (i == xPath && j == yPath)
                        {
                            grid[i][j].changePathTrue();
                            Debug.WriteLine("Tile " + i + " , " + j + " is now pathable");
                            //Find why the tile is reseting to unpathable
                        }
                    }
                }

            }
        }

        public void populateMaze()
        {
            //manuel populate the maze of dots with loops

            
            TextReader dotLocation = File.OpenText("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\PacMan\\Dotlocations.txt");

            
            for (int k = 0; k < 305; k++)
            {
                //read in the tiles dot locations and update the tiles in the grid

                int xDot = int.Parse(dotLocation.ReadLine());
                int yDot = int.Parse(dotLocation.ReadLine());
                dotLocation.ReadLine();

                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {

                        //Update where items are on the grid
                        if (i == xDot && j == yDot)
                        {
                            grid[i][j].changeEmpty();
                            grid[i][j].setItem('D');
                            dotsLeft++;
                            Debug.WriteLine("dotsLeft = " + dotsLeft + " At Location " + i + " " + j + " K: " + k);
                        }
                    }
                }
                
            }


            grid[2][4].setItem('P');
            grid[2][4].changeEmpty();
            grid[2][24].setItem('P');
            grid[2][24].changeEmpty();
            grid[27][4].setItem('P');
            grid[27][4].changeEmpty();
            grid[27][24].setItem('P');
            grid[27][24].changeEmpty();
            dotsLeft++;
            dotsLeft++;
            dotsLeft++;
            dotsLeft++;
            dotLocation.Close();
        }


        public void playGame()
        {
            

            Debug.WriteLine("Pac-Man Location " + player.getXLocation() +" " + player.getYLocation());


        }


        public void moveRight()
        {
            //See if the player wants to move another direction
            if(nextDirection == 'U')
            {
                moveUp();
            }
            if(nextDirection == 'D')
            {
                moveDown();
            }
            if(nextDirection == 'L')
            {
                moveLeft();
            }

            //Checks if the next tile is pathable if so update direction and move that direction
            if (grid[player.getXLocation() + 1][player.getYLocation()].getPathable())
            {
                updateDirection();
                player.setLocation(player.getXLocation() + 1, player.getYLocation());
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'D')
                {
                    score += 10;
                    dotsLeft -= 1;
                    grid[player.getXLocation()][player.getYLocation()].removeItem();
                }
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'P')
                {
                    score += 50;
                    dotsLeft -= 1;
                    grid[player.getXLocation()][player.getYLocation()].removeItem();
                }
            }
        }

        public void moveLeft()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'U')
            {
                moveUp();
            }
            if (nextDirection == 'D')
            {
                moveDown();
            }
            if (nextDirection == 'R')
            {
                moveRight();
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (grid[player.getXLocation() - 1][player.getYLocation()].getPathable())
            {
                updateDirection();
                player.setLocation(player.getXLocation() - 1, player.getYLocation());
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'D')
                {
                    score += 10;
                    dotsLeft -= 1;
                }
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'P')
                {
                    score += 50;
                    dotsLeft -= 1;
                }
            }
        }

        public void moveUp()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'R')
            {
                moveRight();
            }
            if (nextDirection == 'D')
            {
                moveDown();
            }
            if (nextDirection == 'L')
            {
                moveLeft();
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (grid[player.getXLocation()][player.getYLocation() - 1].getPathable())
            {
                updateDirection();
                player.setLocation(player.getXLocation(), player.getYLocation() - 1);
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'D')
                {
                    score += 10;
                    dotsLeft -= 1;
                }
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'P')
                {
                    score += 50;
                    dotsLeft -= 1;
                }
            }
        }


        public void moveDown()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'U')
            {
                moveUp();
            }
            if (nextDirection == 'R')
            {
                moveRight();
            }
            if (nextDirection == 'L')
            {
                moveLeft();
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (grid[player.getXLocation()][player.getYLocation() + 1].getPathable())
            {
                updateDirection();
                player.setLocation(player.getXLocation(), player.getYLocation() + 1);
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'D')
                {
                    score += 10;
                    dotsLeft -= 1;
                }
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'P')
                {
                    score += 50;
                    dotsLeft -= 1;
                }
            }
        }






        public void addScore(int x)
        {
            score += x;
        }

        public void subtractDotsLeft()
        {
            dotsLeft -= 1;
        }

        public void updateDirection()
        {
            if(nextDirection != '-')
            {

                direction = nextDirection;
                nextDirection = '-';
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

        public int getPlayerSpeed()
        {
            return pacmanSpeed;
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

        public void setNextDirection(char x)
        {
            nextDirection = x;
        }

        #endregion
    }
}
