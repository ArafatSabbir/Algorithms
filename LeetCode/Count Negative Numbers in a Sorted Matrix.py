# Runtime: 104 ms, faster than 99.03% of Python3 online submissions for Count Negative Numbers in a Sorted Matrix.
# Memory Usage: 15.4 MB, less than 6.87% of Python3 online submissions for Count Negative Numbers in a Sorted Matrix.




class Solution:
    def countNegatives(self, grid: List[List[int]]) -> int:
        li2 = [ y for x in grid for y in x]
        return(sum(x<0  for x in li2 ))
