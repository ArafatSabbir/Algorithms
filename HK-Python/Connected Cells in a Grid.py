#!/bin/python3

import math
import os
import random
import re
import sys

def connectedCell(matrix):
    
    largest = 0 
    
    def find(temp,i,j):
        
        if 0<=i<len(matrix) and 0<=j<len(matrix[0]):
            if matrix[i][j] == 1:
                matrix[i][j] = 0 
                temp+=1
                try:
                    if matrix[i+1][j] == 1:
                        temp = find(temp,i+1,j)
                except:
                    pass
                try:
                    if matrix[i-1][j] == 1:
                        temp = find(temp,i-1,j)
                except:
                    pass
                try:
                    if matrix[i][j+1] == 1:
                        temp = find(temp,i,j+1)
                except:
                    pass
                try:
                    if matrix[i][j-1] == 1:
                        temp = find(temp,i,j-1)
                except:
                    pass

                try:
                    if matrix[i+1][j+1] == 1:
                        temp = find(temp,i+1,j+1)
                except:
                    pass
                try:
                    if matrix[i-1][j-1] == 1:
                        temp = find(temp,i-1,j-1)
                except:
                    pass
                try:
                    if matrix[i-1][j+1] == 1:
                        temp = find(temp,i-1,j+1)
                except:
                    pass
                try:
                    if matrix[i+1][j-1] == 1:
                        temp = find(temp,i+1,j-1)
                except:
                    pass
        return temp

    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            temp = 0 
            if matrix[i][j] == 1:
                temp = find(temp,i,j)
            largest = max(temp,largest)

    return largest

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    m = int(input())

    matrix = []

    for _ in range(n):
        matrix.append(list(map(int, input().rstrip().split())))

    result = connectedCell(matrix)

    fptr.write(str(result) + '\n')

    fptr.close()
