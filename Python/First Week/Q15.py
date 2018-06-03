# 높이, 너비를 받아 '*' 찍기

x = int(input("높이 :"))
y = int(input("너비 :"))

for i in range(x+1):
    for j in range(y+1):
        print("*", end='')
    print("")
