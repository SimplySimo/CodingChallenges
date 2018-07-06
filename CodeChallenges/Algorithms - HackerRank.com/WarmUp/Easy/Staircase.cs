using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy
{
    /*
     Consider a staircase of size :

   #
  ##
 ###
####

Observe that its base and height are both equal to , and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .

-Input Format

A single integer, , denoting the size of the staircase.

-Output Format

Print a staircase of size using # symbols and spaces.

Note: The last line must have spaces in it.

-Sample Input

6 

-Sample Output

     #
    ##
   ###
  ####
 #####
######

-Explanation

The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of n=6
*/
    public class Staircase
    {
        //added return type to unit test
        public static List<string> staircase(int n)
        {
            List<string> results = new List<string>();
            string line = "";
            for (int i = 0; i < n; i++) {
                line = new String('#', i + 1).PadLeft(n, ' ');
                Console.WriteLine(line);
                results.Add(line);
            }
            return results;
        }
    }
}
