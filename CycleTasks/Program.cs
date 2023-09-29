using System;

namespace Tasks.Cycle
{
    public class Program
    {
        public static int RomanToInt(string s)
        {
            int numInt = 0;

            int curLetterInt = 0, prevLetterInt = 0;

            foreach (char letter in s)
            {
                curLetterInt = letter switch
                {
                    'M' => 1000,
                    'D' => 500,
                    'C' => 100,
                    'L' => 50,
                    'X' => 10,
                    'V' => 5,
                    'I' => 1,
                    _ => 0,
                };

                numInt += curLetterInt > prevLetterInt ? (-prevLetterInt) + (curLetterInt - prevLetterInt) : +curLetterInt;

                prevLetterInt = curLetterInt;
            }
            return numInt;
        }
    }
}