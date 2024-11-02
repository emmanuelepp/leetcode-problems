//O(nlogn)
//O(1)
public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        if (prices.Length < 2 || money <= 0) return money;

        Array.Sort(prices);

        int firstChocoIndex = 0;
        int secondChocoIndex = 1;

        if (money >= prices[firstChocoIndex] + prices[secondChocoIndex])
            return money - (prices[firstChocoIndex] + prices[secondChocoIndex]);
        else
            return money;
    }
}