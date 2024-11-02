//O(N)
//O(1)
public class Solution
{
    public int CalculateTime(string keyboard, string word)
    {

        if (string.IsNullOrEmpty(keyboard) || string.IsNullOrEmpty(word)) return -1;

        var count = 0;

        var dict = new Dictionary<char, int>();

        for (int i = 0; i < keyboard.Length; i++)
        {
            dict.Add(keyboard[i], i);
        }

        int currentIndex = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (dict.ContainsKey(word[i]))
            {

                int targetIndex = dict[word[i]];
                count += Math.Abs(currentIndex - targetIndex);
                currentIndex = targetIndex;
            }
        }

        return count;
    }
}
