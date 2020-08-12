# Runtime: 64 ms, faster than 69.30%
# Memory Usage: 14 MB, less than 34.91%

class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        l1 = nums[:n]
        l2 = nums[n:]
        
        fn = list()
        print(l1)
        print(l2)
        for i,j in zip(l1,l2):
            fn.append(i)
            fn.append(j)
        
        return fn
