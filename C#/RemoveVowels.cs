public class Solution
{
    //O(n)
    //O(1)
    public string RemoveVowels(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";

        var result = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
            {
                result.Add(s[i].ToString());
            }
        }

        return string.Join("", result);
    }
}