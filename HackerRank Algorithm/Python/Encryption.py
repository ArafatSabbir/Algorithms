#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the encryption function below.
def encryption(s):
    sm=s.replace(" ","")
    r=math.floor(math.sqrt(len(sm)))
    c=math.ceil(math.sqrt(len(sm)))
    for i in range(c):
        print(sm[i::c],end=" ")

if __name__ == '__main__':
    #fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = encryption(s)

    #fptr.write(result)

    #fptr.close()
