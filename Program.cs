using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0,100);
            bool sal = false;
            while(!sal)
            {
                sal = true;
                Console.WriteLine("Guess the number");
                int z = int.Parse(Console.ReadLine());
                sal = false;
                if(z > a)
                {
                    Console.WriteLine("Write a smaller number :");
                }

                if(z < a)
                {
                    Console.WriteLine("Write a greater number:");
                }

                if(z == a)
                {
                    Console.WriteLine("Congratulations ! you guessed the number :D");
                    break;
                }
            }
        }
    }
}
