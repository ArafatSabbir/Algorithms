# Runtime: 60 ms, faster than 85.31%
# Memory Usage: 13.9 MB, less than 78.29%

class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        l1 = nums[:n]
        l2 = nums[n:]
        
        fn = list()
        for i,j in zip(l1,l2):
            fn.append(i)
            fn.append(j)
        
        return fn
