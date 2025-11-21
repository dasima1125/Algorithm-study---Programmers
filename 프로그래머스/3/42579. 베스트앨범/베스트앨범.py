from collections import defaultdict

def solution(genres, plays):
    answer = []
    count_map = defaultdict(int)    
    order_map = defaultdict(list)     

    for idx, (genre, play) in enumerate(zip(genres, plays)):
        count_map[genre] += play
        order_map[genre].append((idx, play))
        
    ordergenres = sorted(count_map.keys(), key=lambda g: count_map[g], reverse=True)

    for genre in ordergenres:
        top_songs = sorted(order_map[genre], key=lambda x: (-x[1], x[0]))[:2]
        answer.extend(idx for idx, _ in top_songs)

    return answer

