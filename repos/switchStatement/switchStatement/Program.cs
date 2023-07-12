using System;

namespace switchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            string inputAge = Console.ReadLine();
            int age = int.Parse(inputAge);
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young for the party");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            if(age == 15)
            {
                Console.WriteLine("Too young to party");
            }
            else if(age == 25)
            {
                Console.WriteLine("Good to go");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Hasib";

            switch (username)
            {
                case "Hasib":
                    Console.WriteLine("username is Hasib");
                    break;
                case "root":
                    Console.WriteLine("username is Root");
                    break;
                default:
                    Console.WriteLine("user name is unknown");
                    break;
            }
            


            Console.Read();
        }
    }
}
