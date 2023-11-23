using System;
using System.Globalization;

namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange namn 1");
            string name1 = Console.ReadLine();
            Console.WriteLine("ange ålder 1");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn 2");
            string name2 = Console.ReadLine();
            Console.WriteLine("ange ålder 2");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn 3");
            string name3 = Console.ReadLine();
            Console.WriteLine("ange ålder 3");
            int age3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn 4");
            string name4 = Console.ReadLine();
            Console.WriteLine("ange ålder 4");
            int age4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name1 + " är " + age1 + " år gammal");
            Console.WriteLine(name2 + " är " + age2 + " år gammal");
            Console.WriteLine(name3 + " är " + age3 + " år gammal");
            Console.WriteLine(name4 + " är " + age4 + " år gammal");

            double totalage = age1 + age2 + age3 + age4;
            double median = totalage / 4;
            string dec = median.ToString("0.00"); 
            Console.WriteLine("totalålder " + totalage);
            Console.WriteLine("medelålder " + dec);

            

           
        }
    }
}

 