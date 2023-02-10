using System;
namespace uppgift6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            tal(2, 5, 6);
        }
        static void tal(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            Console.WriteLine("Den summa är" + summa + ".");
        }
    }
}