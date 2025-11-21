def solution(arr):
    answer = []
    prev = -1
    
    for num in arr:
        if(prev != num):
            prev = num
            answer.append(num)
    return answer