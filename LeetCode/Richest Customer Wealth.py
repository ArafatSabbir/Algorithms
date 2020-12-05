# Runtime: 56 ms, faster than 55.54% of Python3 online submissions for Richest Customer Wealth.
# Memory Usage: 14.3 MB, less than 60.37% of Python3 online submissions for Richest Customer Wealth.


class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        l2 = []
        for i in accounts:
            l2.append(sum(i))
        return max(l2)

    
    # v2
    
    
class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        max_wealth = 0
        for i in accounts:
            if sum(i) >= max_wealth:
                max_wealth = sum(i)
        return max_wealth

    
#  Runtime: 88 ms, faster than 5.17% of Python3 online submissions for Richest Customer Wealth.
#  Memory Usage: 14.2 MB, less than 84.58% of Python3 online submissions for Richest Customer Wealth.

#----------------low memory one line

class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        return max(map(sum, accounts))
    
    
class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        return max([sum(i) for i in accounts])
