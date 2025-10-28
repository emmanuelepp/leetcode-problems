//O(1)
//O(n)

public class Solution
{
    public int LateFee(int[] daysLate)
    {

        if (daysLate.Length == 0) return -1;

        int penalty = 0;

        foreach (var day in daysLate)
        {
            penalty += day switch { <= 0 => 0, 1 => 1, >= 2 and <= 5 => 2 * day, _ => 3 * day };
        }

        return penalty;
    }
}