//O(nlogn)
//O(ln)
public class Solution
{
    public void SortColors(int[] nums)
    {
        if (nums.Length == 0) return;
        QuickSort(nums, 0, nums.Length - 1);
    }

    private void QuickSort(int[] arr, int s, int e)
    {
        // If the segment of the array to be sorted has a size of 1 or less, stop the recursion, as it's already sorted.
        if (e - s + 1 <= 1) return;

        // Use last element as the pivot.
        int pivot = arr[e];
        // Start 'left' at the beginning of segment.
        int left = s;

        //Elements <  pivot on left side
        for (int i = s; i < e; i++)
        {
            if (arr[i] < pivot)
            {
                (arr[left], arr[i]) = (arr[i], arr[left]);
                left++;
            }
        }

        // Move pivot in-between left & right
        arr[e] = arr[left];
        arr[left] = pivot;

        //Sort left side
        QuickSort(arr, s, left - 1);
        //Sort right side
        QuickSort(arr, left + 1, e);
    }
}
