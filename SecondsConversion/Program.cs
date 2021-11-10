using System;

namespace SecondsConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           int sec, h,m,s;
           Console.Write("Number of seconds is : ");
           sec = int.Parse(Console.ReadLine());
           m = sec / 60;
           s = sec % 60;
           h = m / 60;
           m = m % 60;
           Console.WriteLine("");
           Console.WriteLine("{0} seconds", sec);
           Console.WriteLine("");
           Console.Write("Represent {0} hours, {1} minutes and {2} seconds", h,m,s);
           Console.ReadLine();
        }
    }
}
