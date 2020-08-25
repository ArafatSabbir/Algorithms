# Runtime: 24 ms, faster than 94.96% of Python3
# Memory Usage: 13.9 MB, less than 35.15%

class Solution:
    def balancedStringSplit(self, s: str) -> int:
        w_count = l_count = r_count = 0
        for ch in s:
            if ch == "L":
                l_count += 1
            else:
                r_count += 1
            if l_count == r_count:
                w_count += 1
        return w_count
