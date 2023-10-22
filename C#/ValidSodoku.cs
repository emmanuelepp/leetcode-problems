//O(1)
//O(1)
//Why? The Sodoku board have a fixed size 9*9, never change is constant. 
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        if (board.Length <= 0) return false;

        var digits = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        var validateDigit = new HashSet<char>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    if (!digits.Contains(board[i][j]) || validateDigit.Contains(board[i][j]))
                    {
                        return false;
                    }
                    validateDigit.Add(board[i][j]);
                }
            }
            validateDigit.Clear();
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[j][i] != '.')
                {
                    if (!digits.Contains(board[j][i]) || validateDigit.Contains(board[j][i]))
                    {
                        return false;
                    }
                    validateDigit.Add(board[j][i]);
                }
            }
            validateDigit.Clear();
        }

        for (int row = 0; row < 9; row += 3)
        {
            for (int col = 0; col < 9; col += 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char current = board[row + i][col + j];
                        if (current != '.')
                        {
                            if (!digits.Contains(current) || validateDigit.Contains(current))
                            {
                                return false;
                            }
                            validateDigit.Add(current);
                        }
                    }
                }
                validateDigit.Clear();
            }
        }

        return true;
    }
}