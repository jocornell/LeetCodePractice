
# 1299 Replace Elements with greatest element on right side

# Time O(N)


def replaceElements(self, arr: List[int]) -> List[int]:

    rightMax = -1

    for i in range(len(arr) - 1, -1, -1):
        newMax = max(rightMax, arr[i])
        arr[i] = rightMax
        rightMax = newMax
    return arr

    