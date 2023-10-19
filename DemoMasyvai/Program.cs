using System;
using System.Linq;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Masyvas iš konkrečių reikšmių
            int[] skaiciuMasyvasIsReiksmiu = { 9, 5, 15, -77, 154, 238, 1654113, 0, -1, -77 };

            // Konkretaus dydžio masyvas
            int[] skaiciusMasyvas = new int[11];
            string[] zodziuMasyvas = new string[11];

            // kintamųjų tipų alias'ai
            // string -> System.String
            // int -> System.Int32
            // int[] -> System.Int32[]

            // Masyvo reikšmių spausdinimas po vieną
            Console.WriteLine(skaiciuMasyvasIsReiksmiu[1]);
            Console.WriteLine(skaiciuMasyvasIsReiksmiu[2]);
            Console.WriteLine(skaiciuMasyvasIsReiksmiu[8]);
            // Console.WriteLine(skaiciuMasyvasIsReiksmiu[9]); // IndexOutOfRangeException
            // Console.WriteLine(skaiciuMasyvasIsReiksmiu[-1]); // IndexOutOfRangeException
            Console.WriteLine();

            // Visų masyvo reikšmių spausdinimas
            // Console.WriteLine(skaiciusMasyvas); // Taip nepavyks
            // Console.WriteLine(zodziuMasyvas); // Taip nepavyks

            // Standartinis for ciklas
            for (int i = 0; i < skaiciusMasyvas.Length; i++)
            {
                Console.WriteLine(skaiciusMasyvas[i]);
            }
            Console.WriteLine();

            // For ciklui analogiškas foreach
            foreach (int skaicius in skaiciusMasyvas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            // Masyvo reikšmių perrašymas po vieną reikšmę
            skaiciusMasyvas[5] = 9;
            skaiciusMasyvas[7] = 10;
            skaiciusMasyvas[8] = 5;

            // Visų masyvo reikšmių perrašymas
            for (int i = 0; i < skaiciusMasyvas.Length; i++)
            {
                skaiciusMasyvas[i] = 9;
            }
            Console.WriteLine();

            // Foreach ciklo panaudoti reikšmių perrašymui nepavyks
            // foreach (int skaicius in skaiciusMasyvas)
            // {
            //     // skaicius = 9; // Negalimas veiksmas
            // }
            
            // Sumos paieškos algoritmas
            int suma = 0;
            foreach (int skaicius in skaiciusMasyvas)
            {
                suma += skaicius;
            }
            Console.WriteLine($"Masyvo elementų suma: {suma}");

            // Didžiausios reikšmės paieškos algoritmas
            int max = skaiciuMasyvasIsReiksmiu[0];
            for (int i = 0; i < skaiciuMasyvasIsReiksmiu.Length; i++)
            {
                if (skaiciuMasyvasIsReiksmiu[i] > max)
                {
                    max = skaiciuMasyvasIsReiksmiu[i];
                }
            }
            Console.WriteLine($"Masyvo dižiausia reikšmė: {max}");

            // Didžiausios reikšmės paieškos algoritmas (adaptuotas)
            max = int.MinValue;
            for (int i = 0; i < skaiciuMasyvasIsReiksmiu.Length; i++)
            {
                if (skaiciuMasyvasIsReiksmiu[i] > max)
                {
                    max = skaiciuMasyvasIsReiksmiu[i];
                }
            }

            if (max != int.MinValue)
            {
                Console.WriteLine($"Masyvo dižiausia reikšmė: {max}");
            } 
            else
            {
                // Naudojant int.MinValue pradinei kintamojo max reikšmei saugoti
                // turime galimybę fiksuoti jeigu kažkas su mūsų paieškos algoritmu vyksta ne taip kaip turėtų
                Console.WriteLine($"Kažkas ne taip :/");
            }
        }
    }
}
