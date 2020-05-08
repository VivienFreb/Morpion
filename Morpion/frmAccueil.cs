using System;
using System.Windows.Forms;
using System.Media;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    public partial class frmAccueil : Form
    {

        bool Joueur = true;
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.win);
        
        public frmAccueil()
        {
            InitializeComponent();   

        }

        private void cmdButton1_Click(object sender, EventArgs e)
        {
            
            if (Joueur == true)
            {
                cmdButton1.Text = "X";
                Joueur = false;
            }
            else 
            { 
                cmdButton1.Text = "O";
                Joueur = true;
            }

            if (((cmdButton1.Text == cmdButton2.Text) & (cmdButton1.Text == cmdButton3.Text)) || 
                ((cmdButton1.Text == cmdButton4.Text) & (cmdButton1.Text == cmdButton7.Text)) ||
                ((cmdButton1.Text == cmdButton5.Text) & (cmdButton1.Text == cmdButton9.Text)))
            {
                cmdWin.Left += 600;
                if(Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
                
            }

            cmdButton1.Enabled = false;
        }

        private void cmdButton2_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton2.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton2.Text = "O";
                Joueur = true;
            }

            if (((cmdButton2.Text == cmdButton1.Text) & (cmdButton2.Text == cmdButton3.Text)) ||
                ((cmdButton2.Text == cmdButton5.Text) & (cmdButton2.Text == cmdButton8.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton2.Enabled = false;
        }

        private void cmdButton3_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton3.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton3.Text = "O";
                Joueur = true;
            }

            if (((cmdButton3.Text == cmdButton1.Text) & (cmdButton3.Text == cmdButton2.Text)) ||
                ((cmdButton3.Text == cmdButton5.Text) & (cmdButton3.Text == cmdButton7.Text)) ||
                ((cmdButton3.Text == cmdButton6.Text) & (cmdButton3.Text == cmdButton9.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton3.Enabled = false;
        }

        private void cmdButton4_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton4.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton4.Text = "O";
                Joueur = true;
            }

            if (((cmdButton4.Text == cmdButton5.Text) & (cmdButton4.Text == cmdButton6.Text)) ||
                ((cmdButton4.Text == cmdButton1.Text) & (cmdButton4.Text == cmdButton7.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }
            cmdButton4.Enabled = false;
        }

        private void cmdButton5_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton5.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton5.Text = "O";
                Joueur = true;
            }

            if (((cmdButton5.Text == cmdButton1.Text) & (cmdButton5.Text == cmdButton9.Text)) ||
                ((cmdButton5.Text == cmdButton2.Text) & (cmdButton5.Text == cmdButton8.Text)) ||
                ((cmdButton5.Text == cmdButton3.Text) & (cmdButton5.Text == cmdButton7.Text)) ||
                ((cmdButton5.Text == cmdButton4.Text) & (cmdButton5.Text == cmdButton6.Text)) 
                )
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton5.Enabled = false;
        }

        private void cmdButton6_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton6.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton6.Text = "O";
                Joueur = true;
            }

            if (((cmdButton6.Text == cmdButton3.Text) & (cmdButton6.Text == cmdButton9.Text)) ||
                ((cmdButton6.Text == cmdButton5.Text) & (cmdButton6.Text == cmdButton4.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton6.Enabled = false;
        }

        private void cmdButton7_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton7.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton7.Text = "O";
                Joueur = true;
            }

            if (((cmdButton7.Text == cmdButton4.Text) & (cmdButton7.Text == cmdButton1.Text)) ||
                ((cmdButton7.Text == cmdButton8.Text) & (cmdButton7.Text == cmdButton9.Text)) ||
                ((cmdButton7.Text == cmdButton5.Text) & (cmdButton7.Text == cmdButton3.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton7.Enabled = false;
        }

        private void cmdButton8_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton8.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton8.Text = "O";
                Joueur = true;
            }

            if (((cmdButton8.Text == cmdButton7.Text) & (cmdButton8.Text == cmdButton9.Text)) ||
                ((cmdButton8.Text == cmdButton5.Text) & (cmdButton8.Text == cmdButton2.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    affPlayer2.Left += 1000;
                    winSound.Play();
                }
            }

            cmdButton8.Enabled = false;
        }

        private void cmdButton9_Click(object sender, EventArgs e)
        {
            if (Joueur == true)
            {
                cmdButton9.Text = "X";
                Joueur = false;
            }
            else
            {
                cmdButton9.Text = "O";
                Joueur = true;
            }

            if (((cmdButton9.Text == cmdButton8.Text) & (cmdButton9.Text == cmdButton7.Text)) ||
                ((cmdButton9.Text == cmdButton5.Text) & (cmdButton9.Text == cmdButton1.Text)) ||
                ((cmdButton9.Text == cmdButton6.Text) & (cmdButton9.Text == cmdButton3.Text)))
            {
                cmdWin.Left += 600;
                if (Joueur != true)
                {
                    winSound.Play();
                    affPlayer1.Left += 1000;
                }
                else
                {
                    winSound.Play();
                    affPlayer2.Left += 1000;
                }
            }

            cmdButton9.Enabled = false;
        }

        private void cmdNewgame_Click(object sender, EventArgs e)
        {
            Joueur = true;
            cmdWin.Left = -588;
            cmdWin.Top = 100;
            affPlayer1.Left = -1009;
            affPlayer1.Top = 364;
            affPlayer2.Left = -1131;
            affPlayer2.Top = 358;
            cmdButton1.Text = "";
            cmdButton1.Enabled = true;
            cmdButton2.Text = "";
            cmdButton2.Enabled = true;
            cmdButton3.Text = "";
            cmdButton3.Enabled = true;
            cmdButton4.Text = "";
            cmdButton4.Enabled = true;
            cmdButton5.Text = "";
            cmdButton5.Enabled = true;
            cmdButton6.Text = "";
            cmdButton6.Enabled = true;
            cmdButton7.Text = "";
            cmdButton7.Enabled = true;
            cmdButton8.Text = "";
            cmdButton8.Enabled = true;
            cmdButton9.Text = "";
            cmdButton9.Enabled = true;
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdWin_Click(object sender, EventArgs e)
        {

        }

        private void affPlayer1_Click(object sender, EventArgs e)
        {

        }


    }
}
