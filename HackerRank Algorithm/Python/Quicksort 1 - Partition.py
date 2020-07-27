def partition(ar):
    p=ar[0]
    left,right = [],[]
    for i in ar:
        if i >= p:
            right.append(i)
        elif i <p:
            left.append(i)
    fn = left+right
    print(' '.join(str(x) for x in fn))
        
    return ""

m = input()
ar = [int(i) for i in input().strip().split()]
partition(ar)
