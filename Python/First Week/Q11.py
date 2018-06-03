# 자릿수를 출력하는 프로그램

count = 0
n = int(input())

while n>0:
    n = int(n/10)
    count +=1
print(count)
