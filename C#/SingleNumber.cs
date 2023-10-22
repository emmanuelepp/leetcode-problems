//O(n)
//o(1)
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length <= 0) return -1;

            var result = 0;

            foreach (var item in nums)
            {
                result ^= item;
            }
            return result;
        }
    }
}