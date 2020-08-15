#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the closestNumbers function below.
def closestNumbers(arr):
    nums = arr
    nums.sort()
    lowestDiff = nums[1]-nums[0]
    res = [nums[0],nums[1]]
    for i in range(1,len(nums)-1):            
        if nums[i+1]-nums[i] < lowestDiff:
            res = []   
            res.append(nums[i])
            res.append(nums[i+1])
            lowestDiff = abs(nums[i+1]-nums[i])
        elif nums[i+1]-nums[i] == lowestDiff:
            res.append(nums[i])
            res.append(nums[i+1])

    return(res)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = closestNumbers(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
