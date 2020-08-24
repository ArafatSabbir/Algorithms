# Runtime: 32 ms, faster than 62.64%
# Memory Usage: 13.7 MB, less than 79.21%


class Solution:
    def subtractProductAndSum(self, n: int) -> int:
        res = [int(x) for x in str(n)]
        return (math.prod(res)-sum(res))
