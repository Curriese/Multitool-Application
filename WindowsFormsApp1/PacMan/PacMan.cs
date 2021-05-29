using MultiToolApplication.PacMan;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MultiToolApplication
{
    class PacManGame

    {
        private int score;
        private int lives;
        private int dotsLeft;
        private int pacmanSpeed  = 1;
        private int ghostSpeed = 10;
        private char direction;
        private char nextDirection = '-';
        public bool isUp, isDown, isLeft, isRight, isGameOver, atStart;
        public bool upFlag, DownFlag, LeftFlag, RightFlag;
        
        

        private PackManPlayer player;
        private Ghost redGhost, pinkGhost, cyanGhost, orangeGhost;
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
            lives = 2;
            isGameOver = false;
            atStart = true;
            setUpMaze();
            populateMaze();
            player = new PackManPlayer(15, 24);
            redGhost = new Ghost(14, 12, "Blinky", 'L');
            pinkGhost = new Ghost(15, 15, "Pinky");
            cyanGhost = new Ghost(13, 15, "Inky");
            orangeGhost = new Ghost(17, 15, "Cylde");
            //grid[15][24].setOccupied('P');
            direction = 'R';

        }

        public void nextLevel()
        {
            atStart = false;
            populateMaze();
            player = new PackManPlayer(15, 24);
            //grid[15][24].setOccupied('P');
            direction = 'R';
        }

        public void resetFromDeath()
        {
            player = new PackManPlayer(15, 24);
            direction = 'R';
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
                            Debug.WriteLine("Pathable Location: " + i + " , " + j);
                        }
                    }
                }

            }
            pathLocation.Close();
        }

        public void populateMaze()
        {
            //manuel populate the maze of dots with loops

            if (atStart == true)
            {
                TextReader dotLocation = File.OpenText("C:\\Users\\Spenser\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\PacMan\\Dotlocations.txt");


                for (int k = 0; k < 245; k++)
                {
                    //read in the tiles dot locations and update the tiles in the grid

                    int xDot = int.Parse(dotLocation.ReadLine());
                    int yDot = int.Parse(dotLocation.ReadLine());
                    dotLocation.ReadLine();

                    for (int i = 0; i <= 31; i++)
                    {
                        for (int j = 0; j <= 32; j++)
                        {


                            //Update where items are on the grid
                            if ((i == xDot && j == yDot) && grid[i][j].isTileEmpty() == true)
                            {
                                grid[i][j].changeEmpty();
                                grid[i][j].setItem('D');
                                ///Debug.WriteLine("Added dot at: " + i + " , " + j);
                                break;
                            }
                        }
                    }

                }
                dotLocation.Close();
            } 
            else
            {
                Thread.Sleep(3000);
                for(int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {

                        //Update where items are on the grid
                        if (grid[i][j].getItem() == 'E')
                        {
                            grid[i][j].setItem('D');
                        }
                    }
                }
            }
            //Set up the special cases for Power Pellets
            grid[2][4].setItem('P');
            grid[2][4].changeEmpty();
            grid[2][24].setItem('P');
            grid[2][24].changeEmpty();
            grid[27][4].setItem('P');
            grid[27][4].changeEmpty();
            grid[27][24].setItem('P');
            grid[27][24].changeEmpty();
            dotsLeft = 244;
            dotsLeft = 244;
        }



        public void moveRight()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'U')
            {
                if (checkUp() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'D')
            {
                if (checkDown() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'L')
            {
                if (checkLeft() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }

            //Checks if the next tile is pathable if so update direction and move that direction
            if (checkRight())
            {
                pacmanSpeed = 1;
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
                if (checkUp() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'D')
            {
                if (checkDown() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'R')
            {
                if (checkRight() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (checkLeft())
            {
                pacmanSpeed = 1;
                player.setLocation(player.getXLocation() - 1, player.getYLocation());
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

        public void moveUp()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'R')
            {
                if (checkRight() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'D')
            {
                if(checkDown() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'L')
            {
                if (checkLeft() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (checkUp())
            {
                pacmanSpeed = 1;
                player.setLocation(player.getXLocation(), player.getYLocation() - 1);
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


        public void moveDown()
        {
            //See if the player wants to move another direction
            if (nextDirection == 'U')
            {
                if(checkUp() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'R')
            {
                if (checkRight() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            if (nextDirection == 'L')
            {
                if (checkLeft() == true)
                {
                    updateDirection();
                    pacmanSpeed = 0;
                }
                return;
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (checkDown())
            {
                pacmanSpeed = 1;
                player.setLocation(player.getXLocation(), player.getYLocation() + 1);
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'D')
                {
                    score += 10;
                    dotsLeft -= 1;
                    grid[player.getXLocation()][player.getYLocation()].removeItem();
                    grid[player.getXLocation()][player.getYLocation()].setItem('E');
                }
                if (grid[player.getXLocation()][player.getYLocation()].getItem() == 'P')
                {
                    score += 50;
                    dotsLeft -= 1;
                    grid[player.getXLocation()][player.getYLocation()].removeItem();
                    grid[player.getXLocation()][player.getYLocation()].setItem('E');
                }
            }
        }


        public bool checkUp()
        {
            if(grid[player.getXLocation()][player.getYLocation() - 1].getPathable() == true)
            {
                Debug.WriteLine("Check Up true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + player.getXLocation() + " " + (player.getYLocation() - 1) );
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkDown()
        {
            if (grid[player.getXLocation()][player.getYLocation() + 1].getPathable() == true)
            {
                Debug.WriteLine("Check Down true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + player.getXLocation() + " " + (player.getYLocation() + 1));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkLeft()
        {
            if(player.getXLocation() == 1 && player.getYLocation() == 15)
            {
                player.setLocation(28, 15);
            }


            if (grid[player.getXLocation() - 1][player.getYLocation()].getPathable() == true)
            {
                Debug.WriteLine("Check Left true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + (player.getXLocation() -1) + " " + player.getYLocation() );
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkRight()
        {
            if (player.getXLocation() == 28 && player.getYLocation() == 15)
            {
                player.setLocation(1, 15);
            }

            if (grid[player.getXLocation() + 1][player.getYLocation()].getPathable() == true)
            {
                Debug.WriteLine("Check Right true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + (player.getXLocation() + 1) + " " + player.getYLocation());
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool checkGhostCollision()
        {
            if(grid[player.getXLocation()][player.getYLocation()] == grid[redGhost.getX()][redGhost.getY()])
            {
                lives -= 1;
                return true;
            }
            else if (grid[player.getXLocation()][player.getYLocation()] == grid[pinkGhost.getX()][pinkGhost.getY()])
            {
                lives -= 1;
                return true;
            }
            else if (grid[player.getXLocation()][player.getYLocation()] == grid[cyanGhost.getX()][cyanGhost.getY()])
            {
                lives -= 1;
                return true;
            }
            else if (grid[player.getXLocation()][player.getYLocation()] == grid[orangeGhost.getX()][orangeGhost.getY()])
            {
                lives -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkGameOver()
        {
            if(lives == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void moveRedGhost()
        {
            if(redGhost.getX() != player.getXLocation())
            {
                if(redGhost.getY() != player.getXLocation())
                {

                }
            }














            //See if the player wants to move another direction
            if (redGhost.getDirection() == 'U')
            {
                if (checkUp() == true)
                {
                    updateDirection();
                    redGhost.setSpeed(0);
                }
                return;
            }
            if (redGhost.getDirection() == 'R')
            {
                if (checkRight() == true)
                {
                    updateDirection();
                    redGhost.setSpeed(0);
                }
                return;
            }
            if (redGhost.getDirection() == 'L')
            {
                if (checkLeft() == true)
                {
                    
                    redGhost.setSpeed(0);
                }
                return;
            }
            if (redGhost.getDirection() == 'D')
            {
                if (checkLeft() == true)
                {
                    updateDirection();
                    redGhost.setSpeed(0);
                }
                return;
            }
            //Checks if the next tile is pathable if so update direction and move that direction
            if (checkDown())
            {
                redGhost.setSpeed(1);
                redGhost.setLocation(redGhost.getX(), redGhost.getY() + 1);
            }
        }


        public bool ghostCheckUp()
        {
            if (grid[player.getXLocation()][player.getYLocation() - 1].getPathable() == true)
            {
                Debug.WriteLine("Check Up true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + player.getXLocation() + " " + (player.getYLocation() - 1));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ghostCheckDown()
        {
            if (grid[player.getXLocation()][player.getYLocation() + 1].getPathable() == true)
            {
                Debug.WriteLine("Check Down true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + player.getXLocation() + " " + (player.getYLocation() + 1));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ghostCheckLeft()
        {
            if (player.getXLocation() == 1 && player.getYLocation() == 15)
            {
                player.setLocation(28, 15);
            }


            if (grid[player.getXLocation() - 1][player.getYLocation()].getPathable() == true)
            {
                Debug.WriteLine("Check Left true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + (player.getXLocation() - 1) + " " + player.getYLocation());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ghostCheckRight()
        {
            if (player.getXLocation() == 28 && player.getYLocation() == 15)
            {
                player.setLocation(1, 15);
            }

            if (grid[player.getXLocation() + 1][player.getYLocation()].getPathable() == true)
            {
                Debug.WriteLine("Check Right true. PacMan Location " + player.getXLocation() + " " + player.getYLocation());
                Debug.WriteLine("Location checked : " + (player.getXLocation() + 1) + " " + player.getYLocation());
                return true;
            }
            else
            {
                return false;
            }
        }





















        public void addScore(int x)
        {
            score += x;
        }

        public void updateDirection()
        {
            if(nextDirection != '-')
            {

                direction = nextDirection;
                nextDirection = '-';
            }
        }
        #region Getters

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

        public int getLives()
        {
            return lives;
        }
        #endregion

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
        public void setSpeed(int newSpeed)
        {
            pacmanSpeed = newSpeed;
        }

        #endregion
    }
}
