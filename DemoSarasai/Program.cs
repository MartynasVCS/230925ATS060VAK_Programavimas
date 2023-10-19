using System;
using System.Collections.Generic;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Masyvai
            int[] skaiciuMasyvasIsReiksmiu = { 1, 2, 3 };
            int[] skaiciusMasyvasKonkretausDydzio = new int[3];

            // Sąrašai
            List<int> skaiciusSarasasIsReiksmiu = new List<int>() { 1, 2, 3 };
            List<int> skaiciusSarasasTuscias = new List<int>();

            // Spausdinimas
            Console.WriteLine(skaiciusSarasasIsReiksmiu[2]);
            // Console.WriteLine(skaiciusSarasasIsReiksmiu[3]); // Nėra elemento su indeksu 3
            Console.WriteLine();

            foreach (int skaicius in skaiciusSarasasIsReiksmiu)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            // Reikšmių perrašymas
            skaiciusSarasasIsReiksmiu[2] = 77;

            // Reikšmių pridėjimas
            skaiciusSarasasIsReiksmiu.Add(11);
            skaiciusSarasasIsReiksmiu.Add(15);
            skaiciusSarasasIsReiksmiu.Add(2);
            skaiciusSarasasIsReiksmiu.Add(-11);
            skaiciusSarasasIsReiksmiu.Add(2);

            foreach (int skaicius in skaiciusSarasasIsReiksmiu)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            // Reikšmių trynimas
            skaiciusSarasasIsReiksmiu.Remove(2);
            skaiciusSarasasIsReiksmiu.RemoveAt(5);

            foreach (int skaicius in skaiciusSarasasIsReiksmiu)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();
        }
    }
}
