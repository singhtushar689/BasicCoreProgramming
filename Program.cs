using System;

namespace BasicCoreProgramming
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Harmonic Number Program");
            Console.WriteLine("Enter the Value of N");
            int N =Convert.ToInt32(Console.ReadLine());
            double Sum = 0;
            if (N > 0 )
            {
                for (double i = 1; i <= N; i++)
                {
                    double HarmonicNumber = (1 / i);
                    Sum += HarmonicNumber;
                    Console.WriteLine("The Harmonic Number is " + HarmonicNumber.ToString());
                }
                Console.WriteLine("The Sum of Harmonic Number is " + Sum);
            }
            
            else
            {
                Console.WriteLine("Invalid Entry");
            }
             

            
         

        






        } 
    }
}