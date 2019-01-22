using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here


            Console.WriteLine("enter a number to check even or odd");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("Value is even");

            }

            else if(a%2!=0)
            {
                Console.WriteLine("value is odd");
            }
            ConsoleKeyInfo  info = Console.ReadKey();
            Console.WriteLine(info);


            

        }
    }
}
