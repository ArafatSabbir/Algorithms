#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the runningTime function below.
def runningTime(A):
    N= len(A)
    total = 0
    for i in range(1, N):
        cnt = 0
        while A[i-1] > A[i] and i >0:
            A[i], A[i-1] = A[i-1], A[i]
            i-=1
            cnt+=1
        total +=cnt
    return total

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = runningTime(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
