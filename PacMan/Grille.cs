namespace PacMan
{
    static class Grille
    {
        public const int GrilleLeft = 12; // 12 pts du bord de la fenêtre
        public const int GrilleTop = 12; // Idem en haut
        public const int PremiereCaseLeft = 13; // 11 pts dans la grille
        public const int PremiereCaseTop = 13; // Idem
        public const int LargeurCase = 12; // 12 pts de largeur pour chaque case
        public const int HauteurCase = 12; // Idem
        public const int MaxColonnes = 37;
        public const int MaxLignes = 40;
        public static Form1 Fenetre = null;
        private static string[] Lignes = {
            "+----------------+ +----------------+",
            "|................| |................|",
            "|.+----+.+-----+.| |.+-----+.+----+.|",
            "|*|    |.|     |.| |.|     |.|    |*|",
            "|.|    |.|     |.| |.|     |.|    |.|",
            "|.+----+.+-----+.+-+.+-----+.+----+.|",
            "|...................................|",
            "|.+----+.+-+.+---------+.+-+.+----+.|",
            "|.|    |.| |.|         |.| |.|    |.|",
            "|.+----+.| |.+---+ +---+.| |.+----+.|",
            "|........| |.....| |.....| |........|",
            "+------+.| +---+ | | +---+ |.+------+",
            "       |.|     | | | |     |.|       ",
            "       |.| +---+ +-+ +---+ |.|       ",
            "       |.| |             | |.|       ",
            "       |.| | +--++=++--+ | |.|       ",
            "       |.| | ++-++ ++-++ | |.|       ",
            "-------+.+-+ || ++ ++ || +-+.+-------",
            "        .    ||       ||    .        ",
            "-------+.+-+ || +---+ || +-+.+-------",
            "       |.| | ++-------++ | |.|       ",
            "       |.| | +---------+ | |.|       ",
            "       |.| |             | |.|       ",
            "       |.| | +---------+ | |.|       ",
            "       |.| | |         | | |.|       ",
            "+------+.+-+ +---+ +---+ +-+.+------+",
            "|................| |................|",
            "|.+----+.+-----+.| |.+-----+.+----+.|",
            "|.|    |.|     |.| |.|     |.|    |.|",
            "|.+--+ |.+-----+.+-+.+-----+.| +--+.|",
            "|*...| |.....................| |...*|",
            "+--+.| |.+-+.+---------+.+-+.| |.+--+",
            "   |.| |.| |.|         |.| |.| |.|   ",
            "+--+.+-+.| |.+---+ +---+.| |.+-+.+--+",
            "|........| |.....| |.....| |........|",
            "|.+------+ +---+.| |.+---+ +------+.|",
            "|.|            |.| |.|            |.|",
            "|.+------------+.+-+.+------------+.|",
            "|...................................|",
            "+-----------------------------------+"};

        public static char[,] Cases = new char[MaxColonnes, MaxLignes];
        public static void Init()
        {
            for (int j = 0; j < MaxLignes; j++)
            {
                for (int i = 0; i < MaxColonnes; i++)
                {
                    Cases[i, j] = Lignes[j][i];
                }
            }
        }
        public static int CentreCaseX(int Colonne)
        {
            return Colonne * LargeurCase + GrilleLeft + PremiereCaseLeft;
        }
        public static int CentreCaseY(int Ligne)
        {
            return Ligne * HauteurCase + GrilleTop + PremiereCaseTop;
        }
    }
}
