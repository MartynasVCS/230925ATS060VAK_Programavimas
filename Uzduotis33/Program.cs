using System;

namespace Uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Įvesti du skaičius iš konsolės
             * 
             * Paklausti vartotojo kokį veiksmą 
             * su tais skaičiais nori atlikti: 
             *      sudėtis, 
             *      atimtis,  
             *      kėlimas 4 laipsniu sudėjus abu skaičius, 
             *      kvadratinė šaknis sudėjus abu skaičius.
             *      
             * Parašyti po atskirą metodą kiekvienam veiksmui
             *      sudėčiai ir atimčiai naudoti int tipą, 
             *      kitiems double.
             *      
             * Su switch() patikrinti kokį veiksmą atlikti 
             * ir kiekviename case‘e išsikviesti atitinkamą metodą, 
             * jei tokio case‘o nėra – informuoti vartotoją, 
             * jog tokio veiksmo nėra.
             */

            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Galimi veiksmai su skaičiais:");
            Console.WriteLine("  1 - sudėtis");
            Console.WriteLine("  2 - atimtis");
            Console.WriteLine("  3 - kėlimas 4 laipsniu sudėjus abu skaičius");
            Console.WriteLine("  4 - kvadratinė šaknis sudėjus abu skaičius");
            Console.WriteLine();
            Console.Write("Kokį veiksmą norėtumėte atlikti?: ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            string rezultatas = "";

            switch (pasirinkimas)
            {
                case 1:
                    rezultatas = $"Suma: {Suma(skaicius1, skaicius2)}";
                    break;
                case 2:
                    rezultatas = $"Skirtumas: {Atimtis(skaicius1, skaicius2)}";
                    break;
                case 3:
                    rezultatas = $"Skaičių suma pakelta ketvirtuoju laipsniu: {KelimasLaipsniu(skaicius1, skaicius2, 4)}";
                    break;
                case 4:
                    rezultatas = $"Skaičių sumos kvadratinė šaknis: {KvadratineSaknis(skaicius1, skaicius2)}";
                    break;
                default:
                    rezultatas = "Įvedėte neegzistuojantį pasirinkimą, darbas nutraukiamas!";
                    break;
            }

            Console.WriteLine(rezultatas);
        }

        private static double KvadratineSaknis(int skaicius1, int skaicius2)
        {
            return Math.Sqrt(skaicius1 + skaicius2);
        }

        private static double KelimasLaipsniu(int skaicius1, int skaicius2, int laipsnis)
        {
            return Math.Pow(skaicius1 + skaicius2, laipsnis);
        }

        private static int Atimtis(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        private static int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }
}
