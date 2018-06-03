# 곱세표 출력

print(" |1\t2\t3\t4\t5\t6\t7\t8\t9")
print("--+--------------------------------------------------------------")
for i in range(1, 10):
    print("%d|" % i, end='')
    for j in range(1, 10):
        print(i*j, end='\t')
    print("")
