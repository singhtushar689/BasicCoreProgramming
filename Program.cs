using System;

namespace BasicCoreProgramming
{
    internal class Program
    {
         

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Leap Year Program");
            Console.WriteLine("Enter the Four -Digit Year");
            double Year = Convert.ToInt32(Console.ReadLine());
            if (Year > 999)
            {
                if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                {
                    Console.WriteLine("It is a leap year");
                }
                else
                {
                    Console.WriteLine("It is not a leap Year");
                }
            }
            else
                Console.WriteLine("Invalid Entry");
    



        }
    }
}