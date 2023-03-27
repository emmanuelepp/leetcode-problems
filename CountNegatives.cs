//O(n^2)
//O(1)
public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;

        int count = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}