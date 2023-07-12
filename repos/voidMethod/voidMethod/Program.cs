using System;

namespace voidMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am argument and I am called  from a method");
            Console.Read();
        }

        //access modifier (static) return type method name (pararmeter 1, parameter 2)
        public static void WriteSomething() 
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText) 
        {
            Console.WriteLine(myText);
        }
    }
}
