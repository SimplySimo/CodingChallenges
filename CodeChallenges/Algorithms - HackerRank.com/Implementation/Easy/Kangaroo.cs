namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy
{
    /*
You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).

    The first kangaroo starts at location and moves at a rate of meters per jump.
    The second kangaroo starts at location and moves at a rate of meters per jump.

You have to figure out a way to get both kangaroos at the same location as part of the show.

Complete the function kangaroo which takes starting location and speed of both kangaroos as input, and return or appropriately. Can you determine if the kangaroos will ever land at the same location at the same time? The two kangaroos must land at the same location after making the same number of jumps.

-Input Format

A single line of four space-separated integers denoting the respective values of x1, v1,x2 ,v2.

-Output Format

Print YES if they can land on the same location at the same time; otherwise, print NO.

Note: The two kangaroos must land at the same location after making the same number of jumps.
*/

    public class Kangaroo
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int dx = x1 - x2;
            int dv = v2 - v1;

            if (dv == 0)
                return "NO";
            if (dx % dv == 0 && (dx / dv > 0))
            {
                return "YES";
            }
            return "NO";
        }
    }
}