# 15 3Sum

# front / back same as left / right

# Time O(N^2)

from typing import List


class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        res = []
        nums.sort()

        for i in range(len(nums)):

            if i > 0 and nums[i - 1] == nums[i]:
                continue

            front = i + 1
            back = len(nums) - 1
            while front < back:

                if nums[i] + nums[front] + nums[back] == 0:
                    res.append([nums[i], nums[front], nums[back]])

                    front += 1
                    # Continue to update front pointer to avoid duplicates.
                    # Need to worry about dupes any time we move front pointer.
                    while nums[front] == nums[front - 1] and front < back:
                        front += 1

                elif nums[i] + nums[front] + nums[back] > 0:
                    back -= 1
                elif nums[i] + nums[front] + nums[back] < 0:
                    front += 1

        return res


sol = Solution()
sol.threeSum([-1, 0, 1, 2, -1, 4])
