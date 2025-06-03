//O(n*k)
//O(n*k)

public class Solution
{

    public List<List<string>> GroupAnagrams(string[] strs)
    {

        if (strs.Length == 0) return new List<List<string>>();

        var dict = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var freq = new int[26];

            foreach (char c in word) freq[c - 'a']++;

            var key = string.Join(",", freq);

            if (!dict.ContainsKey(key)) dict[key] = new List<string>();

            dict[key].Add(word);
        }

        return dict.Values.ToList();

    }
}

