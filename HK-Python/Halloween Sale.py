pdms = input().split()

p = int(pdms[0])

d = int(pdms[1])

m = int(pdms[2])

s = int(pdms[3])


games = 0
while s >= 0:
    s -= p
    p = max(p - d, m)
    games += 1


print(str(games-1))
