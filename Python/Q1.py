# 네 값의 최댓값을 구하는 함수 max4 를 작성하시오

def max4(a, b, c, d):

    max = a
    if b > max: max = b
    if c > max: max = c
    if d > max: max = d

    return max

max_point = max4(1,2,3,4)
print(max_point)
