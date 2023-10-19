using System;

namespace DemoMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Pasisveikinimas();

            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            PasisveikinimasSuVardu(vardas);
            PasisveikinimasSuVardu("Petras");
            PasisveikinimasSuVardu("Martynai");
            PasisveikinimasSuVarduIrPavarde("Antanas", "Antanauskas");

            int skaicius1 = 7;
            int skaicius2 = 5;
            Console.Write($"Skaičių {skaicius1} ir {skaicius2} suma yra: ");
            Console.WriteLine(Skaiciuotuvas.Sudetis(skaicius1, skaicius2));

            Console.Write($"Skaičių {skaicius1} ir {skaicius2} dalmuo yra: ");
            Console.WriteLine(Skaiciuotuvas.Dalyba(skaicius1, skaicius2));

            Skaiciuotuvas.DalybaIsDviejuIkiNulio(5);
        }

        static void Pasisveikinimas()
        {
            Console.WriteLine("Labas, pasauli!");
        }

        static void PasisveikinimasSuVardu(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}!");
        }

        static void PasisveikinimasSuVarduIrPavarde(string vardas, string pavarde)
        {
            Console.Write($"Labas žmogau kurio vardas yra {vardas}");
            Console.WriteLine($" o pavardė yra {pavarde}!");
        }
    }
}
