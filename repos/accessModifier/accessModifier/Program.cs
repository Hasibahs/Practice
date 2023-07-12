using System;

namespace classesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.setName("myCar1");
            myCar.Details();
            car audi = new car("Audi A4 ", 400, "Blue");
            audi.Details();
            car bmw = new car("BMW m5", 350);
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {

                audi.Stop();
            }
            else
            {

                Console.WriteLine("Car drives undifinitely");
            }

        }


    }
}
