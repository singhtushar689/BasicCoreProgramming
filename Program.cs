using System;

namespace BasicCoreProgramming
{
    internal class Program
    {
         

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Flip Coin Problem");
            int Head = 0;
            int Tails = 0;
            int Coin = 0;
            const int MaxFlip = 10;
            double HeadPercentage = 0;
            double TailsPercentage = 0;
           
           

            for (Coin = 1; Coin <= 10 ;Coin ++ )
            {
                Random random = new Random();
                 int CoinCheck = random.Next(0, 2);

                if (CoinCheck <= 0.5)
                {
                    Console.WriteLine("Head");
                    Head++;
                }
                else
                {
                    Console.WriteLine("Tail");
                    Tails++;
                }
            }
            Console.WriteLine("{0} out of {1} " ,Head,10);
            Console.WriteLine("{0} out of {1} " ,Tails,10);

            HeadPercentage = ((Head *100)/ MaxFlip);
            Console.WriteLine("Head Percentage is {0}% ", HeadPercentage);
            
            TailsPercentage = ((Tails * 100) / MaxFlip);
            Console.WriteLine( "TailsPercentage is {0}% ",TailsPercentage);



        }
    }
}