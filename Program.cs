using System;

namespace BasicCoreProgramming
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Quotient and Remainder Program");
            Console.WriteLine("Enter the Value of Dividend");
            int Dividend =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            long Calculation = Math.DivRem(Dividend, Divisor , out long result);
            Console.WriteLine("Quotient is" + Calculation);
            Console.WriteLine("Remainder is" + result);
            
        } 
    }
}