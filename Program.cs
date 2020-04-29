using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int podstawa1 = 9;
            BigInteger wynik1 = 1;
            for (int i = 1; i <= podstawa1; i++)
            {
                wynik1 *= i;
            }
            Console.WriteLine("Silnia o podstawie: " + podstawa1 + " daje wynik: " + wynik1);

            int podstawa2 = 12;
            BigInteger wynik2 = 1;
            for (int i = 1; i <= podstawa2; i++)
            {
                wynik2 *= i;
            }
            Console.WriteLine("Silnia o podstawie: " + podstawa2 + " daje wynik: " + wynik2);

            int podstawa3 = 20;
            BigInteger wynik3 = 1;
            for (int i = 1; i <= podstawa3; i++)
            {
                wynik3 *= i;
            }
            Console.WriteLine("Silnia o podstawie: " + podstawa3 + " daje wynik: " + wynik3);

            Console.ReadLine();
        }
    }
}
