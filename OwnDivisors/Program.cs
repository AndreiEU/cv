using System;

namespace OwnDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int sem = 0;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers divisors are:");
            for(int i = 2; i<=n/2 ; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                    sem=1;
                }
                if(sem==0)
                Console.WriteLine("There are not divisors");
            }
        }
    }
}
