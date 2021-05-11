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
            pacmanGame.NewGame();
            resetGame();
            scoreLabel.Text = "Score: " + pacmanGame.getScore();
            gameTimer.Start();

        }



        public void resetGame()
        {
            pacmanGame.nextLevel();
            pacmanchar.Left = 400;
            pacmanchar.Top = 692;


            playerSpeed = 10;


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
            playerSpeed = 10;
            if (e.KeyCode == Keys.Up && pacmanGame.noUp == false)
            {
                pacmanGame.setisUp(true);
                pacmanchar.Image = Properties.Resources.PacmanUpGif;
                pacmanGame.setDirection('U');
                pacmanGame.noRight  = false;
                pacmanGame.noLeft = false;
                pacmanGame.noDown = false;
            }
            if (e.KeyCode == Keys.Down && pacmanGame.noDown == false)
            {
                pacmanGame.setisDown(true);
                pacmanchar.Image = Properties.Resources.PacmanDownGif;
                pacmanGame.setDirection('D');
                pacmanGame.noRight = false;
                pacmanGame.noLeft = false; 
                pacmanGame.noUp = false;
            }
            if (e.KeyCode == Keys.Right && pacmanGame.noRight == false)
            {
                pacmanGame.setisRight(true);
                pacmanchar.Image = Properties.Resources.PacmanRightGif;
                pacmanGame.setDirection('R');
                pacmanGame.noLeft = false;
                pacmanGame.noUp = false;
                pacmanGame.noDown = false;
            }
            if (e.KeyCode == Keys.Left && pacmanGame.noLeft == false)
            {
                pacmanGame.setisLeft(true);
                pacmanchar.Image = Properties.Resources.PacmanLeftGif;
                pacmanGame.setDirection('L');
                pacmanGame.noUp = false;
                pacmanGame.noDown = false;
                pacmanGame.noRight = false;
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
            }
            */
            
            scoreLabel.Text = "Score: " + pacmanGame.getScore();


            if(pacmanGame.isLeft == true)
            {
                pacmanchar.Left -= playerSpeed;
            }
            if (pacmanGame.isRight == true)
            {
                pacmanchar.Left += playerSpeed;
            }
            if(pacmanGame.isDown == true)
            {
                pacmanchar.Top += playerSpeed;
            }
            if(pacmanGame.isUp == true)
            {
                pacmanchar.Top -= playerSpeed;
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

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Dot" && x.Visible == true)
                    {
                        if (pacmanchar.Bounds.IntersectsWith(x.Bounds))
                        {
                            pacmanGame.addScore(10); ;
                            pacmanGame.subtractDotsLeft();
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "PowerPellet" && x.Visible == true)
                    {
                        if (pacmanchar.Bounds.IntersectsWith(x.Bounds))
                        {
                            pacmanGame.addScore(50); ;
                            pacmanGame.subtractDotsLeft();
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


            if (pacmanGame.getDotsLeft() == 0)
            {
                resetGame();
            }



        }
    }
}
