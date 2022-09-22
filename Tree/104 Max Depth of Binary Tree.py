
# 104 Max Depth of Binary Tree.

# 3 ways, recursive DFS, iterative DFS, BFS

from collections import deque


class TreeNode:
    def __init__(self, val = 0, left = None, right = None):
        self.val = val
        self.left = left
        self.right = right



# Recursive DFS
# T: O(N), Mem O(n)  (height)

class Solution:
    def maxDepth(self, root: TreeNode) -> int:
        if not root:
            return 0

        return 1 + max(self.maxDepth(root.left), self.maxDepth(root.right))


# BFS -> Level Order Traversal
# Typically use a queue

# deque = doubly ended queue, provides O(1) append and pop from both sides of the container

class Solution:
    def maxDepth(self, root: TreeNode) -> int:        
        if not root: 
            return 0

        level = 0
        q = deque([root])
        while q:            
            for i in range(len(q)):                
                node = q.popleft()
                if node.left:
                    q.append(node.left)
                if node.right:
                    q.append(node.right)                
            level += 1
        return level


# Iterative DFS.
# Utilizes a stack. (Emulates the recursive call stack)
# Preorder

class Solution:
    def maxDepth(self, root: TreeNode) -> int:
        stack = [[root, 1]]
        res = 0

        while stack:
            node, depth = stack.pop()

            if node:
                res = max(res, depth)
                stack.append([node.left, depth + 1])
                stack.append([node.right, depth + 1])
                
        return res
        

        

