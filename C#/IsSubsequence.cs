//O(N)
//O(1)
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;
        if (string.IsNullOrEmpty(t)) return false;

        int count = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (count < s.Length && s[count] == t[i])
                count++;
        }

        return count == s.Length;
    }
}