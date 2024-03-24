//O(n)
//O(n)
public class Solution
{
    public string ReverseWords(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        var sb = new StringBuilder(s.Length);
        var stack = new Stack<string>();
        var words = s.Split(' ');

        foreach (var word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
                stack.Push(word);
        }

        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
            if (stack.Count > 0)
                sb.Append(' ');
        }

        return sb.ToString();
    }
}