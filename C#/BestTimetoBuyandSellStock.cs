//O(n)
//O(1)
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0 || prices.Length == 1) return 0;

        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }

            int posibleProfit = prices[i] - minPrice;

            if (posibleProfit > maxProfit)
            {
                maxProfit = posibleProfit;
            }
        }


        return maxProfit;
    }
}