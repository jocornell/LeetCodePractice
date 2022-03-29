class solution
{
    public bool IsValidSudoku(char[][] board)
    {

        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int r = 0; r < 9; r++)
        {
            rows[r] = new HashSet<char>();
            cols[r] = new HashSet<char>();
            boxes[r] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char val = board[r][c];

                if (val == '.')
                {
                    continue;
                }

                if (rows[r].Contains(val))
                {
                    return false;
                }
                rows[r].Add(val);

                if (cols[c].Contains(val))
                {
                    return false;
                }
                cols[c].Add(val);

                // Formula, identifies which box you're in.
                int idx = (r / 3) * 3 + c / 3;
                if (boxes[idx].Contains(val))
                {
                    return false;
                }
                boxes[idx].Add(val);
            }
        }

        return true;
    }

}
