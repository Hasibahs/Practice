using System;

namespace breanAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int counter=0; counter<10;  counter++)
            {
                
                if(counter %2 == 1) 
                {
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}
