#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the jimOrders function below.
def jimOrders(orders):
    serve_time = []

    for i, v in enumerate(orders):
        serve_time.append([v[0]+v[1],i+1])

    serve_time.sort()
    order = [x[1] for x in serve_time]
    return order

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    orders = []

    for _ in range(n):
        orders.append(list(map(int, input().rstrip().split())))

    result = jimOrders(orders)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
