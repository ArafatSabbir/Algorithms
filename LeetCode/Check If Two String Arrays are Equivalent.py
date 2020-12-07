#  Runtime: 24 ms, faster than 96.93% of Python3 online submissions for Check If Two String Arrays are Equivalent.
#  Memory Usage: 14.1 MB, less than 96.33% of Python3 online submissions for Check If Two String Arrays are Equivalent.




class Solution:
    def arrayStringsAreEqual(self, word1: List[str], word2: List[str]) -> bool:
        if ''.join(map(str, word1)) == ''.join(map(str, word2)):
            return True
        else:
            return False
