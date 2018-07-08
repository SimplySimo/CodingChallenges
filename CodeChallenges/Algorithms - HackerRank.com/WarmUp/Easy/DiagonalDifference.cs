using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix is shown below:

1 2 3
4 5 6
9 8 9  

    Function description

Complete the function in the editor below. It must return an integer representing the absolute diagonal difference.

diagonalDifference takes the following parameter:

    arr: an array of integers .

Input Format

The first line contains a single integer, , the number of rows and columns in the matrix .
Each of the next lines describes a row, , and consists of space-separated integers .

-Output Format

Print the absolute difference between the sums of the matrix's two diagonals as a single integer.

-Sample Input

3
11 2 4
4 5 6
10 8 -12

-Sample Output

15

-Explanation

The primary diagonal is:

11
   5
     -12

Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

     4
   5
10

Sum across the secondary diagonal: 4 + 5 + 10 = 19
Difference: |4 - 19| = 15

Note: |x| is the absolute value of x
*/
    public class DiagonalDifference
    {
        public static int diagonalDifference(int[][] arr)
        {
            int primDig = 0;
            int secDig = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                primDig += arr[i][i];
                secDig += arr[i][arr.Length - 1 - i];
            }
            return secDig - primDig;
        }

    }
}
