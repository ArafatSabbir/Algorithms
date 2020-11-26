# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right


# Runtime: 44 ms, faster than 37.11% of Python3 online submissions for Maximum Depth of Binary Tree.
# Memory Usage: 16.3 MB, less than 8.79% of Python3 online submissions for Maximum Depth of Binary Tree.
   

class Solution:
    def maxDepth(self, root):
        def rec(root, n):
            if not root:
                return 0
            elif not root.left and not root.right:
                return n 
            else:
                return max(rec(root.left, n+1), rec(root.right, n+1))
            
        n = 1
        return rec(root, n)