using System;

namespace DemoAritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int sudetis = 2 + 3;
            Console.WriteLine(sudetis);
            Console.WriteLine(7 - 2);
            Console.WriteLine(sudetis * 2);
            Console.WriteLine();

            Console.WriteLine("Veiksmų seka pagal matematikos taisykles");
            Console.WriteLine(5 + 5 * 2);
            Console.WriteLine((5 + 5) * 2);
            Console.WriteLine();

            Console.WriteLine("Sveikųjų skaičių dalyba");
            Console.WriteLine(8 / 4);
            Console.WriteLine(7 / 4); // Sveikoji dalis
            Console.WriteLine(7 % 4); // Liekana
            Console.WriteLine();

            Console.WriteLine("Realiųjų skaičių dalyba");
            Console.WriteLine(7f / 4);
            Console.WriteLine(7 / 4f);
            Console.WriteLine(7.0 / 4);
            Console.WriteLine(7 / 4.0);
            Console.WriteLine();

            Console.WriteLine("Casting");
            int dalinys = 7;
            int daliklis = 4;

            Console.WriteLine((double)dalinys / daliklis);
            Console.WriteLine(dalinys / (double)daliklis);
            Console.WriteLine();

            string tekstas = "labas";
            // Console.WriteLine((int)tekstas); // Taip neveikia
            
            Console.WriteLine("Dalyba iš nulio");
            // Console.WriteLine(1 / 0); // Taip neveikia
            Console.WriteLine(1 / 0.0);
            Console.WriteLine();

            Console.WriteLine("Kintamojo reikšmės keitimas");
            int skaicius = 5;
            Console.WriteLine(skaicius);
            skaicius = 7;
            skaicius = 9;
            Console.WriteLine(skaicius);
            skaicius = 8 * 2;
            Console.WriteLine(skaicius);
            skaicius = skaicius / 2;
            Console.WriteLine(skaicius);
            Console.WriteLine();

            Console.WriteLine("Sutrumpintas kintamojo reikšmės keitimas");
            // Žemiau pateiktos eilučių poros atlieka tą patį
            skaicius = skaicius / 2;
            skaicius /= 2;

            skaicius = skaicius + 2;
            skaicius += 2;

            Console.WriteLine("Kintamojo reikšmės didinimas / mažinimas vienetu");
            // indeksas++
            // indeksas = indeksas + 1

            int indeksas = 5;
            Console.WriteLine(indeksas);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas);
            Console.WriteLine();

            indeksas = 5;
            Console.WriteLine(indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(indeksas);
            Console.WriteLine();

            Console.WriteLine("Sudėtingesni matematiniai veiksmai");
            Console.WriteLine(5 * 5); // 5^2 Kėlimas kvadratu
            Console.WriteLine(5 * 5 * 5); // 5^3 Kėlimas kubu
            Console.WriteLine(Math.Pow(5, 17)); // 5^17 Kėlimas septynioliktu laipsniu
            Console.WriteLine(Math.Sqrt(25)); // 5^(1/2) Kvadratinė šaknis
            Console.WriteLine(Math.Pow(25, 0.5)); // Kvadratinė šaknis
            Console.WriteLine(Math.Pow(27, 1 / 3.0)); // Kubinė šaknis
        }
    }
}
