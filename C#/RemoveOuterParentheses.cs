//O(n)
//O(1)
public class Solution
{
    public string RemoveOuterParentheses(string s)
    {

        if (string.IsNullOrEmpty(s)) return string.Empty;

        var sb = new StringBuilder();
        var count = 0;

        foreach (char c in s)
        {
            if (c == '(' && count++ > 0)
            {
                sb.Append(c);
            }

            if (c == ')' && count-- > 1)
                sb.Append(c);
        }

        return sb.ToString();
    }
}