
# Two Sum

# Additional Practice Problems

# Two Sum II
# 3 Sum
# 4 Sum
# Combination Sum II
#


from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        # Use a hasmap to store the index of every value in the array.
        # Time is O(N), Space is O(N)
        # Hash table amortized lookup time is O(1)
        
        hashMap = {}

        for i in range(len(nums)):          
              
            complement = target - nums[i]
            
            if complement in hashMap and hashMap[complement] != i:
                return [i, hashMap[complement]]            
            
            hashMap[nums[i]] = i

        # Two pass solution. But we can do better by doing it in one pass.
        # for i in range(len(nums)):
        #     hashMap[nums[i]] = i
            
        # complement = 0
        # for i in range(len(nums)):
        #     complement = target - nums[i]
        #     if complement in hashMap and hashMap[complement] != i:
        #         return [i, hashMap[complement]]
            
        

        # O(n^2) Brute force.
        # Gives time limit exceeded in leetcode.
        
        # for i in range(len(nums)):
        #     for j in range(i+1, len(nums)):
        #         if nums[i] + nums[j] == target:
        #             return [i, j]


        # Sorting doesn't work because you need the indices.
        # nums.sort()

        # i = 0
        # j = len(nums) - 1

        # while i <= j:

        #     if nums[i] + nums[j] == target:
        #         return [i, j]

        #     if nums[i] + nums[j] > target:
        #         j -= 1            
        #     elif nums[i] + nums[j] < target:
        #         i += 1


            

            
sol = Solution()
sol.twoSum([3,2,4], 6)