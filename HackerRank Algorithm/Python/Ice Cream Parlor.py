t = input()
t = int(t)
for i in range(0,t):
    m = input()
    m = int(m)
    n = input()
    n = int(n)
    li = input() 
    li = [int(i) for i in li.split(' ')]
    for i in range(0,len(li)):
        if (m-li[i]) in li[i+1:len(li)]:
            li1 = li[i+1:len(li)] 
            x = li1.index(m-li[i]) 
            print (i+1, i+x+2)
            break
