from collections import deque

def solution(bridge_length, weight, truck_weights):
    time = 0
    nowweight = 0
    bridge = deque()

    for truck in truck_weights:
        while True:
            if len(bridge) == bridge_length:
                nowweight -= bridge.popleft()
            # 추가 가능
            if nowweight + truck <= weight:
                bridge.append(truck)
                nowweight += truck
                time += 1
                break 
            # 추가 불가    
            else:
                bridge.append(0)
                time += 1
                
    return time + bridge_length
