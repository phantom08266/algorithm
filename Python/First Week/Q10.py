# a,b 정수를 입력받고 b-a를 출력하는 프로그램을 작성
# (단. b > a)

while True:

    a = int(input("a의 값:"))
    b = int(input("b의 값:"))

    if a >= b:
        print("다시 입력하세요")
        continue

    print(b-a)
    break
