using System;

namespace TF_CyberSecu.Demos.Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1987, 9, 27);

            int year = 1987;
            int month = 9;
            int day = 27;

            Date date;
            date.year = 1987;
            date.month = 9;
            date.day = 27;

            Date date2 = date;      //Copie des valeurs pas de système référentiel avec les structures

            date2.day = 1;

            Console.WriteLine($"date : {date.day}/{date.month}/{date.year}");
            Console.WriteLine($"date2 : {date2.day}/{date2.month}/{date2.year}");

            int[] dateArray = new int[] { 1987, 9, 27 };
            int[] date2Array = dateArray;       //Copie de l'adresse mémoire (référence), donc même valeur car même objet...
            date2Array[2] = 1;

            Console.WriteLine($"dateArray : {dateArray[2]}/{dateArray[1]}/{dateArray[0]}");
            Console.WriteLine($"date2Array : {date2Array[2]}/{date2Array[1]}/{date2Array[0]}");

        }
    }

    public struct Date {
        public int year , month, day;
    }

    public struct Time {
        public int hours, minutes, secondes, milliseconds;
    }

    public struct DateTimeCustom {
        public Date calendar;
        public Time clock;
    }

}
