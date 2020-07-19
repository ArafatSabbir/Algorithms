input()

B = list(map(int,input().split()))

B = [i%2 for i in B]
c = 0 
for i in range(len(B)-1):
    if B[i] and B[i+1]:
        B[i] = 0
        B[i+1] = 0
        c+=1
    elif B[i] and not B[i+1]:
        B[i] = 0
        B[i+1] = 1
        c+=1
if any(B):
    print("NO")
else:
    print(c*2)
