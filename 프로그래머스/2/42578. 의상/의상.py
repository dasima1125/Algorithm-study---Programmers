def solution(clothes):
    hm = {}
    answer = 1
    for cloth in clothes:
        where = cloth[1] 
        hm[where] = hm.get(where, 0) + 1 
    
    for v in hm.values():
        answer *= (v + 1)
    
    return answer - 1