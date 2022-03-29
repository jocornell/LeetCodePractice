class Solution
{
    /// <summary>
    /// Need to study IEnumerbales.
    /// </summary>
    /// <param name="B"></param>
    /// <returns></returns>
    //public static bool IsValidSudoku(char[][] B)
    //{
    //    IEnumerable<char> Row(int i) => B[i];
    //    IEnumerable<char> Col(int i) => B.Select(r => r[i]);
    //    IEnumerable<char> Sub(int i) =>
    //        Enumerable.Range(0, 9).Select(j =>
    //             B[i / 3 * 3 + j / 3][i % 3 * 3 + j % 3]
    //        );

    //    bool IsValid(IEnumerable<char> chars) => chars
    //        .Where(c => c != '.')
    //        .GroupBy(c => c)
    //        .All(g => g.Count() == 1);

    //    return Enumerable.Range(0, 9)
    //        .All(i => IsValid(Row(i)) && IsValid(Col(i)) && IsValid(Sub(i)));
    //}

    // Similar to Java Solution #1.
    //public bool IsValidSudoku(char[][] board)
    //{

    //    if (board == null || board.Length != 9 || board[0].Length != 9)
    //        throw new ArgumentException("Invalid Input.");

    //    HashSet<char>[] rowSet = new HashSet<char>[9];
    //    HashSet<char>[] colSet = new HashSet<char>[9];
    //    HashSet<char>[] boxSet = new HashSet<char>[9];
    //    for (int i = 0; i < 9; i++)
    //    {
    //        rowSet[i] = new HashSet<char>();
    //        colSet[i] = new HashSet<char>();
    //        boxSet[i] = new HashSet<char>();
    //    }

    //    for (int row = 0; row < 9; row++)
    //    {
    //        for (int col = 0; col < 9; col++)
    //        {
    //            if (board[row][col] != '.')
    //            {
    //                if (rowSet[row].Contains(board[row][col]) || colSet[col].Contains(board[row][col]))
    //                    return false;
    //                else
    //                {
    //                    rowSet[row].Add(board[row][col]);
    //                    colSet[col].Add(board[row][col]);
    //                }
    //            }
    //        }
    //    }

    //    for (int box = 0; box < 9; box++)
    //    {
    //        for (int row = 0; row < 3; row++)
    //        {
    //            for (int col = 0; col < 3; col++)
    //            {
    //                int r = row + 3 * (box / 3);
    //                int c = col + 3 * (box % 3);
    //                if (board[r][c] != '.')
    //                {
    //                    if (boxSet[box].Contains(board[r][c]))
    //                        return false;
    //                    else
    //                        boxSet[box].Add(board[r][c]);
    //                }
    //            }
    //        }
    //    }

    //    return true;
    //}

    // Go back and review other possible solutions.
    public static void ReverseString(char[] s)
    {
        char temp;
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }
    }
}
