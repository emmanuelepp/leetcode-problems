//O(nlogn)
//O(logn)
public class Solution
{
    public int[] SortArray(int[] nums)
    {

        if (nums.Length == 0) return new int[] { };

        return QuickSort(nums, 0, nums.Length - 1);
    }

    private static int[] QuickSort(int[] arr, int s, int e)
    {
        // Si el arreglo esta parcialmente ordenado o invertido es recomendable usar un pivot a leatorio para eviatar N^2.
        var rng = new Random();

        if (e - s + 1 <= 1) return arr;

        //int pivot = arr[e];
        int pivotIndex = s + rng.Next(e - s + 1);
        int pivot = arr[pivotIndex];
        (arr[pivotIndex], arr[e]) = (arr[e], arr[pivotIndex]);

        int left = s;

        for (int i = s; i < e; i++)
        {
            if (arr[i] < pivot)
            {
                (arr[left], arr[i]) = (arr[i], arr[left]);
                left++;
            }
        }

        arr[e] = arr[left];
        arr[left] = pivot;

        QuickSort(arr, s, left - 1);
        QuickSort(arr, left + 1, e);

        return arr;
    }

}