//O(n)
//O(n)
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {

        var dictRansomNote = new Dictionary<char, int>();

        foreach (var s in ransomNote)
        {
            if (dictRansomNote.ContainsKey(s))
                dictRansomNote[s]++;
            else
                dictRansomNote[s] = 1;
        }

        foreach (var s in magazine)
        {
            if (dictRansomNote.ContainsKey(s) && dictRansomNote[s] > 0)
                dictRansomNote[s]--;
        }

        foreach (var pair in dictRansomNote)
        {
            if (pair.Value > 0)
                return false;
        }

        return true;
    }
}
