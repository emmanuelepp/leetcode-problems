
using System.Text;
//O(n)
//O(n)
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;

        var cleanedString = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
                cleanedString.Append(char.ToLower(c));
        }

        string cleaned = cleanedString.ToString();

        int L = 0, R = cleaned.Length - 1;

        while (L < R)
        {
            if (cleaned[L] == cleaned[R])
            {
                L++;
                R--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
