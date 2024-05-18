using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        private int Phase;
        private int Pause;
        private int NbFantomesManges;
        public Fantome Fantome1, Fantome2, Fantome3, Fantome4;
        public Pacman Pacman;
        public bool FantomesAgressifs = false;
       
        private void DessinerPointsSurGrille()
        {
            int No = 0;
            Image Image1 = Properties.Resources.Grille;
            Graphics Graphique1 = Graphics.FromImage(Image1);
            Pen Pen1 = new Pen(Color.White, 1);
            for (int j = 0; j < Grille.MaxLignes; j++)
            {
                for (int i = 0; i < Grille.MaxColonnes; i++)
                {
                    if (Grille.Cases[i, j].Equals('.'))
                    {
                        int x = Grille.CentreCaseX(i) - PbGrille.Left - 1; // Largeur 2
                        int y = Grille.CentreCaseY(j) - PbGrille.Top - 1; // Hauteur 2
                        Graphique1.DrawRectangle(Pen1, x, y, 1, 1);
                    };
                    if (Grille.Cases[i, j].Equals('*'))
                    {
                        No++;
                        if (No == 1)
                        {
                            PbForce1.Left = Grille.CentreCaseX(i) - PbForce1.Width / 2;
                            PbForce1.Top = Grille.CentreCaseY(j) - PbForce1.Height / 2;
                            PbForce1.Show();
                            PbForce1.BringToFront();
                        }
                        if (No == 2)
                        {
                            PbForce2.Left = Grille.CentreCaseX(i) - PbForce2.Width / 2;
                            PbForce2.Top = Grille.CentreCaseY(j) - PbForce2.Height / 2;
                            PbForce2.Show();
                            PbForce2.BringToFront();
                        }
                        if (No == 3)
                        {
                            PbForce3.Left = Grille.CentreCaseX(i) - PbForce3.Width / 2;
                            PbForce3.Top = Grille.CentreCaseY(j) - PbForce3.Height / 2;
                            PbForce3.Show();
                            PbForce3.BringToFront();
                        }
                        if (No == 4)
                        {
                            PbForce4.Left = Grille.CentreCaseX(i) - PbForce4.Width / 2;
                            PbForce4.Top = Grille.CentreCaseY(j) - PbForce4.Height / 2;
                            PbForce4.Show();
                            PbForce4.BringToFront();
                        }
                    }
                }
            }
            Graphique1.Save();
            PbGrille.Image = Image1;
        }

        public Form1()
        {
            InitializeComponent():
            Grille.Fenetre = this; // Conserver la référence à cet objet
            PbGrille.Left = Grille.GrilleLeft;
            PbGrille.Top = Grille.GrilleTop;
            // Blinky
            Fantome1 = new Fantome(1);
            Controls.Add(Fantome1);
            LNomFantome1.Text = Fantome1.Nom;
            // Inky
            Fantome2 = new Fantome(2);
            Controls.Add(Fantome2);
            LNomFantome2.Text = Fantome2.Nom;
            // Pinky
            Fantome3 = new Fantome(3);
            Controls.Add(Fantome3);
            LNomFantome3.Text = Fantome3.Nom;
            // Clyde
            Fantome4 = new Fantome(4);
            Controls.Add(Fantome4);
            LNomFantome4.Text = Fantome4.Nom;
            Pacman = new Pacman();
            Controls.Add(Pacman);
            Phase = 0;
            Pause = 0;
        }


        private void PbJouer_MouseHover(object sender, EventArgs e)
        {
            PbJouer.Image = Properties.Resources.JouerOver;
        }

        private void PbJouer_MouseLeave(object sender, EventArgs e)
        {
            PbJouer.Image = Properties.Resources.Jouer;
        }

        private void PbQuitter_MouseHover(object sender, EventArgs e)
        {
            PbQuitter.Image = Properties.Resources.QuitterOver;
        }

        private void TTimer_Tick(object sender, EventArgs e)
        {
            if (Pause > 0) // En pause ?
            {
                Pause--;
                return;
            }
            switch (Phase)
            {
                case 0: // Préparer intro
                    NbFantomesManges = 0;
                    LNomFantome1.Hide();
                    LNomFantome2.Hide();
                    LNomFantome3.Hide();
                    LNomFantome4.Hide();
                    Pacman.Init();
                    Pacman.MilieuX = -10;
                    Pacman.MilieuY = 50;
                    Pacman.Vitesse = 4;
                    Pacman.Show();
                    PbForce1.Left = 400;
                    PbForce1.Top = 50 - PbForce1.Height / 2;
                    PbForce1.Show();
                    PbForce2.Hide();
                    PbForce3.Hide();
                    PbForce4.Hide();
                    Fantome1.Init();
                    Fantome1.MilieuX = Pacman.MilieuX - 25;
                    Fantome1.MilieuY = Pacman.MilieuY;
                    Fantome1.Vitesse = 4;
                    Fantome1.Show();
                    Fantome2.Init();
                    Fantome2.MilieuX = Fantome1.MilieuX - 25;
                    Fantome2.MilieuY = Fantome1.MilieuY;
                    Fantome2.Vitesse = 4;
                    Fantome2.Show();
                    Fantome3.Init();
                    Fantome3.MilieuX = Fantome2.MilieuX - 25;
                    Fantome3.MilieuY = Fantome1.MilieuY;
                    Fantome3.Vitesse = 4;
                    Fantome3.Show();
                    Fantome4.Init();
                    Fantome4.MilieuX = Fantome3.MilieuX - 25;
                    Fantome4.MilieuY = Fantome1.MilieuY;
                    Fantome4.Vitesse = 4;
                    Fantome4.Show();
                    L200Pts.Hide();
                    L400Pts.Hide();
                    L800Pts.Hide();
                    L1600Pts.Hide();
                    PbJouer.Show();
                    PbQuitter.Show();
                    PbGrille.Hide();
                    Son.Jouer(Properties.Resources.Sirene, true);
                    Phase = 1;
                    break;
                case 1: // Poursuite de Pacman par les fantômes
                    AvancerLibrement();
                    if (Pacman.MilieuX >= PbForce1.Left + PbForce1.Width / 2)
                    {
                        Phase = 2;
                        PbForce1.Hide();
                        Fantome1.Etat = 1;
                        Fantome1.Direction = 2;
                        Fantome2.Etat = 1;
                        Fantome2.Direction = 2;
                        Fantome3.Etat = 1;
                        Fantome3.Direction = 2;
                        Fantome4.Etat = 1;
                        Fantome4.Direction = 2;
                        Pacman.Direction = 2;
                        Son.Jouer(Properties.Resources.MangePoint, true);

                    };
                    break;
                case 2: // Poursuite des fantômes par Pacman
                    AvancerLibrement();
                    if (DetecterCollisionFantome(Fantome1))
                    {
                        Fantome1.Hide();
                        AfficherPtsAcquis();
                        Pause = 20;
                        break;
                    };
                    if (DetecterCollisionFantome(Fantome2))
                    {
                        Fantome2.Hide();
                        AfficherPtsAcquis();
                        Pause = 20;
                        break;
                    };
                    if (DetecterCollisionFantome(Fantome3))
                    {
                        Fantome3.Hide();
                        AfficherPtsAcquis();
                        Pause = 20;
                        break;
                    };
                    if (DetecterCollisionFantome(Fantome4))
                    {
                        Fantome4.Hide();
                        AfficherPtsAcquis();
                        Pause = 20;
                        break;
                    };
                    if (Pacman.MilieuX + Pacman.Width / 2 < 0)
                    {
                        LNomFantome1.Left = PbForce1.Left;
                        LNomFantome1.Top = PbForce1.Top + 80;
                        LNomFantome1.Show();
                        Fantome1.Init();
                        Fantome1.Left = -20;
                        Fantome1.Top = LNomFantome1.Top;
                        Fantome1.Vitesse = 8;
                        LNomFantome2.Left = LNomFantome1.Left;
                        LNomFantome2.Top = LNomFantome1.Top + 40;
                        LNomFantome2.Show();
                        Fantome2.Init();
                        Fantome2.Left = -20;
                        Fantome2.Top = LNomFantome2.Top;
                        Fantome2.Vitesse = 8;
                        LNomFantome3.Left = LNomFantome2.Left;
                        LNomFantome3.Top = LNomFantome2.Top + 40;
                        LNomFantome3.Show();
                        Fantome3.Init();
                        Fantome3.Left = -20;
                        Fantome3.Top = LNomFantome3.Top;
                        Fantome3.Vitesse = 8;
                        LNomFantome4.Left = LNomFantome3.Left;
                        LNomFantome4.Top = LNomFantome3.Top + 40;
                        LNomFantome4.Show();
                        Fantome4.Init();
                        Fantome4.Left = -20;
                        Fantome4.Top = LNomFantome4.Top;
                        Fantome4.Vitesse = 8;
                        Phase = 3;
                    }
                    break;
                case 3: // Présentation de Blinky
                    Fantome1.Show();
                    AvancerLibrement();
                    if (Fantome1.Left > LNomFantome1.Left - 50)
                    {
                        Fantome1.Vitesse = 0;
                        Phase = 4;
                        Pause = 20;
                    };
                    break;
                case 4: // Présentation de Inky
                    Fantome2.Show();
                    AvancerLibrement();
                    if (Fantome2.Left > LNomFantome2.Left - 50)
                    {
                        Fantome2.Vitesse = 0;
                        Phase = 5;
                        Pause = 20;
                    };
                    break;
                case 5: // Présentation de Pinky
                    Fantome3.Show();
                    AvancerLibrement();
                    if (Fantome3.Left > LNomFantome3.Left - 50)
                    {
                        Fantome3.Vitesse = 0;
                        Phase = 6;
                        Pause = 20;
                    };
                    break;
                case 6: // Présentation de Clyde
                    Fantome4.Show();
                    AvancerLibrement();
                    if (Fantome4.Left > LNomFantome4.Left - 50)
                    {
                        Fantome4.Vitesse = 0;
                        Phase = 0;
                        Pause = 20;
                    };
                    break;
                case 7: // Préparer le jeu
                    Grille.Init(); // Mise en place tableau de jeu
                    NbFantomesManges = 0;
                    LNomFantome1.Hide();
                    LNomFantome2.Hide();
                    LNomFantome3.Hide();
                    LNomFantome4.Hide();
                    Score = 0;
                    PbForce1.Hide();
                    L200Pts.Hide();
                    L400Pts.Hide();
                    L800Pts.Hide();
                    L1600Pts.Hide();
                    PbJouer.Hide();
                    PbQuitter.Hide();
                    PbGrille.Image = Properties.Resources.Grille;
                    PbGrille.Show();
                    PbGrille.SendToBack();
                    DessinerPointsSurGrille();
                    Fantome1.Init();
                    Fantome1.MilieuX = Grille.CentreCaseX(18);
                    Fantome1.MilieuY = Grille.CentreCaseY(14);
                    Fantome1.Show();
                    Fantome1.BringToFront();
                    Fantome2.Init();
                    Fantome2.MilieuX = Fantome1.MilieuX;
                    Fantome2.MilieuY = Grille.CentreCaseY(18);
                    Fantome2.Direction = 3;
                    Fantome2.Show();
                    Fantome2.BringToFront();
                    Fantome3.Init();
                    Fantome3.MilieuX = Grille.CentreCaseX(16);
                    Fantome3.MilieuY = Fantome2.MilieuY;
                    Fantome3.Direction = 3;
                    Fantome3.Show();
                    Fantome3.BringToFront();
                    Fantome4.Init();
                    Fantome4.MilieuX = Grille.CentreCaseX(20);
                    Fantome4.MilieuY = Fantome2.MilieuY;
                    Fantome4.Direction = 3;
                    Fantome4.Show();
                    Fantome4.BringToFront();
                    Pacman.Init();
                    Pacman.MilieuX = Grille.CentreCaseX(18);
                    Pacman.MilieuY = Grille.CentreCaseY(22);
                    Pacman.Show();
                    Son.Jouer(Properties.Resources.Intro);
                    Pause = 140; // Durée de l'intro
                    Phase = 8;
                    break;
                case 8: // Jouer
                    if (PartieTerminee() | Pacman.Mort) // Fin partie ?
                    {
                        Phase = 0;
                        Pause = 20;
                        return;
                    }
                    // Remise à zéro du nombre de fantômes mangés dès qu'aucun n'est comestible
                    if (AucunFantomeAManger()) NbFantomesManges = 0;
                    if (!Pacman.Mort) Pacman.Avancer(); // Gérer le déplacement du Pacman
                    DetecterEtGererCollisions();
                    Fantome1.Avancer(); // Gérer le déplacement des fantômes
                    Fantome2.Avancer();
                    Fantome3.Avancer();
                    Fantome4.Avancer();
                    if (!Pacman.Mort) DetecterEtGererCollisions();
                    // Gérer la durée où les fantômes sont comestibles (états 2 et 3)
                    Fantome1.ReduireDureeComestible();
                    Fantome2.ReduireDureeComestible();
                    Fantome3.ReduireDureeComestible();
                    Fantome4.ReduireDureeComestible();
                    break;
            };
        }

        private void PbQuitter_MouseLeave(object sender, EventArgs e)
        {
            PbQuitter.Image = Properties.Resources.Quitter;
        }

        private void PbQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbJouer_Click(object sender, EventArgs e)
        {
            Phase = 7; // TTimer provoquera le début de partie
        }

        private void AvancerLibrement()
        {
            if (Fantome1.Visible) Fantome1.AvancerLibrement();
            if (Fantome2.Visible) Fantome2.AvancerLibrement();
            if (Fantome3.Visible) Fantome3.AvancerLibrement();
            if (Fantome4.Visible) Fantome4.AvancerLibrement();
            if (Pacman.Visible) Pacman.AvancerLibrement();
        }
        private bool DetecterCollisionFantome(Sprite Fantome)
        {
            // Fantome invisible ou Pacman mort, Pas de collision
            if (!Fantome.Visible | Pacman.Mort) return false;
            int xM, yM, xJ, yJ;
            xM = Fantome.MilieuX;
            yM = Fantome.MilieuY;
            xJ = Pacman.MilieuX;
            yJ = Pacman.MilieuY;
            if (Math.Abs(xM - xJ) <= 3 & Math.Abs(yM - yJ) <= 3) // 3 pixels d'écart
                return true;
            else return false;
        }
        private void T200Pts_Tick(object sender, EventArgs e)
        {
            T200Pts.Enabled = false;
            L200Pts.Hide();
        }
        private void T400Pts_Tick(object sender, EventArgs e)
        {
            T400Pts.Enabled = false;
            L400Pts.Hide();
        }
        private void T800Pts_Tick(object sender, EventArgs e)
        {
            T800Pts.Enabled = false;
            L800Pts.Hide();
        }
        private void T1600Pts_Tick(object sender, EventArgs e)
        {
            T1600Pts.Enabled = false;
            L1600Pts.Hide();
        }
        private int AfficherPtsAcquis()
        {
            int Res = 0;
            System.Windows.Forms.Label Points = null;
            NbFantomesManges++;
            if (NbFantomesManges == 1)
            {
                Res = 200;
                Points = L200Pts;
                T200Pts.Enabled = true;
            }
            if (NbFantomesManges == 2)
            {
                Res = 400;
                Points = L400Pts;
                T400Pts.Enabled = true;
            }
            if (NbFantomesManges == 3)
            {
                Res = 800;
                Points = L800Pts;
                T800Pts.Enabled = true;
            }
            if (NbFantomesManges == 4)
            {
                Res = 1600;
                Points = L1600Pts;
                T1600Pts.Enabled = true;
            }
            if (Points != null)
            {
                Points.Left = Pacman.Left;
                Points.Top = Pacman.Top + 25;
                Points.Show();
            }
            return Res;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Echap : Revenir du mode jeu au mode démo
            if (e.KeyCode == Keys.Escape & Phase == 8) Phase = 0;
            // Enregistrer le changement de direction de Pacman
            if (e.KeyCode == Keys.Left) Pacman.DirectionSuivante = 2;
            if (e.KeyCode == Keys.Right) Pacman.DirectionSuivante = 0;
            if (e.KeyCode == Keys.Up) Pacman.DirectionSuivante = 3;
            if (e.KeyCode == Keys.Down) Pacman.DirectionSuivante = 1;
        }

        public void EffacerPointSurGrille(int i, int j)
        {
            Image Image1 = PbGrille.Image;
            Graphics Graphique1 = Graphics.FromImage(Image1);
            Pen Pen1 = new Pen(Color.Black, 1);
            int x = Grille.CentreCaseX(i) - PbGrille.Left - 1; // Largeur 2
            int y = Grille.CentreCaseY(j) - PbGrille.Top - 1; // Hauteur 2
            Graphique1.DrawRectangle(Pen1, x, y, 1, 1);
            Graphique1.Save();
            PbGrille.Image = Image1;
        }
        private bool PartieTerminee()
        {
            for (int j = 0; j < Grille.MaxLignes; j++)
            {
                for (int i = 0; i < Grille.MaxColonnes; i++)
                {
                    if (Grille.Cases[i, j].Equals('.') | Grille.Cases[i, j].Equals('*')) return false;
                };
            };
            return true;
        }

        private void TAttaque_Tick(object sender, EventArgs e)
        {
            FantomesAgressifs = !FantomesAgressifs;
            if (FantomesAgressifs) TAttaque.Interval = 9000; // Agressifs pdt 9s
            else TAttaque.Interval = 5000; // En pause pdt 5s
        }


        private bool AucunFantomeAManger()
        {
            // Si aucun fantôme à l'état 1-Comestible ou 2-Fin comestible, renvoyer vrai
            return (Fantome1.Etat != 1 & Fantome1.Etat != 2 & Fantome2.Etat != 1 & Fantome2.Etat != 2
            & Fantome3.Etat != 1 & Fantome3.Etat != 2 & Fantome4.Etat != 1 & Fantome4.Etat != 2);
        }
        // Traiter la rencontre avec les 4 fantômes
        private void DetecterEtGererCollisions()
        {
            DetecterEtGererCollisionFantome(Fantome1);
            if (Pause != 0) return;
            DetecterEtGererCollisionFantome(Fantome2);
            if (Pause != 0) return;
            DetecterEtGererCollisionFantome(Fantome3);
            if (Pause != 0) return;
            DetecterEtGererCollisionFantome(Fantome4);
        }
        private void DetecterEtGererCollisionFantome(Fantome UnFantome)
        {
            if (DetecterCollisionFantome(UnFantome))
            {
                if (UnFantome.Etat == 0) // En chasse
                {
                    Pacman.Mort = true;
                    Pacman.Vitesse = 0;
                    Pacman.BringToFront();
                    Pause = 50;
                    Son.Jouer(Properties.Resources.Mort);

                }
                if (UnFantome.Etat >= 1 & UnFantome.Etat <= 2) // Comestible
                {
                    UnFantome.Etat = 3; // Retour yeux
                    Score += AfficherPtsAcquis();
                    Pause = 20;
                    Son.Jouer(Properties.Resources.MangeFantome);

                }
            }
        }

    }
}
