# Runtime: 1208 ms, faster than 99.41% of Python3 online submissions for Minimum Initial Energy to Finish Tasks.
# Memory Usage: 59.3 MB, less than 79.06% of Python3 online submissions for Minimum Initial Energy to Finish Tasks.


class Solution:
    def minimumEffort(self, tasks: List[List[int]]) -> int:
        tasks.sort(key=lambda x: x[0] - x[1])
        ans = current = 0
        for cost, min_energy in tasks:
            if min_energy > current:
                ans += (min_energy - current)
                current = min_energy
            current -= cost
        return ans
