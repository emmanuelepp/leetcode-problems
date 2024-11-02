//O(n)
//(1)
public class Solution
{
    public int RomanToInt(string s)
    {

        if (s.Length == 0) return 0;

        var number = 0;
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        for (int i = 0; i < s.Length; i++)
        {
            var current = dict[s[i]];
            var next = (i + 1 < s.Length) ? dict[s[i + 1]] : 0;

            if (current < next)
                number -= current;
            else
                number += current;
        }

        return number;
    }
}
