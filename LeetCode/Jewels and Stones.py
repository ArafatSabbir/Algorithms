# Runtime: 32 ms, faster than 55.15% of Python3 online submissions for Jewels and Stones.
# Memory Usage: 14.1 MB, less than 99.99% of Python3 online submissions for Jewels and Stones.


class Solution:
    def numJewelsInStones(self, J: str, S: str) -> int:
        jewels = {}
        for i in J:
            jewels[i] = 1
        number = 0
        for i in S:
            if i in jewels:
                number+=1
        return number
