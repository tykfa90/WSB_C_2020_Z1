using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger wynik = 0;
            Console.WriteLine("Witam w kalkulatorze. " +
                "\nProszę wybrać typ działania z listy: " +
                "\n1 - Dodawanie" +
                "\n2 - Odejmowanie");
            string opcja = Console.ReadLine();

            Console.WriteLine("\n\nProszę podać pierwszą liczbę do działania: ");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Proszę podać drugą liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());

            if (opcja == "1")
            {
                wynik = liczba1 + liczba2;
            }
            if (opcja == "2")
            {
                wynik = liczba1 - liczba2;
            }

            Console.WriteLine("Wynik działania to: " + wynik);

            Console.ReadLine();
        }
    }
}
