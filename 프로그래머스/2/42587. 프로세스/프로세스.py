from collections import deque

def solution(priorities, location):
    answer = 0
    queue = deque()
    #for i in range(len(priorities)):
    #    queue.append([i,priorities[i]])
    
    for idx, priority in enumerate(priorities):
        queue.append([idx, priority])
    
    while(queue):
        pick = queue.popleft()
        
        if any(p[1] > pick[1] for p in queue):
            queue.append(pick)
            continue
            
        answer += 1
        
        if pick[0] == location: 
            return answer
    
    return answer