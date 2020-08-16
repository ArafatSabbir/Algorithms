# Runtime: 452 ms, faster than 27.49%
# Memory Usage: 13.9 MB, less than 39.34%

class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        r = []
        l = len(nums)
        for i in range(l):
            count = 0
            for j in range(l):
                if nums[i] > nums[j]:
                    count+=1
            r.append(count)
            
        return r

    
  # Runtime: 408 ms, faster than 32.00%   

  class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        r = []
        for i ,v1 in enumerate(nums):
            count = 0
            for j ,v2 in enumerate(nums):
                if v1 > v2:
                    count+=1
            r.append(count)
            
        return r
