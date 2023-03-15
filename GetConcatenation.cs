public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        if (nums == null) return new int[] { };

        int[] arr = new int[] { };

        for (int i = 0; i < nums.Length; i++)
        {
            arr = (int[])nums.Clone();
            int[] result = arr.Concat(nums).ToArray();

            return result;
        }

        return new int[] { };
    }
}