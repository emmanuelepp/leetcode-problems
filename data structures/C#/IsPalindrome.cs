//O(n)
//O(n)
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;

        var cleanString = new StringBuilder();

        foreach (char item in s)
        {
            if (char.IsLetterOrDigit(item))
                cleanString.Append(char.ToLower(item));
        }

        var cleaned = cleanString.ToString();

        int L = 0, R = cleaned.Length - 1;

        while (L < R)
        {
            if (cleaned[L] != cleaned[R]) return false;
            L++;
            R--;
        }

        return true;
    }
}