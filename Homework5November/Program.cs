using System.Linq;
using System;


namespace Homework5November
{
    class Program
    {
        static void Main(string[] args)
        {
           int i;
           Console.WriteLine("Write elements of vector a");
           int[] a = new int[5];
           for(i = 0; i < 5; i++)
           {
               a[i] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine("Write elements of vector b");
           int[] b = new int[7];
           for(i = 0; i < 7; i++)
           {
               b[i] = int.Parse(Console.ReadLine());
           }

           int[] c = a.Concat(b).ToArray();
           Console.WriteLine("The element of C vector is :");
           for(i = 0; i < 12; i++)
           {
               Console.WriteLine(c[i]);
           }
           Console.WriteLine("The maxim vector of is c : {0}", c.Max());
           Console.WriteLine("The sum of even elements from vector a is :");

           int j = 0;
           Console.WriteLine(sum(ref j, ref a));

           Console.WriteLine("The product of the non-negative elements on the odd positions of the vector b");
           int k = 1;
           Console.WriteLine(prod(ref k, ref b));
        }
        static int sum(ref int j, ref int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            if(a[i] % 2 == 0)
            {
                j += a[i];
            }
            return j;
        }
        static int prod(ref int k, ref int[] b)
        {
        for(int i = 0; i < b.Length; i++)
        {
            if(i % 2 == 1)
            {
                k *= b[i];
            }
            return k;
        }
    }
}
}
