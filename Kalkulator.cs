using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace WSB_C_2020_Z1
{
    class Kalkulator
    {
        internal static BigInteger Dodawanie(int liczba1, int liczba2)
        {
            return liczba1 + liczba2;
        }

        internal static BigInteger Odejmowanie(int liczba1, int liczba2)
        {
            return liczba1 - liczba2;
        }

        internal static BigInteger Mnozenie(int liczba1, int liczba2)
        {
            return liczba1 * liczba2;
        }

        internal static BigInteger Dzielenie(int liczba1, int liczba2)
        {
            return liczba1 / liczba2;
        }
    }
}
