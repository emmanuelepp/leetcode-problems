//O(n)
//O(n)
public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        if (s.Length == 0) return true;

        var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        foreach (var c in dict)
        {
            if (c.Value != dict[s[0]]) return false;
        }

        return true;
    }
}
