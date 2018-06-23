import random
import numpy as np

# Q1 최솟값을 구하는 함수
def minof(a):

    min = a[0]
    for i in range(1, len(a)):
        if a[i] < min: min = a[i]
    return min

# Q2 합계를 구하는 함수
def sumof(a):

    sum = 0
    for i in range(len(a)):
        sum = sum + a[i]
    return sum

# Q3 평균을 구하는 함수
def aveof(a):

    sum = sumof(a)
    average = sum/len(a)
    return average

# Q4 난수로 사람수와 키를 생성
def genHeight():

    height = np.array([0 for x in range(random.randrange(5, 21))])
    for i in range(len(height)):
        height[i] = random.randrange(100, 189)
    return height

# Q5 배열의 Reverse 과정을 출력
def swap(x, y):
    return y, x
def arr_reverse(a):

    length = len(a)
    for i in range(int(length/2)):
        a[i], a[int(length)-i-1] = swap(a[i], a[int(length)-i-1])
        print("a[%d]와 a[%d]를 교환 합니다" % (i, int(length)-i-1))
        print(a)

# test = np.array([5,10,73,2,-5,42])
# arr_reverse(test)

# Q6
def card_conv(x, n, result, rev):

    dchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    if x==0:
        result.append(dchar[0])
    else:
        while(x>0):
            result.append(dchar[x%n])
            x = int(x/n)
    if rev:
        result.reverse()
    return result

#Q7
def conv_print():

    result = list()
    dchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    print("10진수를 기수변환 합니다")
    x = int(input("변환 하는 음이 아닌 정수 :"))
    try:
        if x>0: pass
        n = int(input("어떤 진수로 변환할까요?(2~32) :"))
        try:
            if n>=2 and n<=32: pass
        except:
            print("범위 내의 진수를 입력")
    except:
        print("음이 아닌 정수를 입력")

    while(x>0):
        print("%d|   %d...%s" % (n, x, dchar[x%n]))
        print(" +------")
        result.append(dchar[x%n])
        x = int(x/n)

# Q8
def ary_copy(a, b):

    a = b[:]
    return a

# Q9
def ary_rcopy(a, b):

    arr_reverse(b)
    a=b[:]
    return a

# Q10
def ary_rand(a):

    random.shuffle(a)
    return a
