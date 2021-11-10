using System;

namespace GreatestCommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number:");
            int b = int.Parse(Console.ReadLine());

            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Console.WriteLine("GCF is {0}", b);
        }
    }
}
