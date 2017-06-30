using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Attempts.Exercises
{
    public static class Bob
    {
        //http://exercism.io/exercises/csharp/bob/readme

        public static bool IsAllUpper(char[] input)
        {
            if (input.Length < 1)
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }

        public static string Response(string input)
        {
            string noSpaceInput = input.Replace(" ", "");

            // Ensure noSpaceInput is not null
            if (!string.IsNullOrWhiteSpace(noSpaceInput))
            {
                // Extract into array of characters
                char[] inputCharArray = noSpaceInput.ToCharArray();

                var cleanCharArray = noSpaceInput.Where(Char.IsLetter).ToArray();

                // Check for all caps
                // If all caps, return "Whoa, chill out!"
                if (IsAllUpper(cleanCharArray))
                {
                    return "Whoa, chill out!";
                }


                // Check last character for punctuation type
                if (inputCharArray[inputCharArray.Length - 1].ToString() == "?")
                {
                    return "Sure.";
                }

                return "Whatever.";
            }

            // If null, return "Fine. Be that way!"
            return "Fine. Be that way!";
        }
    }
}