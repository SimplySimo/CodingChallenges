﻿namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{

    /*
Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from to for three categories: problem clarity, originality, and difficulty.

We define the rating for Alice's challenge to be the triplet , and the rating for Bob's challenge to be the triplet .

Your task is to find their comparison points by comparing with , with , and with .

    If , then Alice is awarded point.
    If , then Bob is awarded point.
    If , then neither person receives a point.

Comparison points is the total points a person earned.

Given and , can you compare the two challenges and print their respective comparison points?

-Input Format

The first line contains space-separated integers, , , and , describing the respective values in triplet .
The second line contains space-separated integers, , , and , describing the respective values in triplet .

-Constraints
1<a[i]<100
1<b[i]<100

-Output Format

Return an array of two integers denoting the respective comparison points earned by Alice and Bob.

Sample Input 0

5 6 7
3 6 10

Sample Output 0

1 1

Explanation 0

In this example:

Now, let's compare each individual score:

    , so Alice receives point.
    , so nobody receives a point.
    , so Bob receives point.

Alice's comparison score is , and Bob's comparison score is . Thus, we print 1 1 (Alice's comparison score followed by Bob's comparison score) on a single line. 
*/
    public class CompareTheTriples
    {
        public static int[] solve(int[] a, int[] b)
        {
            int aPoints = 0;
            int bPoints = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                    aPoints++;
                else if (b[i] > a[i])
                    bPoints++;
            }
            return new int[] { aPoints, bPoints };
        }
    }
}
