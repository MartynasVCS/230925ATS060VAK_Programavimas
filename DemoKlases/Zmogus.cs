using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKlases
{
    internal class Zmogus
    {
        private string vardas;
        public string pavarde { get; set; }
        public double ugis { get; }

        public Zmogus()
        {

        }

        public Zmogus(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }

        public Zmogus(string vardas, double ugis)
        {
            this.vardas = vardas;
            this.ugis = ugis;
        }

        public Zmogus(double ugis, string vardas)
        {
            this.vardas = vardas;
            this.ugis = ugis;
        }

        public void Prisistatymas()
        {
            Console.WriteLine($"Sveiki, mano vardas yra {vardas}, aš esu {ugis} ūgio.");
        }

        public string GautiZmogausVarda()
        {
            return vardas;
        }

        public void KeistiZmogausVarda(string vardas)
        {
            this.vardas = vardas;
        }

        public void KeistiZmogausUgi(double ugis)
        {
            // Kadangi parametras ugis neturi setter
            // jo reikšmę galime keisti tik per konstruktorių
            // this.ugis = ugis; // taip neveikia
        }
    }
}
