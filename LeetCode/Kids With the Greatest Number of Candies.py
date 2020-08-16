# Runtime: 44 ms, faster than 43.91%
# Memory Usage: 13.8 MB, less than 73.65%


class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        fn = []
        for i , v in enumerate(candies):
            if v+extraCandies >= max(candies):
                fn.append(True)
            else:
                fn.append(False)
                
        return fn

# Runtime: 36 ms, faster than 82.66%
# Memory Usage: 14.1 MB, less than 5.01%
class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        mx = max(candies)
        for i in range(len(candies)):
            if candies[i] + extraCandies >= mx :
                candies[i] = True
            else:
                candies[i] = False
                
        return candies
