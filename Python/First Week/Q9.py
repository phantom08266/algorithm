# 정수 a,b를 포함하여 그 사이의 모든 정수의 합을 구하는 함수

def sumof(a, b):

    # 정수가 아닌경우 리턴
    if (type(a)!=int) or (type(b)!=int):
        print("Not Integer")
        return None

    sum = 0
    for i in range(a, b+1):
        sum += i

    return sum

total = sumof(1,10)
print(total)
