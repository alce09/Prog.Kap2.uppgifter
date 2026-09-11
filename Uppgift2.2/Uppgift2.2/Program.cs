using System;

namespace Uppgift2._2
{
    class Program
    {   
        static void Main(string[]args)
        {
            Console.WriteLine("Alma hoppade och slog världsrekordet i höjdhopp, hon hoppade 10 meter.");
            Console.WriteLine("Hur högt kan du hoppa?");
            string höjden = Console.ReadLine();

            float höjdslut = float.Parse(höjden);

            float summa = 10 - höjdslut;

            Console.WriteLine("Alma kan hoppa " + summa + "meter längre en dig:)");
            





        }




    }




}