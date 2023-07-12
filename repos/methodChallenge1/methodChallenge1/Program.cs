using System;

namespace methodChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Michel";
            string friend3 = "Wlad";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();

        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
        }
    }
}
