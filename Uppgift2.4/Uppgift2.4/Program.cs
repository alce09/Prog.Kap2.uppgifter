using System;

namespace Uppgift2._4
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hej startavgiften på bilen är 300kr");
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int antldagar = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många kilometer vill du köra?");
            float km = float.Parse(Console.ReadLine());

            float C = 300 + km + 500 * (antldagar - 1);

            Console.WriteLine("Summan du ska betala är " + C + "kronor");





        }




    }




}