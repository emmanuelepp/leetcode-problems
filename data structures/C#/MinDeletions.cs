//O(n)
//O(n)
public class Solution
{
    public int MinDeletions(string s)
    {

        if (string.IsNullOrEmpty(s)) return 0;

        var frequences = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (frequences.ContainsKey(s[i]))
            {
                frequences[s[i]]++;
            }
            else
            {
                frequences[s[i]] = 1;
            }
        }

        var uniqueFrequencies = new HashSet<int>();
        int deletions = 0;

        foreach (var freq in frequences.Values)
        {
            int currentFreq = freq;
            while (currentFreq > 0 && !uniqueFrequencies.Add(currentFreq))
            {
                currentFreq--;
                deletions++;
            }
        }

        return deletions;
    }
}
