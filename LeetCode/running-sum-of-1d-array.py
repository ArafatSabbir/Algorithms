# Runtime: 44 ms, faster than 62.15%
# Memory Usage: 14.2 MB, less than 5.39%

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        nlist = list()
        sum = 0
        for i in range(len(nums)):
            sum += nums[i]
            nlist.append(sum)
        return nlist
