k = int(input())
results = [0]*k

for i in input().split(' '):
    results[int(i)] += 1

if k != 100:
    print(' '.join([repr(num) for num in results if num]))
else:
    print(' '.join([repr(num) for num in results]))
