for i in range(int(input())): 
    print((lambda w: sum(abs(ord(w[i]) - ord(w[len(w)-i-1])) for i in range(len(w)//2)))(input()))
