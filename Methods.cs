using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsExercise2._0
{
    public class Methods
    {
    
        public static void PrintRangeHighToLow(double ceiling, double floor)
        {
            for(double i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }

        
        }
    
    }
}
