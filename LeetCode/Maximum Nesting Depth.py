class Solution:
    def maxDepth(self, s: str) -> int:
        tmp,mx = 0 , 0
        
        for i in s:
            if i=='(':
                tmp+=1
                if mx <= tmp:
                    mx = tmp
            elif i == ')':
                tmp-=1
                
        return mx
