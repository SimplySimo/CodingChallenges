using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace CodeChallenges.com.Strings.Easy
{
    public class StrongPassword
    {
        // Complete the minimumNumber function below.
        public static int minimumNumber(int n, string password)
        {//check via regex
            string special_characters = "!@#$%^&*()-+";

            int matched = 0;

            //lowercase check
            if (Regex.IsMatch(password, "(?=.*[a-z])"))
                matched++;
            //uppercase 
            if (Regex.IsMatch(password, "(?=.*[A-Z])"))
                matched++;
            //digit
            if (Regex.IsMatch(password, "(?=.*\\d)"))
                matched++;
            //special character
            if (special_characters.ToCharArray().Any(password.Contains))
                matched++;
            //length
            if (n >= 6)
                matched++;
            if (n <= 6)
                return 6-n;
            return 5 - matched;
        }
    }
}