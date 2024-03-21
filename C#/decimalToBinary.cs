//O(log(n))
//O(log(n))

public class Solution
{
    public string decimalToBinary(int num)
    {
        if (num == 0) return "";

        var stack = new Stack<int>();
        var sb = new StringBuilder();

        while (num > 0)
        {
            stack.Push(num % 2);
            num = num / 2;
        }

        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        return sb.ToString();
    }
}