
# 70 Climbing Stairs

# cacheing aka memoization
# like backtracking but cache removes all repeated work and leads to O(N) time
# Memory O(2), keep track of 2 prior results

# DP Bottom Up


class Solution:
    def climbStairs(self, n: int) -> int:

        # one, two = 1, 1

        # for i in range(n - 1):
        #     temp = one
        #     one = one + two
        #     two = temp

        # return one

        # if n == 1:
        #     return 1
        # if n == 2:
        #     return 2
        # return self.climbStairs(n - 1) + self.climbStairs(n - 2)

        if n == 0:
            return 0
        if n == 1:
            return 1
        if n == 2:
            return 2

        dp = [0] * (n + 1)
        dp[1] = 1
        dp[2] = 2

        for i in range(3, n + 1):
            dp[i] = dp[i - 1] + dp[i - 2]
        
        return dp[n]


            
