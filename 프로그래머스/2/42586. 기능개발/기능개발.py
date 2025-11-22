import math
from collections import deque

def solution(progresses, speeds):
    answer = []
    q = deque()
    for p,s in zip(progresses,speeds):
        q.append(math.ceil((100 - p) / s))
    while q:
        count = 1
        maxday = q.popleft()
        
        while q and q[0] <= maxday:
            q.popleft()
            count += 1
        
        answer.append(count)
            
    return answer