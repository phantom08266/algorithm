def recur2(n):
    if n>0:
        recur2(n-2)
        print("%d\n" % n)
        recur2(n-1)

"""
Bottom-up
N 을 4라고 가정할 떄:
- 최소 수는 n == 1일떄 이므로
recur2(1) : recur2(-1) 1 recur2(0) -> 1
recur2(2) : recur2(0) 2 recur2(1) -> 2 1
recur2(3) : recur2(1) 3 recur2(2) -> 1 3 2 1
recur2(4) : recur2(2) 4 recur2(3) -> 2 1 4 1 3 2 1

Top-down
recur2(4) : recur2(2) 4 recur2(3)  -> 2 1 4 1 3 2 1
recur2(3) : recur2(1) 3 recur2(2) -> 1 3 2 1
recur2(2) : recur2(0) 2 recur2(1) -> 2 1
recur2(1) : recur2(-1) 1 recur2(0) -> 1
"""
