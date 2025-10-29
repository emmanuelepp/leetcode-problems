//O(n)
//O(1)

public class Solution
{
    public int ScoreOfString(string s)
    {
        if (s.Length == 0) return 0;

        int score = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            score += Math.Abs(s[i] - s[i + 1]);
        }

        return score;

    }
}