using System;

namespace BetterDecorator
{
    class Program
    {
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
        static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], Convert.ToChar(args[1]), Convert.ToInt32(args[2])));
        }
    }
}
