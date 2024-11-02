//O(n)
//O(n)
public class Solution
{
    public char RepeatedCharacter(string s)
    {

        if (string.IsNullOrEmpty(s)) return '0';

        var charLetter = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (charLetter.ContainsKey(s[i]))

                charLetter[s[i]]++;
            else
                charLetter[s[i]] = 1;

            if (charLetter[s[i]] == 2) return s[i];
        }

        return '0';
    }
}