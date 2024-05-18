
namespace PacMan
{
    public class Pacman : Sprite
    {
        public int DirectionSuivante = -1; // Pas de chgt de direction
        private bool mMort;
        public bool Mort
        {
            get { return mMort; }
            set { mMort = value; MajImage(); } // Changement Etat => Redessiner
        }
        public Pacman() : base()
        {
            Init();
        }
        public override void Init()
        {
            base.Init(); // Init de Sprite
            DirectionSuivante = -1;
            Mort = false;
        }
        public override void MajImage()
        {
            if (Mort) Image = Properties.Resources.JoueurMort;
            else
            {
                if (Vitesse == 0)
                {
                    if (Direction == 0) Image = Properties.Resources.JoueurD;
                    if (Direction == 1) Image = Properties.Resources.JoueurB;
                    if (Direction == 2) Image = Properties.Resources.JoueurG;
                    if (Direction == 3) Image = Properties.Resources.JoueurH;
                }
                else
                {
                    if (Direction == 0) Image = Properties.Resources.JoueurAnimeD;
                    if (Direction == 1) Image = Properties.Resources.JoueurAnimeB;
                    if (Direction == 2) Image = Properties.Resources.JoueurAnimeG;
                    if (Direction == 3) Image = Properties.Resources.JoueurAnimeH;
                }
            }
        }
        public override void GererSurGrille()
        {
            // Gérer les points et les pouvoirs
            int x = CaseActuelleX();
            int y = CaseActuelleY();
            switch (NatureCase(x, y))
            {
                case 0: // Espace
                    break;
                case 1: // Point
                    Grille.Cases[x, y] = ' '; // Noter le point comme mangé
                    Grille.Fenetre.EffacerPointSurGrille(x, y); // Reporter visuellement
                    Grille.Fenetre.Score += 10;
                    break;
                case 2: // Pouvoir
                    Grille.Cases[x, y] = ' '; // Noter le pouvoir comme mangé
                    if (y < 20) // Déterminer le quart concerné et masquer l'objet
                    {
                        if (x < 20) Grille.Fenetre.PbForce1.Hide();
                        else Grille.Fenetre.PbForce2.Hide();
                    }
                    else
                    {
                        if (x < 20) Grille.Fenetre.PbForce3.Hide();
                        else Grille.Fenetre.PbForce4.Hide();
                    }
                    // Placer les fantômes en comestible, sauf si retour yeux
                    if (Grille.Fenetre.Fantome1.Etat <= 2) Grille.Fenetre.Fantome1.Etat = 1;
                    if (Grille.Fenetre.Fantome2.Etat <= 2) Grille.Fenetre.Fantome2.Etat = 1;
                    if (Grille.Fenetre.Fantome3.Etat <= 2) Grille.Fenetre.Fantome3.Etat = 1;
                    if (Grille.Fenetre.Fantome4.Etat <= 2) Grille.Fenetre.Fantome4.Etat = 1;
                    Grille.Fenetre.Score += 100;
                    break;
            }
            // Gérer le changement de direction
            if (DirectionSuivante >= 0)
            {
                int OldDirection = Direction; // Mémoriser la direction
                int OldVitesse = Vitesse; // et la vitesse pour restauration éventuelle
                Direction = DirectionSuivante;
                Vitesse = 4; // Avancer à nouveau si nécessaire
                if (CheminAPoursuivre())
                {
                    DirectionSuivante = -1; // Valider le changement de direction
                    return;
                }
                Direction = OldDirection; // Restaurer la direction
                Vitesse = OldVitesse; // et la vitesse
            }
            // Gérer l'arrivée sur un mur
            if (!CheminAPoursuivre()) Vitesse = 0;
        }
        // Déterminer si le chemin actuel est valide
        public bool CheminAPoursuivre()
        {
            bool Res = true;
            switch (NatureCase(CaseSuivanteX(), CaseSuivanteY()))
            {
                case 0: // Libre: Ok
                case 1: // Point: Ok
                case 2: // Pouvoir: Ok
                    break;
                case 3: // Tunnel: Faire traverser
                    if (CaseActuelleX() == 0) MilieuX = Grille.CentreCaseY(Grille.MaxColonnes);
                    else MilieuX = Grille.CentreCaseX(0);
                    break;
                case 4: // Porte
                    if (Direction != 3) Res = false; // Franchir la porte uniquement en montant
                    break;
                case 5: // Interdit
                    Res = false;
                    break;
            }
            return Res;
        }
    };
}
