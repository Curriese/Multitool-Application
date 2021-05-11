using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiToolApplication
{
    public partial class HangmanFormcs : Form
    {
        //Background HangmanGame
        private HangMan hangmanGame;
        //Locations of guessed letter in word
        ArrayList Locations = new ArrayList();
        //The String thats displayed to the user
        String DisplayString = "";


        /// <summary>
        /// General Constructor
        /// </summary>
        public HangmanFormcs()
        {
            InitializeComponent();
            hangmanGame = new HangMan();
            Graphics g = hangmanDisplayBox.CreateGraphics();
            victoryLabel.Text = "";
        }

        /// <summary>
        /// Resets the UI for the HangmanGame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            #region EnableButtons
            a_button.Enabled = true;
            b_button.Enabled = true;
            c_button.Enabled = true;
            d_button.Enabled = true;
            e_button.Enabled = true;
            f_button.Enabled = true;
            g_button.Enabled = true;
            h_button.Enabled = true;
            i_button.Enabled = true;
            j_button.Enabled = true;
            k_button.Enabled = true;
            l_button.Enabled = true;
            m_button.Enabled = true;
            n_button.Enabled = true;
            o_button.Enabled = true;
            p_button.Enabled = true;
            q_button.Enabled = true;
            r_button.Enabled = true;
            s_button.Enabled = true;
            t_button.Enabled = true;
            u_button.Enabled = true;
            v_button.Enabled = true;
            w_button.Enabled = true;
            x_button.Enabled = true;
            y_button.Enabled = true;
            z_button.Enabled = true;
            #endregion

            hangmanGame.Reset();
            DisplayString = "";
            DisplayNoose();
            victoryLabel.Text = "";
        }

        /// <summary>
        /// Helper Method to display the Noose Structure and Word Display
        /// </summary>
        private void DisplayNoose()
        {
            Graphics g = hangmanDisplayBox.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.Clear(Color.Gray);
            //Bottom bar
            g.FillRectangle(myBrush, new Rectangle(50, 550, 300, 20));
            //Right bar
            g.FillRectangle(myBrush, new Rectangle(330, 50, 20, 500));
            //Top bar
            g.FillRectangle(myBrush, new Rectangle(175, 50, 175, 20));
            //Rope
            g.FillRectangle(myBrush, new Rectangle(180, 70, 5, 50));

            String BlankSpace = "_  ";
            for (int i = 0; i < hangmanGame.GetWordCount(); i++){
                DisplayString += BlankSpace;
            }
            wordDisplayBox.Text = DisplayString;

        }

        /// <summary>
        /// Updates the UI for the hanging man depending on wrong guess amount
        /// </summary>
        private void UpdateHangmanDisplay()
        {
            Graphics g = hangmanDisplayBox.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            //Get wrong guess amount
            int wrongGuesses = hangmanGame.GetWrongGuesses();
            
            switch (wrongGuesses)
            {
                case 1:
                    //fill Head 
                    g.FillEllipse(myBrush, new Rectangle(133, 115, 100, 100));
                    break;
                case 2:
                    //fill torso 
                    g.FillRectangle(myBrush, new Rectangle(173, 215, 20, 200));
                    break;
                case 3:
                    //fill left arm
                    g.FillRectangle(myBrush, new Rectangle(93, 255, 85, 10));
                    break;
                case 4:
                    //fill right arm
                    g.FillRectangle(myBrush, new Rectangle(188, 255, 85, 10));
                    break;
                case 5:
                    //fill left leg
                    g.FillRectangle(myBrush, new Rectangle(153, 395, 20, 105));
                    break;
                case 6:
                    //fill right leg
                    g.FillRectangle(myBrush, new Rectangle(193, 395, 20, 105));
                    break;
                default:
                    break;
            }
            
        }

        /// <summary>
        /// Updates the Word Display with the new letters after a guess
        /// </summary>
        /// <param name="Locations"></param>
        /// <param name="Letter"></param>
        private void UpdateWordDisplay(ArrayList Locations, char Letter)
        {
            StringBuilder sb = new StringBuilder(DisplayString);
            
            for(int i = 0; i < Locations.Count; i++)
            {
                sb.Remove(((int)Locations[i] * 3), 1);
                sb.Insert((int)Locations[i] * 3, Letter);
            }
            DisplayString = sb.ToString();
        }

        /// <summary>
        /// Determines the current state of the game for victory or loss
        /// </summary>
        private void EndGame()
        {
            int gameResult = hangmanGame.CheckVictory();
            if(gameResult == 0)
            {
                
                #region DisableButtons
                a_button.Enabled = false;
                b_button.Enabled = false;
                c_button.Enabled = false;
                d_button.Enabled = false;
                e_button.Enabled = false;
                f_button.Enabled = false;
                g_button.Enabled = false;
                h_button.Enabled = false;
                i_button.Enabled = false;
                j_button.Enabled = false;
                k_button.Enabled = false;
                l_button.Enabled = false;
                m_button.Enabled = false;
                n_button.Enabled = false;
                o_button.Enabled = false;
                p_button.Enabled = false;
                q_button.Enabled = false;
                r_button.Enabled = false;
                s_button.Enabled = false;
                t_button.Enabled = false;
                u_button.Enabled = false;
                v_button.Enabled = false;
                w_button.Enabled = false;
                x_button.Enabled = false;
                y_button.Enabled = false;
                z_button.Enabled = false;
                #endregion
                victoryLabel.Text = "You Lose! The word was " + hangmanGame.GetWord() + ".";
            }
            else if(!DisplayString.Contains("_"))
            {
                #region DisableButtons
                a_button.Enabled = false;
                b_button.Enabled = false;
                c_button.Enabled = false;
                d_button.Enabled = false;
                e_button.Enabled = false;
                f_button.Enabled = false;
                g_button.Enabled = false;
                h_button.Enabled = false;
                i_button.Enabled = false;
                j_button.Enabled = false;
                k_button.Enabled = false;
                l_button.Enabled = false;
                m_button.Enabled = false;
                n_button.Enabled = false;
                o_button.Enabled = false;
                p_button.Enabled = false;
                q_button.Enabled = false;
                r_button.Enabled = false;
                s_button.Enabled = false;
                t_button.Enabled = false;
                u_button.Enabled = false;
                v_button.Enabled = false;
                w_button.Enabled = false;
                x_button.Enabled = false;
                y_button.Enabled = false;
                z_button.Enabled = false;
                #endregion
                victoryLabel.Text = "You Win!";
            }
            else
            {
                victoryLabel.Text = "";
            }
        }

        #region ButtonClicks
        private void a_button_Click(object sender, EventArgs e)
        {
            a_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('a');
            if(Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'a');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void b_button_Click(object sender, EventArgs e)
        {
            b_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('b');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'b');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            c_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('c');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'c');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void d_button_Click(object sender, EventArgs e)
        {
            d_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('d');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'd');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void e_button_Click(object sender, EventArgs e)
        {
            e_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('e');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'e');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void f_button_Click(object sender, EventArgs e)
        {
            f_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('f');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'f');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void g_button_Click(object sender, EventArgs e)
        {
            g_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('g');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'g');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void h_button_Click(object sender, EventArgs e)
        {
            h_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('h');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'h');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void i_button_Click(object sender, EventArgs e)
        {
            i_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('i');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'i');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void j_button_Click(object sender, EventArgs e)
        {
            j_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('j');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'j');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void k_button_Click(object sender, EventArgs e)
        {
            k_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('k');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'k');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void l_button_Click(object sender, EventArgs e)
        {
            l_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('l');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'l');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void m_button_Click(object sender, EventArgs e)
        {
            m_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('m');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'm');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void n_button_Click(object sender, EventArgs e)
        {
            n_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('n');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'n');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void o_button_Click(object sender, EventArgs e)
        {
            o_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('o');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'o');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void p_button_Click(object sender, EventArgs e)
        {
            p_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('p');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'p');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void q_button_Click(object sender, EventArgs e)
        {
            q_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('q');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'q');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void r_button_Click(object sender, EventArgs e)
        {
            r_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('r');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'r');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void s_button_Click(object sender, EventArgs e)
        {
            s_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('s');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 's');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void t_button_Click(object sender, EventArgs e)
        {
            t_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('t');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 't');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void u_button_Click(object sender, EventArgs e)
        {
            u_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('u');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'u');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void v_button_Click(object sender, EventArgs e)
        {
            v_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('v');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'v');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void w_button_Click(object sender, EventArgs e)
        {
            w_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('w');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'w');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            x_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('x');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'x');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void y_button_Click(object sender, EventArgs e)
        {
            y_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('y');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'y');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }

        private void z_button_Click(object sender, EventArgs e)
        {
            z_button.Enabled = false;
            Locations = hangmanGame.CheckLetterInWord('z');
            if (Locations.Count != 0)
            {
                UpdateWordDisplay(Locations, 'z');
                wordDisplayBox.Text = DisplayString;
            }

            Locations.Clear();
            UpdateHangmanDisplay();
            EndGame();
        }
        #endregion
    }
}
