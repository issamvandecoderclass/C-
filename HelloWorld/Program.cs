﻿using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = "Koffie";
            int aantal;
            float prijsExclBtwK = 3.95f;
            float prijsExlbtwT = 4.12f;

            float btwPercentage = 0.21f;

            Console.WriteLine("Een pakje koffie kost " + prijsExclBtwK + " ex btw.");
            Console.WriteLine("Een pakje  kost " + prijsExclBtwT +" ex btw.");
            Console.WriteLine("Een pakje  kost " + prijsExclBtwT + " ex btw.");
            Console.WriteLine("Een pakje  kost " + prijsExclBtwT + " ex btw.");
            Console.WriteLine("Een pakje  kost " + prijsExclBtwT + " ex btw.");
            Console.WriteLine("Een pakje  kost " + prijsExclBtwT + " ex btw.");

            aantal = Convert.ToInt32(Console.ReadLine());
            float totaalPrijs = aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage;

            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs);

        }
    }
}