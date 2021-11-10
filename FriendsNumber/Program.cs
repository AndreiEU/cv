using System;

namespace FriendsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Read second number");
            int b = int.Parse(Console.ReadLine());
            int sa,sb;
            sa = 0;
            sb = 0;
            int i;
            for(i = 2; i <= a/2; i++)
            {
                if(a % i == 0)
                {
                    sa = sa + i; //the sum of the divisors of number a
                }
        }
        for(i = 2; i <=b/2; i++)
        {
            if(b % i ==0)
            {
                sb = sb + 1; //the sum of the divisors of number b
            }
        }
        if(sa ==b && sb == a)
        {
            Console.WriteLine("Are firends number");
        }
        else
        {
            Console.WriteLine("Doesn't firends number");
        }
    }
}

}
    
