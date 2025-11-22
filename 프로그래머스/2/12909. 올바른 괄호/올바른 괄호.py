from collections import deque

def solution(s):
    stack = deque()
    
    for c in s:
        if(c == '('):
            stack.append(c)
        else:
            if(len(stack) == 0):
                return False
            stack.pop()

    return len(stack) == 0