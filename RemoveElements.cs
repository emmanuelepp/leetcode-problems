public class Solution
{
    //O(n)
    //O(1)
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count++] = nums[i];

            }
        }

        return count;

    }
}