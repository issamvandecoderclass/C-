using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("Iphone", "Iphone X", "Apple IOS");
            Mobiel mobiel2 = new Mobiel("Galaxy", "Samsung S9", "Android");

            Console.WriteLine(Mobiel1);
            Console.WriteLine(mobiel2);

            Console.ReadLine();
        }
    }
}