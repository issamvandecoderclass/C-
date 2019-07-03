using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesbrief8-2
{
    class Program
    {
        const string product = "Koffie";
        const float prijsExclBtw = 3.95f;
        const float btwPercentage = 0.21f;
        static void Main(string[] args)
        {
            Console.WriteLine("Een pakje " + product + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs);
            Console.ReadLine();
            const int aantal;
            const float totaalPrijs = aantal * prijsExclBtw + BtwBerekening(aantal, prijsExclBtw, btwPercentage);
        }
        public static float BtwBerekening(int aantal, float btwPrijs, float btwPercentage)
        {
            return (aantal * btwPrijs) * btwPercentage;
        }
    }
}

