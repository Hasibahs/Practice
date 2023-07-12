using System;

namespace ternaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMater;

            /*
            if(temperature < 0) 
                stateOfMater = "Solid";
            else
                stateOfMater = "Liduid";

            Console.WriteLine("State of matter is {0}", stateOfMater); 
            */

            //in short:
            /*stateOfMater = temperature < 0 ? "Solid" : "Liquid"; */
            temperature += 110;
            stateOfMater = temperature > 100 ? "Gas": temperature < 0? "Solid" : "Liquid" ;

            Console.WriteLine("State of matter is {0}", stateOfMater);
            Console.ReadKey();
        }
    }
}
