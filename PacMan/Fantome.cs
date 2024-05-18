using System;
using System.Drawing;

namespace PacMan
{
    public class Fantome : Sprite
    {
        private Random Aleatoire = new Random();
        public int No; // 1=Blinky, 2=Inky, 3=Pinky, 4=Clyde
        public string Nom;
        private int mEtat;
        public int Etat
        { // 0=en chasse,
          // 1=comestible,
          // 2=fin comestible (clignotant),
          // 3=retour yeux,
            get { return mEtat; }
            set
            {
                mEtat = value;
                if (mEtat == 0 | mEtat == 3) DureeComestible = 0; // En chasse, retour yeux
                if (mEtat == 1) DureeComestible = 800; // 800 "Ticks" pour comestible
                if (mEtat == 2) DureeComestible = 200; // 200 "Ticks" pour finComestible
                MajImage();
                MajVitesse();
            }
        }
        public int DureeComestible; // Compte à rebours pour états 1 et 2
        public Fantome(int i) : base()
        {
            No = i;
            if (i == 1) Nom = "Blinky";
            if (i == 2) Nom = "Inky";
            if (i == 3) Nom = "Pinky";
            if (i == 4) Nom = "Clyde";
            Init();
        }
        public override void Init()
        {
            base.Init(); // Init de Sprite
            Etat = 0;
        }
        private void MajVitesse()
        {
            switch (Etat)
            {
                case 0:
                    Vitesse = 4; // En chasse
                    break;
                case 1:
                case 2:
                    Vitesse = 3; // Comestible, fin comestible
                    break;
                case 3:
                    Vitesse = 6; // Retour yeux
                    break;
            }
        }
        public override void MajImage()
        {
            switch (Etat)
            {
                case 0: // En chasse
                    if (No == 1)
                    {
                        if (Direction == 0) Image = Properties.Resources.Fantome1D;
                        if (Direction == 1) Image = Properties.Resources.Fantome1B;
                        if (Direction == 2) Image = Properties.Resources.Fantome1G;
                        if (Direction == 3) Image = Properties.Resources.Fantome1H;
                    }
                    if (No == 2)
                    {
                        if (Direction == 0) Image = Properties.Resources.Fantome2D;
                        if (Direction == 1) Image = Properties.Resources.Fantome2B;
                        if (Direction == 2) Image = Properties.Resources.Fantome2G;
                        if (Direction == 3) Image = Properties.Resources.Fantome2H;
                    }
                    if (No == 3)
                    {
                        if (Direction == 0) Image = Properties.Resources.Fantome3D;
                        if (Direction == 1) Image = Properties.Resources.Fantome3B;
                        if (Direction == 2) Image = Properties.Resources.Fantome3G;
                        if (Direction == 3) Image = Properties.Resources.Fantome3H;
                    }
                    if (No == 4)
                    {
                        if (Direction == 0) Image = Properties.Resources.Fantome4D;
                        if (Direction == 1) Image = Properties.Resources.Fantome4B;
                        if (Direction == 2) Image = Properties.Resources.Fantome4G;
                        if (Direction == 3) Image = Properties.Resources.Fantome4H;
                    }
                    break;
                case 1: // Comestible
                    Image = Properties.Resources.Comestible;
                    break;
                case 2: // Fin comestible (clignotant)
                    Image = Properties.Resources.FinComestible;
                    break;
                case 3: // Retour yeux
                    if (Direction == 0) Image = Properties.Resources.YeuxD;
                    if (Direction == 1) Image = Properties.Resources.YeuxB;
                    if (Direction == 2) Image = Properties.Resources.YeuxG;
                    if (Direction == 3) Image = Properties.Resources.YeuxH;
                    break;
            }
        }
        public void ReduireDureeComestible()
        {
            if (DureeComestible > 0)
            {
                DureeComestible--;
                if (DureeComestible == 0 & Etat == 2) Etat = 0; // Redevient méchant
                if (DureeComestible == 0 & Etat == 1) Etat = 2; // Devient clignotant
            }
        }

        public override void GererSurGrille()
        {
            // Si retour yeux 3 cases sous la porte, fantôme repart vers le haut
            if (Etat == 3 & NatureCase(CaseActuelleX(), CaseActuelleY() - 3) == 4)
            {
                Etat = 0; // En chasse
                Direction = 3; // Vers le haut
                return;
            }
            // Déterminer combien de chemins existent
            int NbH = 0;
            // Au dessus : Libre, Point, Pouvoir, Tunnel, Porte autorisés
            if (NatureCase(CaseActuelleX(), CaseActuelleY() - 1) <= 4) NbH++;
            int NbB = 0;
            // En dessous : Libre, Point, Pouvoir, Tunnel autorisés
            if (NatureCase(CaseActuelleX(), CaseActuelleY() + 1) <= 3) NbB++;
            // Porte en dessous autorisé pour retour Yeux uniquement
            if (Etat == 3 & NatureCase(CaseActuelleX(), CaseActuelleY() + 1) == 4) NbB++;
            int NbG = 0;
            // A gauche : Libre, Point, Pouvoir, Tunnel autorisés
            if (NatureCase(CaseActuelleX() - 1, CaseActuelleY()) <= 3) NbG++;
            int NbD = 0;
            // A droite : Libre, Point, Pouvoir, Tunnel autorisés
            if (NatureCase(CaseActuelleX() + 1, CaseActuelleY()) <= 3) NbD++;
            switch (Etat)
            {
                case 0:
                case 3:
                    Point Objectif = ObjectifEnRelatif();
                    AllerVers(Objectif, NbH, NbB, NbG, NbD);
                    break;
                case 1:
                case 2:
                    SuivreUnCheminAuHasard(NbH, NbB, NbG, NbD);
                    break;
            }
        }
        // En mode défensif, choisir un chemin aléatoirement

        private void SuivreUnCheminAuHasard(int NbH, int NbB, int NbG, int NbD)
        {
            int Nb = NbH + NbB + NbG + NbD;
            while (true)
            {
                int DirectionEventuelle = (int)Math.Truncate((double)Aleatoire.Next(4));
                // Pas de retour en arrière sauf impasse (normalement absent ici)
                switch (DirectionEventuelle)
                {
                    case 0:
                        if (NbH > 0 & (Direction != 1 | Nb < 2)) { Direction = 3; return; }
                        break;
                    case 1:
                        if (NbB > 0 & (Direction != 3 | Nb < 2)) { Direction = 1; return; }
                        break;
                    case 2:
                        if (NbG > 0 & (Direction != 0 | Nb < 2)) { Direction = 2; return; }
                        break;
                    case 3:
                        if (NbD > 0 & (Direction != 2 | Nb < 2)) { Direction = 0; return; }
                        break;
                }
            }
        }
        // En mode attaque et retour yeux, se diriger vers l'objectif
        private void AllerVers(Point Objectif, int NbH, int NbB, int NbG, int NbD)
        {
            // Formuler les voeux
            string Voeu1 = "";
            string Voeu2 = "";
            string Voeu3 = "";
            string Voeu4 = "";
            if (Math.Abs(Objectif.X) > Math.Abs(Objectif.Y))
            { // Se déplacer horizontalement en priorité
                if (Objectif.X > 0) { Voeu1 = "D"; Voeu4 = "G"; }
                else { Voeu1 = "G"; Voeu4 = "D"; }
                if (Objectif.Y > 0) { Voeu2 = "B"; Voeu3 = "H"; }
                else { Voeu2 = "H"; Voeu3 = "B"; }
            }
            else // Se déplacer verticalement en priorité
            {
                if (Objectif.Y > 0) { Voeu1 = "B"; Voeu4 = "H"; }
                else { Voeu1 = "H"; Voeu4 = "B"; }
                if (Objectif.X > 0) { Voeu2 = "D"; Voeu3 = "G"; }
                else { Voeu2 = "G"; Voeu3 = "D"; }
            }
            // Exécuter un des voeux dans l'ordre
            int Nb = NbH + NbB + NbG + NbD;
            string Voeux = Voeu1 + Voeu2 + Voeu3 + Voeu4;
            while (Voeux != "")
            {
                string Voeu = Voeux.Substring(0, 1);
                Voeux = Voeux.Substring(1);
                switch (Voeu)
                {
                    case "H":
                        if (NbH > 0 & (Direction != 1 | Nb < 2)) { Direction = 3; return; }
                        break;
                    case "B":
                        if (NbB > 0 & (Direction != 3 | Nb < 2)) { Direction = 1; return; }
                        break;
                    case "G":
                        if (NbG > 0 & (Direction != 0 | Nb < 2)) { Direction = 2; return; }
                        break;
                    case "D":
                        if (NbD > 0 & (Direction != 2 | Nb < 2)) { Direction = 0; return; }
                        break;
                }
            }
        }
        private Point ObjectifEnRelatif()
        {
            Point Res = new Point();
            // Pour retour yeux, viser la porte
            if (Etat == 3)
            {
                Res.X = 18 - CaseActuelleX();
                Res.Y = 15 - CaseActuelleY();
                return Res;
            }
            // Pour le mode chasse, comportement agressif selon timer
            if (Grille.Fenetre.FantomesAgressifs)
            {
                // En mode attaque, viser Pacman ou autour de lui
                int DeltaX = 0;
                int DeltaY = 0;
                if (Grille.Fenetre.Pacman.Direction == 0) DeltaX = 8;
                if (Grille.Fenetre.Pacman.Direction == 1) DeltaY = 8;
                if (Grille.Fenetre.Pacman.Direction == 2) DeltaX = -8;
                if (Grille.Fenetre.Pacman.Direction == 3) DeltaY = -8;
                switch (No)
                {
                    case 1: // Blinky : Viser dessus
                        Res.X = Grille.Fenetre.Pacman.CaseActuelleX() - CaseActuelleX();
                        Res.Y = Grille.Fenetre.Pacman.CaseActuelleY() - CaseActuelleY();
                        break;
                    case 2: // Inky : Viser devant
                        Res.X = Grille.Fenetre.Pacman.CaseActuelleX() + DeltaX - CaseActuelleX();
                        Res.Y = Grille.Fenetre.Pacman.CaseActuelleY() + DeltaY - CaseActuelleY();
                        break;
                    case 3: // Pinky : Viser sur un coté
                        Res.X = Grille.Fenetre.Pacman.CaseActuelleX() + DeltaY - CaseActuelleX();
                        Res.Y = Grille.Fenetre.Pacman.CaseActuelleY() + DeltaX - CaseActuelleY();
                        break;
                    case 4: // Clyde : Viser sur l'autre coté
                        Res.X = Grille.Fenetre.Pacman.CaseActuelleX() - DeltaY - CaseActuelleX();
                        Res.Y = Grille.Fenetre.Pacman.CaseActuelleY() - DeltaX - CaseActuelleY();
                        break;
                }
            }
            else
            {
                // En mode pause, viser un des angles
                switch (No)
                {
                    case 1: // Blinky
                        Res.X = 1 - CaseActuelleX();
                        Res.Y = 3 - CaseActuelleY();
                        break;
                    case 2: // Inky
                        Res.X = 36 - CaseActuelleX();
                        Res.Y = 3 - CaseActuelleY();
                        break;
                    case 3: // Pinky
                        Res.X = 1 - CaseActuelleX();
                        Res.Y = 36 - CaseActuelleY();
                        break;
                    case 4: // Clyde
                        Res.X = 36 - CaseActuelleX();
                        Res.Y = 36 - CaseActuelleY();
                        break;
                }
            }
            return Res;
        }
    }

}
