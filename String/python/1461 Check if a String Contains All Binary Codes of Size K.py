
# 1461 Check if a String Contains All Binary Codes of Size K

class Solution:
    def hasAllCodes(self, s: str, k: int) -> bool:
        
        codeSet = set()
        
        for i in range(len(s) - k + 1):
            codeSet.add(s[i: i + k])

        return len(codeSet) == 2 ** k
