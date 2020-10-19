#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the acmTeam function below.
def acmTeam(topic):

    lid=sum=0 # lowerindex of topics list
        
    uid=1         # upperindex of the topics list
    fin=[]
    
    while lid!=len(topic)-2:

        if uid > len(topic)-1:
            lid+=1
            uid=lid+1

        res=bin(int(topic[lid],2) | int(topic[uid],2))

        temp_count=res.count(str(1))
        uid+=1

        if temp_count >= sum:

            sum = temp_count
            fin.append(sum)

    return (sum,fin.count(sum))

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nm = input().split()

    n = int(nm[0])

    m = int(nm[1])

    topic = []

    for _ in range(n):
        topic_item = input()
        topic.append(topic_item)

    result = acmTeam(topic)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
