using System;

namespace TF_CyberSecu.Demos.MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d;
            d.AfficheInfo(42);
            d.AfficheInfo(3.14);
            d.AfficheInfo("Sam is the best!");
            //VRAIMENT PAS TERRIBLE...
            d.AfficheInfo(d: 3.14, i:42);
        }
    }

    public struct Demo {
        public void AfficheInfo(int i) {
            Console.WriteLine($"Nombre Entier : {i}");
        }
        public void AfficheInfo(double d)
        {
            Console.WriteLine($"Nombre décimal : {d}");
        }
        public void AfficheInfo(string s)
        {
            Console.WriteLine($"Chaine de caractères : '{s}' de {s.Length} caractères.");
        }


        //POSSIBLE, MAIS A NE SURTOUT PAS FAIRE!!!! => Trop de paramètres, trop de test, pas efficace!
        public void AfficheInfo(double? d = null, int? i = null, string s = null)
        {
            if (d != null) { 
                Console.WriteLine($"Nombre décimal : {d}"); 
                return; 
            }
            if (i != null)
            {
                Console.WriteLine($"Nombre Entier : {i}"); 
                return; 
            }
            if(s != null)
            {
                Console.WriteLine($"Chaine de caractères : '{s}' de {s.Length} caractères.");
                return;
            }
        }
    }
}
