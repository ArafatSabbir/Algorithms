# Runtime: 28 ms, faster than 75.00% of Python3 online submissions for Goal Parser Interpretation.
# Memory Usage: 14.1 MB, less than 100.00% of Python3 online submissions for Goal Parser Interpretation.



class Solution:
    def interpret(self, command: str) -> str:
        final = []
        for i in range(len(command)):
            if command[i] == '(' and command[ i+1] == ')':
                final.append('o')
            elif command[i] == '(' or command[i] == ')':
                pass
            else:
                final.append(command[i])


        return ''.join(map(str, final))
    
    
    
    
#  Runtime: 24 ms, faster than 100.00% of Python3 online submissions for Goal Parser Interpretation.
#  Memory Usage: 14.2 MB, less than 100.00% of Python3 online submissions for Goal Parser Interpretation.   

###----------------------------- fast and one liner_______________
    
    
class Solution:
    def interpret(self, command: str) -> str:
        return command.replace('()','o').replace('(al)','al') 
