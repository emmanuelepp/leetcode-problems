//O(n)
//O(n)
public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        if (words.Length == 0) return new List<int>() { };

        var result = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x)) result.Add(i);
        }

        return result;
    }
}