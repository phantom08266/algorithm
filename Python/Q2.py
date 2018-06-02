# 세 값의 최솟값을 구하는 min3 함수를 작성하세요

def min3(a, b, c):

    min = a
    if min > b: min = b
    if min > c: min = c

    return min

minPoint = min3(1, 2, 3)
print(minPoint)
