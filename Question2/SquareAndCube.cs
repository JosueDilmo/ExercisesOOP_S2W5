using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W5.Question2
{
    public class SquareAndCube
    {
        public void cube(double cubeNumber)
        {
            double resultCubed = Math.Pow(cubeNumber, 3);
            Console.WriteLine($"By the power of 3: {resultCubed}");
            square(cubeNumber);
        }
        public void square(double squareNumber)
        {
            double resultSquared = Math.Pow(squareNumber, 2);
            Console.WriteLine($"By the power of 2: {resultSquared}");
        }
    }
}
