using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("it is sunny? {0}", !isSunny);

            //increment operator
            int num = 0;
            num++;

            
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num3 is {0}", num++);
            //pre increment
            Console.WriteLine("num3 is {0}", ++num);

            //decrement operator
            num--;

            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement
            Console.WriteLine("num is {0}", --num);

            //add operator

            int result;
            result = num1 + num2;
            Console.WriteLine( "Result  of num1 and num2 adding is {0}", result);

            //subtraction operator

            
            result = num1 - num2;
            Console.WriteLine("Result  of num1 and num2 subtraction is {0}", result);

            //multiplication operator
         
            result = num1 * num2;
            Console.WriteLine("Result  of num1 and num2 multiplication is {0}", result);

            //division operator

            result = num1 / num2;
            Console.WriteLine("Result  of num1 and num2 division is {0}", result);

            //modular operator

            result = num1 % num2;
            Console.WriteLine("Result  of num1 and num2 reminder is {0}", result);

            //relational and type operator
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result  of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result  of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result  of num1 != num2 is {0}", isEqual);

            //conditional operator 
            // condition 1 and condition 2 must be true for get true
            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result  of isLower && isSunny {0}", isLowerAndSunny);

            //condition 1 or condition 2, one of them need to be true.
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);


            Console.ReadKey();
        }
    }
}
