
# 225 Implement Stack Using Queues

from collections import deque

class MyStack:
    
    def __init__(self):
        self.q = deque()
        
    def push(self, x: int) -> None:
        self.q.append(x)
        
    def pop(self) -> int:
        for i in range(len(self.q) - 1):
            self.push(self.q.popleft())
        return self.q.popleft()
    
    def top(self) -> int:
        return self.q[-1] # return last element
    
    def empty(self) -> bool:
        return len(self.q) == 0
        


# Adds too many extra things.
# Need to operate in constraint of 2 queues only.
class StackWithQs: 

    def __init__(self):
        self.count = 0
        self.q1 = []
        self.q2 = [] # q2 can just be a variable...


    def push(self, x: int):
        self.count = self.count + 1
        if not self.q2:    
            self.q2.append(x)
        else:
            self.q1.append(self.q2[0])
            self.q2.clear()
            self.q2.append(x)

    def pop(self):
        if self.q2:
            self.count = self.count - 1
            
            ret = self.q2[0]
            self.q2.clear()
            if self.q1:
                self.q2.append(self.q1[(self.count - 1)])
                self.q1 = self.q1[:-1] # loop to end 
                
            
            return ret
        else:
            return -1
            
            
class Solution:
    def main():
        stack = StackWithQs()
        stack.push(1)
        stack.push(2)
        
        print(stack.q2)
        print(stack.q1)
        print(stack.count)
        
        print(stack.pop())
        print(stack.pop())
        print(stack.count)
        
        stack.push(1)
        stack.push(2)
        stack.push(3)
        stack.push(4)
        print(stack.count)
        
        print(stack.q2)
        print(stack.q1)
        print(stack.count)
        
        print(stack.pop())
        print(stack.pop())
        
        stack.push(5)
        
        print(stack.pop())
        print(stack.pop())
        print(stack.count)
        
        print(stack.q2)
        print(stack.q1)
        
    main()




