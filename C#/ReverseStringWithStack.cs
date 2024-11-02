//O(N)
//O(N)
public class Solution
{
    public string ReverseString(string s)
    {

        if (s.Length == 0) return "";

        var sb = new StringBuilder(s.Length);
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            stack.Push(c);
        }

        while (stack.Count > 0)
        {
            var c = stack.Pop();
            sb.Append(c);
        }

        return sb.ToString();
    }
}