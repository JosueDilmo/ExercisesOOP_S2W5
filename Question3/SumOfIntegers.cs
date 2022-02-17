using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W5.Question3
{
    public class SumOfIntegers
    {

        public static void Sum(params int [] sumArray)
        {
            Console.WriteLine(sumArray.Sum());
        }
    }
}
