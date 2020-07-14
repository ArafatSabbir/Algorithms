s = input('')
stack = []
for char in s:
    if stack and stack[-1] == char:
        stack.pop()
    else:
        stack.append(char)
stack = ''.join(stack)
print(stack or "Empty String")
