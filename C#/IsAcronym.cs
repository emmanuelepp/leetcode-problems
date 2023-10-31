//O(n)
//O(n)
public class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {

        var word = new StringBuilder();

        foreach (var item in words)
        {
            word.Append(item[0]);
        }

        return word.ToString() == s;
    }
}