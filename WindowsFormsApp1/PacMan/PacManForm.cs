using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        SoundPlayer pacSoundStart = new SoundPlayer(@"C:\Users\Spenser\source\repos\WindowsFormsApp1\WindowsFormsApp1\PacMan\PacManSounds\pacman_beginning.wav");
        SoundPlayer pacSoundMunch = new SoundPlayer(@"C:\Users\Spenser\source\repos\WindowsFormsApp1\WindowsFormsApp1\PacMan\PacManSounds\pacman_chomp.wav");


        public PacManForm()
        {
            InitializeComponent();
            pacmanGame = new PacManGame();
            resetGame();
            scoreLabel.Text = "Score: \n" +  pacmanGame.getScore();
            gameTimer.Start();
            hiddenPacMan.Visible = true;
            hiddenPacMan.BackColor = Color.Transparent;

        }



        public void resetGame()
        {
            pacmanGame.nextLevel();

            pacmanchar.Left = 440;
            pacmanchar.Top = 728;
            hiddenPacMan.Left = 448;
            hiddenPacMan.Top = 736;
            hiddenPacMan.Width = 1;
            hiddenPacMan.Height = 1;
            foreach (Control x in livesPanel.Controls)
            {
                if( x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }

        public void resetDeath()
        {
            pacmanGame.resetFromDeath();

            pacmanchar.Left = 440;
            pacmanchar.Top = 728;
            hiddenPacMan.Left = 448;
            hiddenPacMan.Top = 736;
        }




        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacmanGame.setisUp(true);
                pacmanchar.Image = Properties.Resources.PacmanUpGif;
                pacmanchar.BringToFront();
                pacmanGame.setNextDirection('U');
            }
            if (e.KeyCode == Keys.Down)
            {
                pacmanGame.setisDown(true);
                pacmanchar.Image = Properties.Resources.PacmanDownGif;
                pacmanchar.BringToFront();
                pacmanGame.setNextDirection('D');
            }
            if (e.KeyCode == Keys.Right)
            {
                pacmanGame.setisRight(true);
                pacmanchar.Image = Properties.Resources.PacmanRightGif;
                pacmanchar.BringToFront();
                pacmanGame.setNextDirection('R');
            }
            if (e.KeyCode == Keys.Left)
            {
                pacmanGame.setisLeft(true);
                pacmanchar.Image = Properties.Resources.PacmanLeftGif;
                pacmanchar.BringToFront();
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
            }
            */

            Thread.Sleep(5);
            scoreLabel.Text = "Score: \n" + pacmanGame.getScore();


            if (pacmanGame.getDirection() == 'U')
            {
                pacmanGame.moveUp();
                for (int i = 0; i < 32; i++)
                {
                    pacmanchar.Top -= pacmanGame.getPlayerSpeed();
                    pacmanchar.BringToFront();
                }
                hiddenPacMan.Top -= pacmanGame.getPlayerSpeed() * 32;
            }
            if (pacmanGame.getDirection() == 'D')
            {
                pacmanGame.moveDown();
                for (int i = 0; i < 32; i++)
                {
                    pacmanchar.Top += pacmanGame.getPlayerSpeed();
                    pacmanchar.BringToFront();

                }
                hiddenPacMan.Top += pacmanGame.getPlayerSpeed() * 32;
            }
            if (pacmanGame.getDirection() == 'R')
            {
                pacmanGame.moveRight();

                for (int i = 0; i < 32; i++)
                {
                    pacmanchar.Left += pacmanGame.getPlayerSpeed();
                    pacmanchar.BringToFront();
                }
                hiddenPacMan.Left += pacmanGame.getPlayerSpeed() * 32;
            }
            if (pacmanGame.getDirection() == 'L')
            {
                pacmanGame.moveLeft();
                for(int i = 0; i < 32; i++)
                {
                    pacmanchar.Left -= pacmanGame.getPlayerSpeed();
                    pacmanchar.BringToFront();
                }
                hiddenPacMan.Left -= pacmanGame.getPlayerSpeed() * 32;
            }
            pacmanGame.setSpeed(0);


            


            //Teleport the PacMan image to each side using the hallway
            if(pacmanchar.Left < 24)
            {
                pacmanchar.Left = 856;
            }
            if(pacmanchar.Left > 856)
            {
                pacmanchar.Left = 24;
            }
            //Teleport the hiddenPacMan image to each side using the hallway
            if(hiddenPacMan.Left == 0)
            {
                hiddenPacMan.Left = 864;
            }
            if (hiddenPacMan.Left == 864)
            {
                hiddenPacMan.Left = 0;
            }
            



            if (pacmanGame.checkGhostCollision() == true)
            {
                pacmanchar.Image = Properties.Resources.PacDeathGif;
                pacmanGame.setSpeed(0);
                pacmanchar.BringToFront();
                Thread.Sleep(2000);
                resetDeath();
                scoreLabel.Text = "Score: \n" + pacmanGame.getScore();
                lifeLabel.Text = "Lives : " + pacmanGame.getLives();
                pacmanchar.Image = Properties.Resources.PacmanRightGif;
            }
            if(pacmanGame.checkGameOver() == true)
            {
                pacmanGame.NewGame();
                resetGame();
                scoreLabel.Text = "Score: \n" + pacmanGame.getScore();
                lifeLabel.Text = "Lives : " + pacmanGame.getLives();
                pacmanchar.Image = Properties.Resources.PacmanRightGif;
            }




            
            foreach(Control x in livesPanel.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Dot" && x.Visible == true)
                {

                    if (hiddenPacMan.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                    }
                }
                if(x is PictureBox && (string)x.Tag == "Pellet" && x.Visible == true)
                {
                    if (hiddenPacMan.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "redGhost")
                {

                }
            }

            //Debug.WriteLine("Dots Left " + pacmanGame.getDotsLeft());


            if (pacmanGame.getDotsLeft() == 0)
            {
                resetGame();
            }

        }

    }
}
