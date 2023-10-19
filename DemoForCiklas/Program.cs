using System;

namespace DemoForCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 7;

            // Standartinis ciklas
            //    kintamasis      sąlyga     operacija
            for (int i = 0;       i < 10;       i++)
            {
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
            }
            Console.WriteLine();

            for (string i = "a"; i != "aaaaa"; i += "a")
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10;)
            {
                Console.WriteLine("Kas čia vyksta?!?");
                i++; // Pabandykit ištrinti šitą eilutę ir paleisti programą
            }
            Console.WriteLine();

            for (int i = 1; i < 5000; i *= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 50; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int temp = 0;
            for (int i = 0; i < 50; i += 5)
            {
                 temp = i + 5;
            }
            Console.WriteLine(temp);
        }
    }
}
