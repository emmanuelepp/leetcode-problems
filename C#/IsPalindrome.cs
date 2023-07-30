using System.Text.RegularExpressions;

//O(n)
//O(n)
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s == null || string.IsNullOrEmpty(s)) return false;
        var regex = new Regex("[^a-zA-Z0-9]");
        s = regex.Replace(s.ToLower(), "");
        int L = 0, R = s.Length - 1;
        
        while (L < R)
        {
            if (s[L] == s[R])
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