# Runtime: 1012 ms, faster than 5.12% of Python3 online submissions for Maximum Product of Two Elements in an Array.
# Memory Usage: 14.3 MB, less than 45.49% of Python3 online submissions for Maximum Product of Two Elements in an Array.


class Solution:
    def maxProduct(self, numbers: List[int]) -> int:
        n = len(numbers)
        max_product = 0
        for first in range(n):
            for second in range(first + 1, n):
                max_product = max(max_product,(numbers[first]-1) * (numbers[second]-1))

        return max_product
    
    
# Runtime: 52 ms, faster than 47.24% of Python3 online submissions for Maximum Product of Two Elements in an Array.
# Memory Usage: 14.4 MB, less than 18.01% of Python3 online submissions for Maximum Product of Two Elements in an Array.   
    
class Solution:
    def maxProduct(self, numbers: List[int]) -> int:
        numbers.sort()
        return (numbers[-1]-1)*(numbers[-2]-1)
    
    
    
# Runtime: 40 ms, faster than 98.25% of Python3 online submissions for Maximum Product of Two Elements in an Array.
# Memory Usage: 14.5 MB, less than 18.01% of Python3 online submissions for Maximum Product of Two Elements in an Array.



class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        f = s = -math.inf
        for num in nums:
            if num >= f:
                s = f
                f = num
            elif num > s:
                s = num
        return (f - 1) * (s - 1)
