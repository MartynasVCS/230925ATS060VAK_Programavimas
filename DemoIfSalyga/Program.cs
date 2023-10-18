using System;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // palyginimo kairėje ir dešinėje pusėje turi būti vienodi tipai
            bool arTreciadienis = true;
            if (arTreciadienis == true)
            {
                Console.WriteLine("Šiandien yra trečiadienis");
            }

            int savaitesDiena = 3;
            if (savaitesDiena == 3)
            {
                Console.WriteLine("Šiandien yra trečiadienis");
            }

            if (savaitesDiena >= 3)
            {
                Console.WriteLine("Savaitė jau įpusėjo");
            }

            int skaicius = 8;
            // Nesusijusios if sąlygos
            // Tokios sąlygos tikrinamos visos net jeigu tenkinamos prieš tai buvusios
            if (skaicius > 15)
            {
                Console.WriteLine("Skaičius yra didesnis už 15");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Skaičius yra didesnis už 10");
            }
            if (skaicius > 7)
            {
                Console.WriteLine("Skaičius yra didesnis už 7");
            }

            // Jungtinis if blokas (if - else if - else if...)
            // Sąlygos tikrinamos kol randama pirma tenkinama sąlyga
            // Tuomet atliekamas jos kodas ir kitos sąlygos nėra tikrinamos
            if (skaicius > 15)
            {
                Console.WriteLine("Skaičius yra didesnis už 15");
            }
            else if (skaicius > 10)
            {
                Console.WriteLine("Skaičius yra didesnis už 10");
            }
            else if (skaicius > 7)
            {
                Console.WriteLine("Skaičius yra didesnis už 7");
            }

            // Jungtinis if blokas (if - else if... - else)
            // Sąlygos tikrinamos kol randama pirma tenkinama sąlyga
            // Tuomet atliekamas jos kodas ir kitos sąlygos nėra tikrinamos
            // Jei nei viena iš if/else if sąlygų nėra tenkinama
            // Tuomet vykdomas else dalies kodas
            if (skaicius > 15)
            {
                Console.WriteLine("Skaičius yra didesnis už 15");
            }
            else if (skaicius > 10)
            {
                Console.WriteLine("Skaičius yra didesnis už 10");
            }
            else if (skaicius >= 7)
            {
                Console.WriteLine("Skaičius yra didesnis už 7");
            }
            else
            {
                Console.WriteLine("Skaičius yra mažesnis už 7");
            }

            // Trumpesnis užrašymas (bloga praktika dėl prasto skaitomumo)
            if (skaicius == 7)
                Console.WriteLine("Skaičius yra lygus 7");

            // Dar trumpesnis užrašymas (bloga praktika dėl prasto skaitomumo)
            if (skaicius == 7) Console.WriteLine("Skaičius yra lygus 7");

            // Ternary operator
            arTreciadienis = (savaitesDiena == 3) ? true : false;

            // Ternary operator leidžia supaprastinti paprastą priskyrimo kodą
            if (savaitesDiena == 3)
            {
                arTreciadienis = true;
            }
            else
            {
                arTreciadienis = false;
            }

            // Bool palyginimas
            // Žemiau pateikiamos dvi sąlygos yra vienodos nors sintaksė skiriasi
            // Rekomendacija naudoti pirmąją sąlygą (dėl skaitomumo)
            if (arTreciadienis == true)
            {
                Console.WriteLine("Valio, trečiadienis!");
            }

            if (arTreciadienis)
            {
                Console.WriteLine("Valio, trečiadienis!");
            }

            // Žemiau pateikiamos trys sąlygos yra vienodos nors sintaksė skiriasi
            // Rekomendacija naudoti pirmąją sąlygą (dėl skaitomumo)
            if (arTreciadienis == false)
            {
                Console.WriteLine("Sad :(");
            }

            if (arTreciadienis != true)
            {
                Console.WriteLine("Sad :(");
            }

            if (!arTreciadienis)
            {
                Console.WriteLine("Sad :(");
            }
        }
    }
}
