using System;
using System.Reflection.Metadata;

namespace methodWithInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Divide(25, 20));
            Console.Read();
        }
        public static int Add(int num1, int  num2) 
        {
            return num1 + num2;
        }

        public static int mul(int num3, int num4) 
        {
            return num3 * num4;
        }

        public static double Divide(double num1, double num2) 
        {
            return num1 / num2;
        }
    }
}
