using System;
using System.Linq;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
     *Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

-Input Format

The first line contains an integer, , denoting the size of the array.
The second line contains space-separated integers describing an array of numbers .

-Output Format

You must print the following lines:

    A decimal representing of the fraction of positive numbers in the array compared to its size.
    A decimal representing of the fraction of negative numbers in the array compared to its size.
    A decimal representing of the fraction of zeros in the array compared to its size.

-Sample Input

6
-4 3 -9 0 4 1         

-Sample Output

0.500000
0.333333
0.166667
*/
    public class PlusMinus
    {
        public static double[] plusMinus(int[] arr)
        {
            double posCount = 0;
            double negCount = 0;
            double zeroCount = 0;
            double bottom = arr.Count();
            foreach (int a in arr)
            {
                if (a < 0)
                    negCount++;
                else if (a > 0)
                    posCount++;
                else
                    zeroCount++;
            }

            Console.WriteLine(Math.Round(posCount / bottom, 6));
            Console.WriteLine(Math.Round(negCount / bottom, 6));
            Console.WriteLine(Math.Round(zeroCount / bottom, 6));

            //included to allow for unitTesting
            return new[] { Math.Round(posCount / bottom, 6), Math.Round(negCount / bottom, 6), Math.Round(zeroCount / bottom, 6)};
        }
    }
}
