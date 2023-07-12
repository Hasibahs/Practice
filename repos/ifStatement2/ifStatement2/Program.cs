using System;

namespace ifStatement2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Denis";
        static void Main(string[] args)
        {
            checkHighscore(250, "Maria");
            checkHighscore(315, "Michel");
            checkHighscore(350, "Denis");

            Console.Read();
        }

        public static void checkHighscore(int score, string playerName) 
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else 
            {
                Console.WriteLine("The old highscore could not be  broken. It is still " + highscore + "and held by "+ highscorePlayer);

            }
        }
    }
}
