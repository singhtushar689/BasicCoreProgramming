using System;

namespace BasicCoreProgramming
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Power of 2 Program");
            Console.WriteLine("Enter the Power Of 2");
            int N =Convert.ToInt32(Console.ReadLine());
            if (N > 0 && N < 31)
            {
                for (int i = 1; i <= N; i++)
                {
                    double number = Math.Pow(2, i);
                    Console.WriteLine(number);
                }
            }
            
            else
            {
                Console.WriteLine("Invalid Number");
            }
             

            
         

        






        } 
    }
}