using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //implicit conversion

            int num = 1234555553;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            // explicit conversion
            //cast double into int;

            double myDouble = 13.37;
            int myInt;
            //boolean data types

            bool myBool = true;

            //typeConversion
            string myString =myDouble.ToString();
            num.ToString();

            string myFloatString = myFloat.ToString();

            string myBoolString = myBool.ToString();

            
            
            myInt = (int)myDouble;
            Console.WriteLine(myBoolString);
        }
    }
}
