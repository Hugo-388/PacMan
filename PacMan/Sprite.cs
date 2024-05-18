using System;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan
{
    public class Sprite : System.Windows.Forms.PictureBox
    {
        private int mDirection; //0=Droite, 1=Bas, 2=Gauche, 3=Haut
        public int Direction
        {
            get { return mDirection; }
            set
            {
                if (mDirection != value) // Chgt direction => Dessin différent
                {
                    mDirection = value;
                    MajImage();
                }
            }
        }
        private int mVitesse; // Nb points à chaque déplacement;
        public int Vitesse
        {
            get { return mVitesse; }
            set
            {
                if (mVitesse != value) // Arrêt/Départ de Pacman => Dessin différent
                {
                    mVitesse = value;
                    MajImage();
                }
            }
        }
        public int MilieuX // Propriété MilieuX liée à Left
        {
            get { return Left + Width / 2; }
            set { Left = value - Width / 2; }
        }
        public int MilieuY // Propriété MilieuY liée à Top
        {
            get { return Top + Height / 2; }
            set { Top = value - Height / 2; }
        }
        public Sprite() : base()
        {
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.AutoSize;
            Init();
        }
        public virtual void Init()
        {
            Left = 0;
            Top = 0;
            Direction = 0;
            Vitesse = 0;
        }
        public void AvancerLibrement()
        {
            if (Direction == 0) MilieuX += Vitesse;
            if (Direction == 1) MilieuY += Vitesse;
            if (Direction == 2) MilieuX -= Vitesse;
            if (Direction == 3) MilieuY -= Vitesse;
        }
        public virtual void MajImage() { } // Défini dans Fantome et Pacman

        public bool SurGrille()
        {
            if ((MilieuX - Grille.GrilleLeft - Grille.PremiereCaseLeft) % 12 == 0
            & (MilieuY - Grille.GrilleTop - Grille.PremiereCaseTop) % 12 == 0) return true;
            else return false;
        }
        public void Avancer()
        {
            if (SurGrille() & Vitesse == 0) GererSurGrille(); // Permettre de tourner à l'arrêt
            for (int i = 1; i < Vitesse; i++)
            {
                if (Direction == 0) MilieuX++;
                if (Direction == 1) MilieuY++;
                if (Direction == 2) MilieuX--;
                if (Direction == 3) MilieuY--;
                if (SurGrille())
                {
                    // Traverser le tunnel ?
                    if (Direction == 2 & NatureCase(CaseActuelleX(), CaseActuelleY()) == 3) MilieuX =
                    Grille.CentreCaseX(36);
                    if (Direction == 0 & NatureCase(CaseActuelleX(), CaseActuelleY()) == 3) MilieuX =
                   Grille.CentreCaseX(0);
                    GererSurGrille();
                }
            }
        }


        public virtual void GererSurGrille() { } // Défini dans Fantome et Pacman
        public int CaseActuelleX()
        {
            return (int)Math.Round((double)((MilieuX - Grille.GrilleLeft - Grille.PremiereCaseLeft) / 12));
        }
        public int CaseActuelleY()
        {
            return (int)Math.Round((double)((MilieuY - Grille.GrilleTop - Grille.PremiereCaseTop) / 12));
        }
        // Type de case de la grille : 0=Libre, 1=Point, 2=Pouvoir, 3=Tunnel, 4=Porte, 5=Interdit
        public int NatureCase(int x, int y)
        {
            if (x == -1 & y == 18) return 3; // Tunnel gauche
            if (x == 37 & y == 18) return 3; // Tunnel droit
            if (x <= -1 | x >= 37 | y <= -1 | y >= 40) return 5;
            if (Grille.Cases[x, y].Equals(' ')) return 0;
            if (Grille.Cases[x, y].Equals('.')) return 1;
            if (Grille.Cases[x, y].Equals('*')) return 2;
            if (Grille.Cases[x, y].Equals('=')) return 4;
            return 5;
        }
        public int CaseSuivanteX()
        {
            int Res = CaseActuelleX();
            if (Vitesse > 0)
            {
                if (Direction == 0) Res++;
                if (Direction == 2) Res--;
            };
            return Res;
        }
        public int CaseSuivanteY()
        {
            int Res = CaseActuelleY();
            if (Vitesse > 0)
            {
                if (Direction == 1) Res++;
                if (Direction == 3) Res--;
            };
            return Res;
        }
    }
}
