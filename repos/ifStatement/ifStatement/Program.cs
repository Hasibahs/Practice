using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 11;

            if(temperature < 10 )
            {
                Console.WriteLine("Take the coat");
            }
            if(temperature == 10 )
            {
                Console.WriteLine("It's 10 degree C°");
            }

            if(temperature > 10) 
            {
                Console.WriteLine("It's warm and cozy");
            }

            Console.Read();
        }
    }
}
