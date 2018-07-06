using System.Linq;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

-Input Format

The first line of the input consists of an integer .
The next line contains space-separated integers contained in the array.

-Output Format

Print the integer sum of the elements in the array.

Constraints

-Sample Input

5
1000000001 1000000002 1000000003 1000000004 1000000005

-Output

5000000015
*/
    public class AVeryBigSum
    {
        public static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }
    }
}
