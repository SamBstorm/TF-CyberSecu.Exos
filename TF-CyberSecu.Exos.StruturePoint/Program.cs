using System;

namespace TF_CyberSecu.Exos.StruturePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 5;
            Point?[,] tableau = new Point?[TAILLE, TAILLE];

            for (int i = 0; i < TAILLE; i++)
            {
                Point p;
                p.X = i + 1;
                p.Y = i + 1;
                tableau[i, i] = p;
            }

            for (int x = 0; x < TAILLE; x++)
            {
                for (int y = 0; y < TAILLE; y++)
                {
                    if (tableau[x, y] is null)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Point p = (Point)tableau[x, y];
                        Console.Write($"X : {p.X} - Y : {p.Y}");

                        //OU
                        //Console.Write($"X : {tableau[x, y]?.X} - Y : {tableau[x, y]?.Y}");        // '?.' soit l'objet est null et nous n'avons pas accès au '.', soit il ne l'est pas et on y a accès
                    }
                }
                Console.WriteLine();
            }
        }

        public struct Point
        {
            public int X;
            public int Y;
        }
    }
}
