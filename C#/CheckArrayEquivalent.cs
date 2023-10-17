//O(N+M)
//O(1)
public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {

        if (word1.Length == 0 || word2.Length == 0) return false;

        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();

        foreach (var item in word1)
        {
            sb1.Append(item);
        }

        foreach (var item in word2)
        {
            sb2.Append(item);
        }

        return sb1.ToString() == sb2.ToString();
    }
}