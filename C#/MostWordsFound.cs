//O(N)
//O(1)
public class Solution
{
    public int MostWordsFound(string[] sentences)
    {

        var maxWord = 0;

        foreach (var item in sentences)
        {
            int currentWordCount = item.Split(' ').Length;

            if (currentWordCount > maxWord)
            {
                maxWord = currentWordCount;
            }
        }

        return maxWord;
    }
}