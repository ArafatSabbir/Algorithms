#!/bin/python3

import math
import os
import random
import re
import sys

n,d=map(int,input().split())
seq=list(map(int,input().split()))
print(sum([(i+d in seq and i-d in seq) for i in seq]))
