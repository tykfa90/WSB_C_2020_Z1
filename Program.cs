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
                "\n\nProszę wybrać typ działania z listy: " +
                "\n1 - Dodawanie" +
                "\n2 - Odejmowanie" +
                "\n3 - Mnożenie." +
                "\n4 - Dzielenie.");
            string opcja = Console.ReadLine();

            Console.WriteLine("\n\nProszę podać pierwszą liczbę do działania: ");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Proszę podać drugą liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());

            switch (opcja)
            {
                case "1":
                    Console.WriteLine("Wybrano dodawanie.");
                    wynik = Kalkulator.Dodawanie(liczba1, liczba2);
                    break;
                case "2":
                    Console.WriteLine("Wybrano odejmowanie.");
                    wynik = Kalkulator.Odejmowanie(liczba1, liczba2);
                    break;
                case "3":
                    Console.WriteLine("Wybrano mnożenie.");
                    wynik = Kalkulator.Mnozenie(liczba1, liczba2);
                    break;
                case "4":
                    Console.WriteLine("Wybrano dzielenie.");
                    while (liczba2 == 0)
                    {
                        Console.WriteLine("Dzielenie przez zero nie jest możliwe! Proszę wybrać inną liczbę: ");
                        liczba2 = int.Parse(Console.ReadLine());
                    }
                    wynik = Kalkulator.Dzielenie(liczba1, liczba2);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowe polecenie.");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("Wynik działania to: " + wynik);

            Console.ReadLine();
        }
    }
}
