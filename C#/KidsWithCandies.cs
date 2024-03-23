//O(n)
//O(n)
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        if (candies.Length == 0) return new List<bool> { };

        var result = new List<bool>();
        var maxCandies = 0;

        // If your interviewer allows you, you can eliminate a loop and directly use the MAX() function
        // var maxCandies = candies.Max(); 

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > maxCandies)
                maxCandies = candies[i];
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if ((candies[i] + extraCandies) >= maxCandies)
                result.Add(true);
            else
                result.Add(false);
        }

        return result;
    }
}