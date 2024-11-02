//O(n)
//O(n)
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {

        if (numbers == null || numbers.Length <= 0) return new int[] { };
        int L = 0, R = numbers.Length - 1;

        while (L < R)
        {
            if (numbers[L] + numbers[R] == target)
            {
                return new int[] { L + 1, R + 1 };
            }
            else if (numbers[L] + numbers[R] < target)
            {
                L++;
            }
            else
            {
                R--;
            }
        }

        return new int[] { };
    }
}