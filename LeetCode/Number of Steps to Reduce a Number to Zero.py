# Runtime: 28 ms, faster than 78.31% of Python3 online submissions
# Memory Usage: 14 MB, less than 100.00% of Python3 online submissions


class Solution:
    def numberOfSteps (self, num: int) -> int:
        count = 0
        while True:
            if num == 0:
                return count
            elif num % 2 == 0:
                num = num/2
                count += 1
                if num == 0:
                    return count 
            else:
                num = num-1
                count += 1
