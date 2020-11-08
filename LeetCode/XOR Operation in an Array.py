# Runtime: 32 ms, faster than 50.32% of Python3 online submissions
# Memory Usage: 14.4 MB, less than 100.00% of Python3 online submissions


class Solution:
    def xorOperation(self, n: int, start: int) -> int:
        li = []

        for i in range(n):
            li.append(start+i*2)

        res = reduce(ixor, li)
        return res
