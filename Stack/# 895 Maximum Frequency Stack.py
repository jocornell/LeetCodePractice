# 895 Maximum Frequency Stack

# 1.) Count of most frequent vals - hashmap, max
# 2.) map count of a val -> group of vals with the same count -> List to preserve order


# Time O(1) for push and pop

class FreqStack:
    
    def __init__(self):
        self.cnt = {}
        self.maxCnt = 0
        self.stacks = {}


    def push(self, val: int) -> None:

        valCnt = 1 + self.cnt.get(val, 0)
        self.cnt[val] = valCnt
        
        if valCnt > self.maxCnt:
            self.maxCnt = valCnt
            self.stacks[valCnt] = []
        
        self.stacks[valCnt].append(val)

    def pop(self) -> int:
        res = self.stacks[self.maxCnt].pop()
        self.cnt[res] -= 1
        if not self.stacks[self.maxCnt]:
            self.maxCnt -= 1
        return res
        

