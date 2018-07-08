namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy
{
    /*
     * You have been asked to help study the population of birds migrating across the continent. Each type of bird you are interested in will be identified by an integer value. Each time a particular kind of bird is spotted, its id number will be added to your array of sightings. You would like to be able to find out which type of bird is most common given a list of sightings. Your task is to print the type number of that bird and if two or more types of birds are equally common, choose the type with the smallest ID number.

-Input Format

The first line contains an integer denoting , the number of birds sighted and reported in the array .
The second line describes as space-separated integers representing the type numbers of each bird sighted.

-Constraints

    It is guaranteed that each type is 1 - 5 .

-Output Format

Print the type number of the most common bird; if two or more types of birds are equally common, choose the type with the smallest ID number.

-Sample Input 0

6
1 4 4 4 5 3

-Sample Output 0

4
*/

    public class MigratoryBirds
    {
        public static int migratoryBirds(int[] ar)
        {
            int maxCount = 0;
            int maxType = 0;

            for (int i = 1; i < 6; i++)
            {
                var count = 0;
                for (int j = 0; j <= ar.Length - 1; j++)
                {
                    if (ar[j] == i)
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxType = i;
                }
            }
            return maxType;
        }
    }
}
