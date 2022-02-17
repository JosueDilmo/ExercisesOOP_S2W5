using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W5.Question1
{
   public class MultiplicationTable
    {
        public void multiplicationTable(int userNumber)
        {
            for (int i = 2; i <= 10; i++)
            {
                int resultNumber = i * userNumber;
                Console.WriteLine($"Multiplication result: {resultNumber}");
            }
        }
    }
}
