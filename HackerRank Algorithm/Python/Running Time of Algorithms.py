m = int(input().strip())
A = [int(i) for i in input().strip().split()]

N= len(A)
total = 0
for i in range(1, N):
    cnt = 0
    while A[i-1] > A[i] and i >0:
        A[i], A[i-1] = A[i-1], A[i]
        i-=1
        cnt+=1
    total +=cnt

print(total) 
