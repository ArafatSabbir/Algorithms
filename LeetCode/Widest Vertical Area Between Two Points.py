#  Runtime: 784 ms, faster than 98.92% of Python3 online submissions for Widest Vertical Area Between Two Points Containing No Points.
#  Memory Usage: 55.3 MB, less than 8.77% of Python3 online submissions for Widest Vertical Area Between Two Points Containing No Points.


class Solution:
    def maxWidthOfVerticalArea(self, points):
        x = [x[0] for x in points]
        x.sort()
        #print(x)
        s = 0
        for i in range(len(x)-1):
            #print(x[i])
            if (x[i+1]-x[i] >= s):
                s = x[i+1] - x[i]
        return s
    
    
    
# Runtime: 780 ms, faster than 99.30% of Python3 online submissions for Widest Vertical Area Between Two Points Containing No Points.
# Memory Usage: 54.5 MB, less than 84.33% of Python3 online submissions for Widest Vertical Area Between Two Points Containing No Points.

class Solution:
    def maxWidthOfVerticalArea(self, points):
        x = sorted(a for a,b in points)
        return max(x[i+1]-x[i] for i in range(len(x)-1))
