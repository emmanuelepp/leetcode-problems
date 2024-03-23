//O(n)
//O(1)
public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        if (hours.Length == 0) return -1;

        var count = 0;

        for (int i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target)
            {
                count++;
            }
        }

        return count;
    }
}