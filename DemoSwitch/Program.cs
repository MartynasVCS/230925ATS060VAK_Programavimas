using System;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Įveskite gyvūno pavadinimą: ");
            string gyvunas = Console.ReadLine();
            switch (gyvunas)
            {
                case "šuo":
                    Console.WriteLine("Gyvūnas yra šuo");
                    break;
                case "Šuo":
                    Console.WriteLine("Gyvūnas yra Šuo");
                    break;
                default:
                    Console.WriteLine("Neaiškus gyvūnas");
                    break;
            }

            Console.Write("Įveskite gyvūno amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            switch (amzius)
            {
                case 1:
                    Console.WriteLine($"{gyvunas} dar mažas");
                    break;
                case 2:
                    Console.WriteLine($"{gyvunas} jau nebemažas");
                    break;
            }
        }
    }
}
