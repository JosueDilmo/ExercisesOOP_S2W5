using ExercisesOOP_S2W5.Question1;
using System;

namespace ExercisesOOP_S2W5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises S2W5");
            Console.WriteLine("Question .1");
            Console.WriteLine("Question .2");
            Console.WriteLine("Question .3");
            Console.Write("Choose a question: ");
            int menuOpt = Convert.ToInt32(Console.ReadLine());
            switch (menuOpt)
            {
                case 1:
                    Console.Write("Please, introduce the number to be multiplied: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    MultiplicationTable table = new();
                    table.multiplicationTable(userNumber);
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
