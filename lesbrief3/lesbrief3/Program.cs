using System;

namespace Korting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kortingsLeeftijd = 20;
            Console.Write("Wat is uw leeftijd? ");
            int leeftijd = Convert.ToInt16(Console.ReadLine());
            Console.Write("Heeft u een klantenkaart (ja/nee): ");
            string extraKorting = Console.ReadLine();

            if (leeftijd > kortingsLeeftijd && extraKorting == "ja")
            {
                Console.WriteLine("U komt in aanmerking voor een korting!");
            }
            else
            {
                Console.WriteLine("Helaas geen korting.");
            }

            Console.ReadLine();
        }
    }
}