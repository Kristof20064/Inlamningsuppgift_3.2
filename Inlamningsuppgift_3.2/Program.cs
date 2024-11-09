using System;
using System.Globalization;

namespace Inlamning_3._2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (skriv bokstaven j för ja och  bokstaven n för nej)");
            string skola = Console.ReadLine();


            Console.WriteLine("Hur gammal är du?");
            int år = int.Parse(Console.ReadLine());

            if (skola == "j" && år < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter andra personal just nu");
            }

        }
    }
}