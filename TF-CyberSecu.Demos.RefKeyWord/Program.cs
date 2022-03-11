using System;

namespace TF_CyberSecu.Demos.RefKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleves e = new Eleves();
            //e.elevesName = new string[] { "Anas", "Soussi", "Jason", "Dorian", "Eric", "Jean", "Raphael", "Cedrick" };

            string prenom = e.getName(1);
            Console.WriteLine($"Prénom : {prenom}"); //Aurélien
            prenom = "Aurélie";
            Console.WriteLine($"Prénom : {prenom}"); //Aurélie
            Console.WriteLine($"Prénom dans la structure : {e.getName(1)}"); //Aurélien


            ref string refprenom = ref e.getrefName(1);
            Console.WriteLine($"Prénom : {refprenom}"); //Aurélien
            refprenom = "Aurélie";
            Console.WriteLine($"Prénom : {refprenom}"); //Aurélie
            Console.WriteLine($"Prénom dans la structure : {e.getName(1)}"); //Aurélie

        }
    }

    public struct Eleves
    {
        public string[] elevesName;

        public string getName(int index)
        {
            elevesName ??= new string[] { "Lucas", "Aurélien", "Alexandre", "Philippe" };
            return elevesName[index];
        }

        public void setName(int index, string newName)
        {
            elevesName ??= new string[] { "Lucas", "Aurélien", "Alexandre", "Philippe" };
            elevesName[index] = newName;
        }


        public ref string getrefName(int index)
        {
            elevesName ??= new string[] { "Lucas", "Aurélien", "Alexandre", "Philippe" };
            return ref elevesName[index];
        }
    }
}
