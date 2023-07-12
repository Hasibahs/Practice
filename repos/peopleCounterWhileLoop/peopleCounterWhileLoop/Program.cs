using System;

namespace peopleCounterWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals("")) 
            {
                Console.WriteLine("Please press enter to increase amount by 1 and anything else + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
                
            }
            Console.WriteLine("People are in the bus {0}", counter);
            Console.Read();
        }
    }
}
