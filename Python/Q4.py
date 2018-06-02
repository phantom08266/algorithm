# 세 값의 대소 관계에 대해서 중앙값을 구하여 출력하는 프로그램을 작성

def med3(a, b, c):

    if a >= b:
        if b >= c:
            mid = b
        elif a <= c:
            mid = a
        else:
            mid = c
    else:
        if a >= c:
            mid = a
        elif b <= c:
            mid = b
        else:
            mid = c

    print(mid)

med3(3, 5, 2)
med3(3, 3, 2)
med3(2, 1, 7)
