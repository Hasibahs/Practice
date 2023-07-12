using System;

namespace projectIfStatements
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register() 
        {
            Console.WriteLine("Please enter your user name");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your user pasword");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("----------------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your user name");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password");
                }
            }
            else
            {
                Console.WriteLine("wrong username.Restart program");
            }
            
        }

    }
}
