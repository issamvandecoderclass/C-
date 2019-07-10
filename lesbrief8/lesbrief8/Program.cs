using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("Iphone", "Iphone X", "Apple IOS");
            Mobiel mobiel2 = new Mobiel("Galaxy", "Samsung S9", "Android");
            mobiel1.SetPrijs(1200f);
            mobiel2.SetPrijs(850f);

            boek1.prijs = 4.95f;
            boek2.prijs = 5.95f;

            Console.WriteLine("Hoeveel Apple " + mobiel1.nModel + " wilt u kopen?");
            int aantalIX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel Samsung " + mobiel2.nModel + " wilt u kopen?");
            int aantalSG = Convert.ToInt32(Console.ReadLine());

            float totaalPrijsIX = mobiel1.Btw(aantalIX);
            float totaalPrijsSG = mobiel2.Btw(aantalSG);

            Console.WriteLine(aantalIX + " Apple telefoon(s) kosten in totaal " + totaalPrijsIX);
            Console.WriteLine(aantalSG + " Samsung telefoon(s) kosten in totaal " + totaalPrijsSG);

            Console.ReadLine();
        }
    }
}