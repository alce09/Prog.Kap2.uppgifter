using System;

namespace Uppgift2._3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Du jobbar på ett företag");
            Console.WriteLine("Vad har din kollega för lön varje månad");
            string kollega1 = Console.ReadLine();
            float kollega11 = float.Parse(kollega1);

            Console.WriteLine("Vad har din andra kollega för lön");
            string kollega2 = Console.ReadLine();
            float kollega22 = float.Parse(kollega2);

            Console.WriteLine("Vad har din tredje kollega för lön");
            string kollega3 = Console.ReadLine();
            float kollega33 = float.Parse(kollega3);

            float medelvärde = (kollega11 + kollega22 + kollega33) / 3;

            Console.WriteLine("Medelvärdet på lönen i ditt företag är " + medelvärde + ".");



        }



    }



}