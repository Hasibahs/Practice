using System;

namespace doWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int counter = 0;
            int lengthOfText = 0;
            string wholeText = "";

            do
            {

                Console.WriteLine("Please enter the name of  a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
               // Console.WriteLine(counter);
               // counter++;
            }
            while (lengthOfText < 20);
            Console.WriteLine("Thanks, it was enough" + wholeText);
            Console.Read();
        }
    }
}
