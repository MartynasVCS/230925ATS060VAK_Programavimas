using System;

namespace DemoMetodai
{
    internal class Skaiciuotuvas
    {
        static internal int Sudetis(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }

        static internal double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        // Rekursinis metodas
        static internal void DalybaIsDviejuIkiNulio(double skaicius)
        {
            double rezultatas = skaicius / 2;
            Console.WriteLine(rezultatas);
            if (Math.Round(rezultatas, 3) != 0)
            {
                DalybaIsDviejuIkiNulio(rezultatas);
            }
        }
    }
}
