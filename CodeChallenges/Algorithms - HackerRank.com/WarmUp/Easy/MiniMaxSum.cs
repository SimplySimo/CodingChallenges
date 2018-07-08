using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

-Input Format

A single line of five space-separated integers.

-Constraints

    Each integer is in the inclusive range .

-Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

-Sample Input

1 2 3 4 5

-Sample Output

10 14
*/
    public class MiniMaxSum
    {
        public static long[] miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long max = arr.Where((item, index) => index != 0).ToArray().Sum(x => (long)x);
            long min = arr.Where((item, index) => index != arr.Length - 1).ToArray().Sum(x => (long)x);

            Console.WriteLine(min + " " + max);
            return new[] { min, max };

        }
    }
}
