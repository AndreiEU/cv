using System;

namespace EcuationOfDegree1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,b,x;
            Console.WriteLine("Number a = ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Number b = ");
            b = float.Parse(Console.ReadLine());
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Ecuation unlimited");
                }
                else
                {
                    Console.WriteLine("Ecuation impossible");
                }
            }
                else
                {
                    x = -b/a;
                    Console.WriteLine("The result of ecuation {0}",x);
                }
                Console.ReadKey();
            }
        }
    }

