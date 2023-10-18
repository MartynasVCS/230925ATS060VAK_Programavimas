using System;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* 
             * Parašykite programą, 
             * kuri išvestų žodį “Labas” 
             * ir jūsų vardą toje pačioje eilutėje.
             */
            string name = "Martynas";
            Console.WriteLine("Labas " + name);
            Console.WriteLine();

            /*
             * Susikurkite kintamąjį žmogaus amžiui nusakyti, 
             * išveskite į ekraną tekstą su šiuo amžiumi: 
             * “Įvestas amžius: {amžius}”. 
             * Tarp {} nurodytas kintamasis, 
             * kurio reikšmė toje vietoje turi būti įstatyta.
             */
            int age = 34;
            Console.WriteLine("Įvestas amžius: " + age);
            Console.WriteLine();

            /*
             * Susikurkite skaičiaus kintamąjį, 
             * kurį išveskite penkis kartus toje pačioje eilutėje 
             * be tarpų tarp šių skaičių 
             * (skaičius - 25, išvedimas - 2525252525).
             */
            int number = 25;
            // Pirmas budas
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);

            // Antras budas
            Console.WriteLine("{0}{1}{2}{3}{4}", number, number, number, number, number);

            // Trecias budas
            Console.WriteLine("{0}{0}{0}{0}{0}", number);
            Console.WriteLine();

            // Ketvirtas būdas
            Console.WriteLine($"{number}{number}{number}{number}{number}");
            Console.WriteLine();

            /*
             * Susikurkite skaičiaus kintamąjį, 
             * kurį išveskite penkis kartus toje pačioje eilutėje 
             * su tarpais tarp šių skaičių 
             * (skaičius - 25, rezultatas - 25 25 25 25 25).
             */
            Console.WriteLine("{0} {0} {0} {0} {0}", number);

            // Kitas būdas
            Console.WriteLine($"{number} {number} {number} {number} {number}");
            Console.WriteLine();
        }
    }
}
