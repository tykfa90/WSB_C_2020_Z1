using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger wynik = 0;
            Console.WriteLine("Witam w programie do mnożenia liczb. \n\nProszę podać pierwszą liczbę do mnożenia: ");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Proszę podać drugą liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());

            wynik = liczba1 * liczba2;

            Console.WriteLine("Wynik mnożenia to: " + wynik);

            Console.ReadLine();
        }
    }
}
