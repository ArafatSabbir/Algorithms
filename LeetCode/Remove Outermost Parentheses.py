# Runtime: 32 ms, faster than 90.70% of Python3 online submissions for Remove Outermost Parentheses.
# Memory Usage: 14.2 MB, less than 90.01% of Python3 online submissions for Remove Outermost Parentheses.





class Solution:
    def removeOuterParentheses(self, s: str) -> str:
        count = 0 
        fn = []
        for c in s:
            if c == ')':
                count -= 1
            
            if count > 0:
                fn.append(c)
            
            if c == '(':
                count += 1
        
        return ''.join(fn)
