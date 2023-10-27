//O(n)
//O(n)
public class Solution
{
    public string Interpret(string command)
    {
        if (string.IsNullOrEmpty(command)) return string.Empty;

        var sb = new StringBuilder();
        var result = string.Empty;

        command = command.Replace("()", "o");

        foreach (char c in command)
        {
            if (char.IsLetter(c))
                sb.Append(c);
        }

        result = sb.ToString();

        return result;

    }
}
