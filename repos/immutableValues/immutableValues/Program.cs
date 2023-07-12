using System;

namespace immutableValues
{
    //Constants are immutable values which are known
    // at compile time and do not change for the life of the program.
    internal class Program
    {
        // fields outside method.
        //constants as fields.
        const double PI = 3.14159265359;
        const int weeks = 52, month = 12;
        const int days = 365;
        const string myDob = "25.12.2001";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", myDob);
            Console.ReadKey();

        }
    }
}
