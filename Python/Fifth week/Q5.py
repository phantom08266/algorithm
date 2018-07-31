def recur3(n):

    temp = list()
    while True:
        if n>0:
            temp.append(n)
            n = n - 1
            continue

        if temp:
            # print(temp)
            print("%d" % temp[-1])
            n = temp[-1]
            temp.pop()
            n = n - 2
            continue
        break

recur3(4)
