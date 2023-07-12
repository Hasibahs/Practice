using System;

namespace solutionForLoopChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1") 
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you have ready to calculate the average");

                input = Console.ReadLine();
                if(input.Equals("-1"))
                {
                    Console.WriteLine("-----------------------------------------");
                    //calculate average and let the teacher now

                }
                if(int.TryParse(input, out currentNumber) && currentNumber >0 && currentNumber <21) 
                {
                    total = total + currentNumber;
                }
            }
        }
    }
}
