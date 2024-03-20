//O(n)
//O(1)
public class Solution
{
    public bool IsValid(string s)
    {

        if (s.Length == 0) return false;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(') stack.Push(')');
            else if (c == '{') stack.Push('}');
            else if (c == '[') stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c) return false;
        }

        return stack.Count == 0;
    }
}