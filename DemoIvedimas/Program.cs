using System;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // tipas     pavadinimas     priskyrimas    reikšmė
            string        tekstas            =        "Laba diena";

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Labas, {ivedimas}");

            Console.WriteLine("Įveskite savo amžių:");
            Console.WriteLine($"Tavo amžius: {Console.ReadLine()}");

            Console.WriteLine("Įveskite savo ūgį:");
            ivedimas = Console.ReadLine();
            double ugis = Convert.ToDouble(ivedimas);
            Console.WriteLine($"Iki dviejų metrų tau trūksta {2 - ugis}");

            Console.WriteLine("Simbolio įvedimas");
            Console.WriteLine("Įveskite pirmą simbolį: ");
            int simbolisAscii = Console.Read();
            Console.ReadLine();
            char simbolis = Convert.ToChar(simbolisAscii);
            Console.WriteLine($"Jūsų įvestas simbolis: {simbolis}");
        }
    }
}
