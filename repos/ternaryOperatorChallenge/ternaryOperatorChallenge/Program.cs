using System;

namespace ternaryOperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            //take input from  user
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            //validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if(validInteger )
            {
                //if is valid integer then it will check for the conditions using 
                temperatureMessage = inputTemperature <= 15 ? "It is too cold here" :

                    (inputTemperature >= 16 && inputTemperature <= 28) ? "it is cold here" :
                    inputTemperature > 28 ? "It is hot here" : " ";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                //in case if the input value is not a valid temperature
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();
        }
    }
}
