using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger wynik = 1;
            Console.WriteLine("Witam w programie do liczenia silni. \n\nProszę podać liczbę, do oblicznenia: ");
            int podstawa = int.Parse(Console.ReadLine());

            for (int i = 1; i <= podstawa; i++)
            {
                wynik *= i;
            }

            Console.WriteLine("Silnia o podstawie: " + podstawa + " daje wynik: " + wynik);

            Console.ReadLine();
        }
    }
}
