//O(N)
//O(1)
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        if(operations.Length < 0) return -1;

        var result = 0;

        foreach(var item in operations)
        {
            if (item == "++X" || item == "X++") result++;
            if (item == "--X" || item == "X--") result--;
        }

        return result;
    }
}