using System;

namespace tryCatchAndFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Can't divide by zero!");
            }

            

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                throw;
                //Console.WriteLine("Format exception! Please enter the correct type next time");
            }

            
        }
    }
}
