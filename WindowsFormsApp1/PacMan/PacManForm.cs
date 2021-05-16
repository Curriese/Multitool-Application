using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiToolApplication
{
    public partial class PacManForm : Form
    {
        private PacManGame pacmanGame;
        private int playerSpeed;
        SoundPlayer pacSoundStart = new SoundPlayer(@"C:\Users\Spenser\source\repos\WindowsFormsApp1\WindowsFormsApp1\PacMan\PacManSounds\pacman_beginning.wav");
        SoundPlayer pacSoundMunch = new SoundPlayer(@"C:\Users\Spenser\source\repos\WindowsFormsApp1\WindowsFormsApp1\PacMan\PacManSounds\pacman_chomp.wav");


        public PacManForm()
        {
            InitializeComponent();
            pacmanGame = new PacManGame();
            resetGame();
            scoreLabel.Text = "Score: " + pacmanGame.getScore();
            gameTimer.Start();

        }



        public void resetGame()
        {
            pacmanGame.nextLevel();
            pacmanchar.Left = 400;
            pacmanchar.Top = 692;


            //playerSpeed = 10;


            foreach (Control x in this.Controls)
            {
                if( x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacmanGame.setisUp(true);
                pacmanchar.Image = Properties.Resources.PacmanUpGif;
                pacmanGame.setNextDirection('U');
            }
            if (e.KeyCode == Keys.Down)
            {
                pacmanGame.setisDown(true);
                pacmanchar.Image = Properties.Resources.PacmanDownGif;
                pacmanGame.setNextDirection('D');
            }
            if (e.KeyCode == Keys.Right)
            {
                pacmanGame.setisRight(true);
                pacmanchar.Image = Properties.Resources.PacmanRightGif;
                pacmanGame.setNextDirection('R');
            }
            if (e.KeyCode == Keys.Left)
            {
                pacmanGame.setisLeft(true);
                pacmanchar.Image = Properties.Resources.PacmanLeftGif;
                pacmanGame.setNextDirection('L');
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                pacmanGame.setisUp(false);
            }
            if (e.KeyCode == Keys.Down)
            {
                pacmanGame.setisDown(false);
            }
            if (e.KeyCode == Keys.Right)
            {
                pacmanGame.setisRight(false);
            }
            if (e.KeyCode == Keys.Left)
            {
                pacmanGame.setisLeft(false);
            }
            
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            /*
            if(pacmanGame.atStart == true)
            {
                
                pacSoundStart.Play();
                Thread.Sleep(4000);
                pacmanGame.atStart = false;
            }*/

            Thread.Sleep(120);
            scoreLabel.Text = "Score: " + pacmanGame.getScore();
            pacmanGame.playGame();


            if (pacmanGame.getDirection() == 'U')
            {
                pacmanGame.moveUp();
                pacmanchar.Top -= pacmanGame.getPlayerSpeed();
            }
            if (pacmanGame.getDirection() == 'D')
            {
                pacmanGame.moveDown();
                pacmanchar.Top += pacmanGame.getPlayerSpeed();
            }
            if (pacmanGame.getDirection() == 'R')
            {
                pacmanGame.moveRight();
                pacmanchar.Left += pacmanGame.getPlayerSpeed();
            }
            if (pacmanGame.getDirection() == 'L')
            {
                pacmanGame.moveLeft();
                pacmanchar.Left -= pacmanGame.getPlayerSpeed();
            }


            


            //Teleport to each side using the hallway
            if(pacmanchar.Left < -30)
            {
                pacmanchar.Left = 840;
            }
            if(pacmanchar.Left > 840)
            {
                pacmanchar.Left = -30;
            }



            /*
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Dot" && x.Visible == true)
                    {
                        if (pacmanchar.Bounds.IntersectsWith(x.Bounds))
                        {
                            //pacmanGame.addScore(10); ;
                           // pacmanGame.subtractDotsLeft();
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "PowerPellet" && x.Visible == true)
                    {
                        if (pacmanchar.Bounds.IntersectsWith(x.Bounds))
                        {
                            //pacmanGame.addScore(50); ;
                            //pacmanGame.subtractDotsLeft();
                            x.Visible = false;
                        }
                    }


                    if((string)x.Tag == "Wall")
                    {
                        if (pacmanchar.Bounds.IntersectsWith(x.Bounds))
                        {
                            playerSpeed = 0;

                            switch (pacmanGame.getDirection())
                            {
                                case 'D':
                                    pacmanGame.noDown = true;
                                    pacmanchar.Top -= 11;
                                    break;
                                case 'U':
                                    pacmanGame.noUp = true;
                                    pacmanchar.Top += 11;
                                    break;
                                case 'R':
                                    pacmanGame.noRight = true;
                                    pacmanchar.Left -= 11;
                                    break;
                                case 'L':
                                    pacmanGame.noLeft = true;
                                    pacmanchar.Left += 11;
                                    break;

                            }

                        }
                    }


                }
            }

            */



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
