# 665. Non-decreasing Array
# https://leetcode.com/problems/non-decreasing-array/
# Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most one element.

# 2 pointer solution.
# Time O(n), Space O(1)

class Solution:
    def checkPossibility(self, nums: List[int]) -> bool:
        changed = False

        for i in range(len(nums) - 1):
            if nums[i] <= nums[i + 1]:
                continue
            if changed:
                return False

            if i == 0 or nums[i + 1] >= nums[i - 1]:
                nums[i] = nums[i + 1]
            else:
                nums[i + 1] = nums[i]

            changed = True

        return True