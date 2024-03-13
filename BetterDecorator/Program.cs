using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Receives a string s , a char dec , and an int t, and arranges the char t times on the right and left of the string s
        /// </summary>
        /// <param name="s">The unique string s that the return will highlight</param>
        /// <param name="dec"> the character to put on the right and left of the string</param>
        /// <param name="t"> the number of times that the char dec will be put on each side of the string</param>
        /// <returns>A final string with the specified number t of char dec on each side of the string</returns>
        private static string Decor(string s, char dec, int t)
        {
            string finalString = "";
            for (int i = 1;  i <= 2; i += 1)
            {
                for (int e = 0;  e < t; e += 1)
                {
                    finalString += $"{dec}";
                }
                if (i == 1)
                {
                    finalString += " " + s + " ";
                }
            }
            return finalString;
        }
        /// <summary>
        /// This is the decor in case the user does not specify arguments
        /// </summary>
        /// <returns>returns the result of a Decor with 3 arguments that says "User did not specify args"</returns>
        private static string Decor()
        {
            return Decor("User did not specify args !", Convert.ToChar("="), 3);
        }

        /// <summary> 
        /// This main receives the arguments from the dotnet run command, checks if there are more than 0, and then gives them to a string, char, int variables. and then gives it to the Decor function in WriteLine.
        /// </summary>
        /// <param name="args">Should receive: a string, a char, an int</param>
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                string line = args[0];
                char charToRepeat = Convert.ToChar(args[1]);
                int howMany = Convert.ToInt32(args[2]);
                Console.WriteLine(Decor(line, charToRepeat, howMany));
            }
            else
            {
            Console.WriteLine(Decor());
            }
        }
    }
}
