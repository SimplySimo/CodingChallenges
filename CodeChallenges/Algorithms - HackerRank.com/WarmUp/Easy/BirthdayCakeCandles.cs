using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
You are in-charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age. When she blows out the candles, she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out.

For example, if your niece is turning 4 years old, and the cake will have 4 candles of height 3, 2, 1, 3, she will be able to blow out 2 candles successfully, since the tallest candle is of height 3 and there are 2 such candles.

Complete the function birthdayCakeCandles that takes your niece's age and an integer array containing height of each candle as input, and return the number of candles she can successfully blow out.

-Input Format

The first line contains a single integer, , denoting the number of candles on the cake.
The second line contains space-separated integers, where each integer describes the height of candle .

-Constraints

-Output Format

Print the number of candles that can be blown out on a new line.

-Sample Input 0

4
3 2 1 3

-Sample Output 0

2

*/
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            int tallest = ar.Max();
            int count = ar.Count(x => x == tallest);
            return count;
        }
    }
}
