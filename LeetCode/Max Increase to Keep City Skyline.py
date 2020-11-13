# Runtime: 80 ms, faster than 35.26% of Python3 online submissions.
# Memory Usage: 14.2 MB, less than 60.14% of Python3 online submissions\


class Solution:
    def maxIncreaseKeepingSkyline(self, grid: List[List[int]]) -> int:
        row = len(grid)
        col = len(grid[0])
        
        top = [0]*col
        left = [0]*row
        
        for i in range(row):
            for j in range(col):
                top[j] = max(top[j],grid[i][j])
                left[i] = max(left[i],grid[i][j])
        
        count = 0
        
        for i in range(row):
            for j in range(col):
                count += max(0,min(top[j],left[i])-grid[i][j])
                
        return count
