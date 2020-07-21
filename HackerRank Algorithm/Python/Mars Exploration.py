s=input().strip()
print(sum(1 for i in range(len(s)) if s[i]!="SOS"[i%3]))
