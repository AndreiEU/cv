using System;

namespace Interchange
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Enter a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            b = float.Parse(Console.ReadLine());
            if(a == b)
               if(b == 0)
               Console.WriteLine("Ecuation nedet.");
               else 
                  Console.WriteLine("Ecuation impossible");
              else
              {
                  x = -b / a;
                  Console.WriteLine("Solution is x = {0}", x);
              }
              Console.ReadKey();
                
        }
    }
}
