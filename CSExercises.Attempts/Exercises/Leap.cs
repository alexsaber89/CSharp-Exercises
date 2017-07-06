using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Attempts.Exercises
{
    public static class Leap
    {
        //http://exercism.io/exercises/csharp/leap/readme

        public static bool IsLeapYear(int year)
        {
            //on every year that is evenly divisible by 4
            if (year % 4 == 0)
            {
                //except every year that is evenly divisible by 100
                //unless the year is also evenly divisible by 400
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }

                return true;
            }
            return false;
        }
    }
}
