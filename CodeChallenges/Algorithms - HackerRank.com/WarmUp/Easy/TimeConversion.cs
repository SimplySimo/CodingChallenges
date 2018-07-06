using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.

-Output Format

Convert and print the given time in -hour format, where .

-Sample Input 0

-07:05:45PM

-Sample Output 0

19:05:45

*/
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            return Convert.ToDateTime(s).ToString("HH:mm:ss");
        }
    }
}
