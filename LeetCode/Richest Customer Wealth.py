# Runtime: 56 ms, faster than 55.54% of Python3 online submissions for Richest Customer Wealth.
# Memory Usage: 14.3 MB, less than 60.37% of Python3 online submissions for Richest Customer Wealth.


class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        l2 = []
        for i in accounts:
            l2.append(sum(i))
        return max(l2)
