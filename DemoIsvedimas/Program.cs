using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas konsolėje
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Labas, pasauli!");
            Console.WriteLine("Ačiū!");
            Console.WriteLine(); // tuščia eilutė

            // Frazės išvedimas be kintamųjų
            Console.WriteLine("Mano amžius: 35, o mano ūgis: 1.91.");
            
            // Frazės su kintamaisiais išvedimas
            int amzius = 35;
            float ugis = 1.91f;

            // Write + WriteLine
            Console.Write("Mano amžius: ");
            Console.Write(amzius);
            Console.Write(", o mano ūgis: ");
            Console.Write(ugis);
            Console.WriteLine(".");

            // String + non string = string
            Console.WriteLine("Mano amžius: " + amzius + ", o mano ūgis: " + ugis + ".");

            // Java way
            Console.WriteLine("Mano amžius: {0}, o mano ūgis: {1}.", amzius, ugis);

            // The smart way :sun-glasses:
            Console.WriteLine($"Mano amžius: {amzius}, o mano ūgis: {ugis}.");
        }
    }
}
