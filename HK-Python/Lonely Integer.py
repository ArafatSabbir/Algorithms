#!/bin/python3

import math
import os
import random
import re
import sys
import operator

# Complete the lonelyinteger function below.
def lonelyinteger(a):
    b = set(a)
    n = len(a)
    if n == 1:
        return a[0]
    return ((sum(b)*2 - sum(a)))

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    a = list(map(int, input().rstrip().split()))

    result = lonelyinteger(a)

    fptr.write(str(result) + '\n')

    fptr.close()
