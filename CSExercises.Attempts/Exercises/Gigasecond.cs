using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Attempts.Exercises
{
    //http://exercism.io/exercises/csharp/gigasecond/readme
    //Calculate the moment when someone has lived for 10^9 seconds.
    //A gigasecond is 10^9 (1,000,000,000) seconds.
    public static class Gigasecond
    {

        public static DateTime Date(DateTime dateTime)
        {
            return dateTime.AddSeconds(1000000000);
        }
    }
}