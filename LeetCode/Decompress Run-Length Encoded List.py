#  Runtime: 60 ms, faster than 94.65% of Python3 online submissions
#  Memory Usage: 14.5 MB, less than 43.34% of Python3 online submissions




class Solution:
    def decompressRLElist(self, nums: List[int]) -> List[int]:
        fn =[]
        for i in range(0,len(nums),2):
            freq = nums[i]
            val =  nums[i+1]
            temp = freq* [val]
            fn.extend(temp)

        return fn
