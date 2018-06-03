# 네 값의 최솟값을 구하는 min4 함수를 작성하세요

def min4(a, b, c, d):

    min = a
    if min > b: min = b
    if min > c: min = c
    if min > d: min = d

    return min

minPoint = min4(3, 5, 1, 6)
print(minPoint)
