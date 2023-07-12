using System;

namespace forLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //odd numbers till 20
           for(int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            }
           Console.Read();
        }
    }
}
