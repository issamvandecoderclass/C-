using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel();
            mobiel1.Type = "Iphone";
            mobiel1.Model = "Iphone X";
            mobiel1.OS = "Apple IOS";

            Mobiel mobiel2 = new Mobiel();
            mobiel2.Type = "Galaxy";
            mobiel2.Model = "Samsung S9";
            mobiel2.OS = "Android";

            Console.WriteLine(mobiel1.Type);
            Console.WriteLine(mobiel1.Model);
            Console.WriteLine(mobiel1.OS);

            Console.WriteLine(mobiel2.Type);
            Console.WriteLine(mobiel2.Model);
            Console.WriteLine(mobiel2.OS);

            Console.WriteLine()

            Console.ReadLine();
        }
    }
}