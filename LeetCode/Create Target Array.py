#  Runtime: 36 ms, faster than 35.58% of Python3 online submissions
#  Memory Usage: 14.2 MB, less than 99.97% of Python3 online submissions


class Solution:
    def createTargetArray(self, nums: List[int], index: List[int]) -> List[int]:
        result = []

        for i in range(len(nums)):
            result[index[i]:index[i]] = [nums[i]]


        return result


    
# Runtime: 32 ms, faster than 69.86% of Python3 online submission
# Memory Usage: 14.1 MB, less than 99.97% of Python3 online submissions
    class Solution:
    def createTargetArray(self, nums: List[int], index: List[int]) -> List[int]:
        result = []

        for i in range(len(nums)):
            result.insert(index[i],nums[i])


        return result
