# 424 Longest Repeating Character

# Time O(N)

class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        count = {}
        res = 0

        l = 0
        for r in range(len(s)):
            
            count[s[r]] = 1 + count.get(s[r], 0)

            # if size of window - highest frequency value in count exceeds k, then move left pointer forward
            # this sort of makes sure the window you are looking at is valid before you save it to result in each iteration of the loop.
            while (r - l + 1) - max(count.values()) > k:
                count[s[l]] -= 1
                l += 1

            res = max(res, r - l + 1)



        return res




# Slightly Optimized

class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        count = {}
        res = 0

        l = 0
        maxf = 0
        for r in range(len(s)):
            
            count[s[r]] = 1 + count.get(s[r], 0)
            maxf = max(maxf, count[s[r]])

            # if size of window - highest frequency value in count exceeds k, then move left pointer forward
            # this sort of makes sure the window you are looking at is valid before you save it to result in each iteration of the loop.
            while (r - l + 1) - maxf > k:
                count[s[l]] -= 1
                l += 1

            res = max(res, r - l + 1)



        return res



