using System.Linq;

namespace CodeChallenges.com.Strings.Easy
{
    public class CamelCase
    {
        public static int camelcase(string s)
        {
            char[] array = s.ToCharArray();

            return 1 + array.Count(letter => char.IsUpper(letter));
        }
    }
}