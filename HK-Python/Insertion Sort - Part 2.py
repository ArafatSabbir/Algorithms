#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the insertionSort2 function below.
def insertionSort2(n, arr):


    for i in range(n):
        k =i
        ele = arr[i]
        while(k>0 and ele<arr[k-1]):
            arr[k] = arr[k-1]
            k = k-1
        arr[k] = ele
        if i!=0:
            print(' '.join([str(x) for x in arr]))

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    insertionSort2(n, arr)
