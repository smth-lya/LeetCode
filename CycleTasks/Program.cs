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
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            for (int k = 0; k <= n / 2; k++)
            {
                for (int g = k; g < n - k - 1; g++)
                {
                    int curX = g,
                        curY = k;

                    int newX = curX,
                        newY = curY;

                    int offsetX = g - k,
                        offsetY = n - 2 * k - 1 - offsetX;

                    // make backup

                    int backupCurXY = matrix[curY][curX];

                    // 1 loop

                    newX -= offsetX;
                    newY += offsetY;

                    matrix[curY][curX] = matrix[newY][newX];

                    curX = newX;
                    curY = newY;


                    // 2 loop

                    newX += offsetY;
                    newY += offsetX;

                    matrix[curY][curX] = matrix[newY][newX];

                    curX = newX;
                    curY = newY;


                    // 3 loop

                    newX += offsetX;
                    newY -= offsetY;

                    matrix[curY][curX] = matrix[newY][newX];

                    curX = newX;
                    curY = newY;


                    // 4 loop

                    matrix[curY][curX] = backupCurXY;

                }
            }
        }
      
    }
}