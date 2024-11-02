//O(n)
//O(1)
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        if (s == null && t == null) return '0';

        var result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            result ^= s[i];
        }

        for (int i = 0; i < t.Length; i++)
        {
            result ^= t[i];
        }

        return (char)result;
    }
}