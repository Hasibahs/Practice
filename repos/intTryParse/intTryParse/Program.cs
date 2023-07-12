using System;

namespace intTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int tempInt;
            int number;

            if(int.TryParse(temperature, out number)) 
            {
                tempInt = number;
            }
            else
            {
                tempInt = 0;
                Console.WriteLine("Value is not correct");

            }
      

            if (tempInt < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if (tempInt == 20)
            {
                Console.WriteLine("Pants and pull over");
            }
            else
            {
                Console.WriteLine("shorts are enough");
            }

            Console.Read();
        }
    }
}
