# Runtime: 52 ms, faster than 76.81% of Python3 online submissions for Sum of All Odd Length Subarrays.
# Memory Usage: 14.4 MB, less than 8.97% of Python3 online submissions for Sum of All Odd Length Subarrays.




class Solution:
    def sumOddLengthSubarrays(self, arr: List[int]) -> int:
        res = 0
        for i in range(len(arr)):
            s = 0
            for j in range(i, len(arr)):
                s += arr[j]
                if (j - i) % 2 == 0:
                    res += s
        return res


    
    
# Runtime: 56 ms, faster than 73.34% of Python3 online submissions for Sum of All Odd Length Subarrays.
# Memory Usage: 14.2 MB, less than 23.92% of Python3 online submissions for Sum of All Odd Length Subarrays.
    
class Solution:
    def sumOddLengthSubarrays(self, arr):
        n = len(arr)
        res = 0
        for l in range(1, n + 1, 2):
            for i in range(n - l + 1):
                res += sum(arr[i:i + l])
        return res
