def solution(participant, completion):
    counts = {}
    for p in participant:
        counts[p] = counts.get(p, 0) + 1
    
    for c in completion:
        counts[c] -= 1 
    
    for k, v in counts.items():
        if v != 0:
            return k
        
    return ""