// O(1)
// O(1)

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {

        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {

                char current = board[i][j];
                if (current == '.') continue;
                int boxIndex = (i / 3) * 3 + (j / 3);

                if (rows[i].Contains(current)) return false;
                rows[i].Add(current);

                if (cols[j].Contains(current)) return false;
                cols[j].Add(current);

                if (boxes[boxIndex].Contains(current)) return false;
                boxes[boxIndex].Add(current);
            }
        }

        return true;
    }
}
