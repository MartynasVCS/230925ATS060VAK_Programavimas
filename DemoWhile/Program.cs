using System;

namespace DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int iteratorius = 0;
            while (iteratorius < 10)
            {
                Console.WriteLine(iteratorius);
                iteratorius++;
            }

            // Įvedimas su duomenų tipo apsauga
            // Žemiau užkomentuotas kodas yra be apsaugos
            // Jei vartotojas įves ne skaičių, tuomet programa suluš
            //Console.Write("Įveskite savo amžių: ");
            //int amzius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Jūsų įvestas amžius: {amzius}");

            int amzius = int.MinValue;
            while (amzius == int.MinValue)
            {
                Console.Write("Įveskite savo amžių: ");

                try
                {
                    amzius = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Klaida, įvedėte ne skaičių, bandykite iš naujo.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Įvyko klaida. Klaidos informacija: ");
                    Console.WriteLine(exception.Message);
                }
            }
            Console.WriteLine($"Jūsų įvestas amžius: {amzius}");
        }
    }
}
