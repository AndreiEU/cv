using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b, rez = 0;
            char op;
            short ok = 1;
            Console.Write("First number :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second number :");
            b = int.Parse(Console.ReadLine());

            Console.Write("Desired operation:");
            op = char.Parse(Console.ReadLine());
            switch(op)
            {
                case '+': rez = a + b; break;
                case '-': rez = a - b; break;
                case '*': rez = a * b; break;
                case '/': 

                     if(b != 0) rez = a / b;
                     else
                     {
                         Console.WriteLine("Division with 0 is impossible!!");
                         Console.ReadKey();
                         return;
                     }
                     break;
                     default : ok = 0; break;
            }
            if(ok == 1)
               Console.WriteLine("{0} {1} {2} = {3}", a, op, b, rez);
            else
               Console.WriteLine("The operator is invalid");
               Console.ReadLine();
        }
    }
}
