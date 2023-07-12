using System;

namespace tempCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int tempInt = int.Parse(temperature);

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
