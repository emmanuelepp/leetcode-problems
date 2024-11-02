//O(n + m)
//O(n + m)
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        if (word1 == null || word2 == null) return "";

        var result = new StringBuilder();

        int L = 0, R = 0;

        while (L < word1.Length && R < word2.Length)
        {
            result.Append(word1[L]).Append(word2[R]);
            L++;
            R++;
        }

        while (L < word1.Length)
        {
            result.Append(word1[L]);
            L++;
        }

        while (R < word2.Length)
        {
            result.Append(word2[R]);
            R++;
        }

        return result.ToString();
    }
}