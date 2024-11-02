// O(N)
// O(1)
public class Solution
{
    public bool DetectCapitalUse(string word)
    {

        if (word.Length == 0) return false;
        int countUpper = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] >= 65 && word[i] <= 90) { countUpper++; }
        }

        if (countUpper == word.Length) return true;
        if (countUpper == 0) return true;
        if (countUpper == 1 && word[0] >= 65 && word[0] <= 90) return true;

        return false;
    }
}