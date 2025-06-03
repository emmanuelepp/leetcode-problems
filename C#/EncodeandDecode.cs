//O(n)
//O(n)

// Use length#string encoding to avoid delimiter ambiguity.

public class Solution
{
    public string Encode(IList<string> strs)
    {
        var sb = new System.Text.StringBuilder();
        foreach (var str in strs)
            sb.Append(str.Length).Append('#').Append(str);
        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int j = s.IndexOf('#', i);
            int len = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, len));
            i = j + 1 + len;
        }
        return result;
    }
}
