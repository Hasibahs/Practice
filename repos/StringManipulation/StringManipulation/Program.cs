using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Tom";

            int age1 = 25;
            string name1 = "John";
            string city = "Emmen";

            //1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            //2. String formatting
            //string formatting uses index
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old", name, age);

            //practice format indexing
            Console.WriteLine("String formatting prcatice");
            Console.WriteLine("Hello my name is {0} , I am {1} years old, and I live in {2}", name1, age1, city );

            //3. String interpolation
            //string interpolation uses $ at the start which will allow use to write our
            //variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old", name, age);

            //4. Verbatim strings.
            //verbatim strings starts with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"I am
            Hasib");


        }
    }
}
