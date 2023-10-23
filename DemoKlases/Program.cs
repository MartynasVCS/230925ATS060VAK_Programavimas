using System;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // klasės žmogus objektai
            Zmogus zmogusPetras = new Zmogus("Petras", 1.78);
            Zmogus zmogusJonas = new Zmogus("Jonas", 1.95);

            // klasė gali turėti skirtingus konstruktorius
            // visi konstruktoriai vadinasi taip pat ir skiriasi parametrų sąrašu
            Zmogus nezinomas = new Zmogus();
            Zmogus zmogusPetrasPetrauskas = new Zmogus("Petras", "Petrauskas");

            // Encapsulation
            // klasės objekto parametrai neturėtų būti pasiekiami tiesiogiai
            // Console.WriteLine(zmogusJonas.vardas); // taip neveikia nes parametras vardas yra private
            Console.WriteLine(zmogusJonas.GautiZmogausVarda()); // pagalbinis metodas pasiekti parametro reikšmei
            // zmogusJonas.vardas = "Antanas"; // taip neveikia nes parametras vardas yra private
            zmogusJonas.KeistiZmogausVarda("Antanas"); // pagalbinis metodas pasiekti parametro reikšmei

            // Naudojant getters ir setters galima patogiai ir lanksčiai taikyti encapsulation principus
            // zmogusJonas.ugis = 1.85; // ūgio keisti negalime
            Console.WriteLine(zmogusJonas.ugis); // bet galime skaityti

            // Klasėje galime aprašyti įvairius metodus
            // Klasės metodai turi priėjimą prie klasės parametrų
            zmogusPetras.Prisistatymas();
            zmogusJonas.Prisistatymas();

            // Static vs non static
            // Statiniai metodai pasiekiami tiesiai iš klasės
            // Nestatiniai metodai pasiekiami tik per klasės objektą
            
            // Statinis metodas
            SkaiciuotuvasStatic.Sudetis(5, 2);

            // Nestatinis metodas
            SkaiciuotuvasNonStatic skaiciuotuvas1 = new SkaiciuotuvasNonStatic();
            skaiciuotuvas1.Sudetis(5, 2);
        }
    }

    class SkaiciuotuvasStatic
    {
        // statinis metodas
        public static int Sudetis(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }

    class SkaiciuotuvasNonStatic
    {
        // nestatinis metodas
        public int Sudetis(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }
}
