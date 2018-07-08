﻿using System.Linq;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{

    /*
Given an array of integers, find the sum of its elements.

-Input Format

The first line contains an integer, , denoting the size of the array.
The second line contains space-separated integers representing the array's elements.

-Output Format

Print the sum of the array's elements as a single integer.

-Sample Input

6
1 2 3 4 10 11

-Sample Output

31

-Explanation

We print the sum of the array's elements: 1 + 2 + 3 + 4 + 10 + 11 = 31.
*/
    public class SimpleArraySum
    {
        public static int simpleArraySum(int[] ar)
        {
            // Complete this function
            return ar.Sum();
        }
    }
}
