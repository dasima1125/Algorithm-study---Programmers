def solution(phone_book):
    hs = set(phone_book) 

    for phone in phone_book:
        for i in range(1, len(phone)): 
            if phone[:i] in hs: 
                return False
    return True