using Console_Turtle_Race.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Turtle_Race.Services
{
    internal class TurtleServiceImpl : ITurtleService
    {
        public int GetNumberOfTurtles()
        {
            Console.WriteLine("Give number of turtles to race (2-10): ");
            int numberTurtles = 0;
            string input;
            do
            {
                input = Console.ReadLine();
                var inputValidationResult = NumberInputCheck(input);
                if (inputValidationResult is not null)
                    Console.WriteLine(inputValidationResult);

                int.TryParse(input, out numberTurtles);
            } while (numberTurtles < 2 || numberTurtles > 10);

            return numberTurtles;
        }

        private string? NumberInputCheck(string input)
        {
            int testINT;
            int.TryParse(input, out testINT);

            if (!int.TryParse(input, out testINT))
                return "NUMBER between 2 and 10";

            if (testINT < 2 || testINT > 10)
                return "Number beetween 2 and 10 is needed!";

            return null;
        }
    }
}
