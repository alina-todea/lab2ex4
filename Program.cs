using System;

namespace Lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            Scrieti o functie care va determina daca un numar este sau nu patrat perfect.
            Apelati-o si afisati-i rezultatul
            */

            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("numarul " + n + " " + EstePatratPerfect(n));

        }

        static string EstePatratPerfect(int n)
        {

            double radacina = Math.Sqrt(n);
            string result = "nu este patrat perfect";

            if (radacina % 1 == 0)
            {
                result = "este patrat perfect";
            }

            return result;
        }
    }
}
