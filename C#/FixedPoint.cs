//O(logn)
//O(1)
public class Solution {
    public int FixedPoint(int[] arr) {

        if (arr == null || arr.Length <= 0) return -1;

        int L = 0, R = arr.Length -1;
        int result = -1;

        while(L <= R)
        {
            int mid = L + (R - L) / 2;

            if (arr[mid] == mid)
            {
                result = mid;
                R = mid - 1;
            } 
            if (arr[mid] < mid)
            {   
                L = mid + 1;
            }
            else
            {
                R = mid - 1;
            }
        }

        return result;
    }
}