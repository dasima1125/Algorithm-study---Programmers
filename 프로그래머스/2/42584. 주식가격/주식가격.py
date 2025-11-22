from collections import deque
def solution(prices):
    stack = deque()
    answer = [0] * len(prices)
    
    for i, price in enumerate(prices):
        while stack and price < prices[stack[-1]]:
            index = stack.pop()
            answer[index] = i - index
        stack.append(i)
    
    while stack:
        idx = stack.pop()
        answer[idx] = len(prices) - 1 - idx
    
    return answer