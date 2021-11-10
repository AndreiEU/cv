using System;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Write first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number");
            b = int.Parse(Console.ReadLine());
            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("are divisible");
            }
            else
            {
                Console.WriteLine("they are not divisible");
            }
        }
    }
}
