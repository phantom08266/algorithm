# 정사각형 '*'찍기

n = int(input("입력할 수:"))

for i in range(n+1):
    for j in range(n+1):
        print("*", end='')
    print("")
