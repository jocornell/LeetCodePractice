////////////////////////////////////////////////////////
// Check if a partially filled matrix has any conflicts.
////////////////////////////////////////////////////////

#include <vector>
#include <deque>

using namespace std;

bool isValidSudoku(const vector<vector<int>> &partialAssignment)
{
    // Check row constraints.
    for (int i = 0; i < partialAssignment.size(); ++i)
    {
        if (HasDuplicate(partialAssignment, i, i + 1, 0, partialAssignment.size()))
            return false;
    }

    // Check column constraints.
    for (int j = 0; j < partialAssignment.size(); ++j)
    {
        if (HasDuplicate(partialAssignment, 0, partialAssignment.size(), j, j + 1))
            return false;
    }

    // Check region constraints.
    int regionSize = sqrt(partialAssignment.size());

    for (int k = 0; k < regionSize; ++k)
    {
        for (int l = 0; l < regionSize; ++l)
        {
            if (HasDuplicate(partialAssignment, regionSize * k, regionSize * (k + 1), regionSize * l, regionSize * (l + 1)))
                return false;
        }
    }
    return true;
}

bool HasDuplicate(const vector<vector<int>> &partialAssignment, int startRow, int endRow, int startCol, int endCol)
{
    deque<bool> isPresent(partialAssignment.size() + 1, false);
    for (int i = startRow; i < endRow; ++i)
    {
        for (int j = startCol; j < endCol; ++j)
        {
            if (partialAssignment[i][j] != 0 && isPresent[partialAssignment[i][j]])
            {
                return true;
            }
            isPresent[partialAssignment[i][j]] = true;
        }
    }
    return false;
}