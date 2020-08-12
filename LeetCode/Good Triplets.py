# 376 ms, faster than 93.81%
# Memory Usage: 13.9 MB, less than 42.75%

class Solution:
    def countGoodTriplets(self, arr: List[int], a: int, b: int, c: int) -> int:
        count = 0
        l = len(arr)
    
        for i in range(0, l - 2):

            for j in range(i + 1, l - 1):

                if(abs(arr[i] - arr[j]) <= a):

                    for k in range(j + 1, l):

                        if((abs(arr[j] - arr[k]) <= b) and (abs(arr[i] - arr[k]) <= c)):

                            count += 1
                    
        return count
    
# Runtime: 372 ms, faster than 94.96%
# Memory Usage: 13.8 MB, less than 76.56%
   
class Solution:
    def countGoodTriplets(self, arr: List[int], a: int, b: int, c: int) -> int:
        count = 0
        l = len(arr)

        for i in range(0, l - 2):

            for j in range(i + 1, l - 1):

                if(abs(arr[i] - arr[j]) <= a):

                    for k in range(j + 1, l):

                        if(abs(arr[j] - arr[k]) <= b):
                            if(abs(arr[i] - arr[k]) <= c):

                                count += 1

        return count
