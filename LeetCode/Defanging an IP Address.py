# Runtime: 24 ms, faster than 93.95%
# Memory Usage: 13.8 MB, less than 60.13%

class Solution:
    def defangIPaddr(self, address: str) -> str:
        x = address.split(".")
        y = []
        l = len(x)
        for i in range(len(x)-1):
            y.append(x[i])
            y.append('[.]')
        y.append(x[-1])
        return (''.join(map(str, y)))
