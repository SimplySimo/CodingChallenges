using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Medium
{
    /*
An English text needs to be encrypted using the following encryption scheme.
First, the spaces are removed from the text. Let be the length of this text.
Then, characters are written into a grid, whose rows and columns have the following constraints:

For example, the sentence if man was meant to stay on the ground god would have given us roots after removing spaces is characters long. is between and , so it is written in the form of a grid with 7 rows and 8 columns.

ifmanwas  
meanttos          
tayonthe  
groundgo  
dwouldha  
vegivenu  
sroots

    Ensure that
    If multiple grids satisfy the above conditions, choose the one with the minimum area, i.e. .

The encoded message is obtained by displaying the characters in a column, inserting a space, and then displaying the next column and inserting a space, and so on. For example, the encoded message for the above rectangle is:

imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau

You will be given a message to encode and print.

-Input Format

One line of text, the string

-Constraints


is comprised only of characteres in the range ascii[a-z].

-Output Format

Print the encoded message on one line as described.

-Sample Input

haveaniceday

-Sample Output:

hae and via ecy

, is between and Rewritten with rows and columns:

have
anic
eday

-Sample Input 1:

feedthedog    

-Sample Output 1:

fto ehg ee dd

-Sample Input 2:

chillout

-Sample Output 2:

clu hlt io
*/
    public class Encryption
    {
        public static string encryption(string s)
        {
            int column = (int)Math.Ceiling(Math.Sqrt(s.Length));
            string answer = "";


            for (int i = 0; i < column; i++)
            {
                int j = 0;
                while (i + j < s.Length)
                {
                    answer = answer + s.Substring(i + j, 1);
                    j = j + column;
                }
                answer = answer + " ";
            }
            return answer.TrimEnd();
        }
    }
}
