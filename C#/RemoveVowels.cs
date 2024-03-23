
//O(n)
//O(1)
public class Solution
{
    public string RemoveVowels(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";

        var result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
            {
                result += s[i];
            }
        }

        return result;
    }
}