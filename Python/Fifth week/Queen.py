import os

def print_all(temp):

    for i in range(8):
        print(temp[0], end='')
        temp.pop(0)
    print()

def set_batch_one(i): # 대각선 제외한 set

    for j in range(8):
        if not flag[j]:
            pos[i] = j
            if i == 7:
                print(pos)
            else:
                flag[j] = 1
                set_batch_one(i+1)
                flag[j] = 0


def set_batch(i): # 대각선 포함한 set

    for j in range(8):
        if (not flag_a[j]) and (not flag_b[i+j]) and (not flag_c[i-j+7]):
            pos[i] = j
            if i == 7:
                print(pos)
            else:
                flag_a[j] = flag_b[i+j] = flag_c[i-j+7] = 1
                set_batch(i+1)
                flag_a[j] = flag_b[i+j] = flag_c[i-j+7] = 0

pos = [0 for x in range(8)]
flag = [0 for x in range(8)]
flag_a = [0 for x in range(8)]
flag_b = [0 for x in range(15)]
flag_c = [0 for x in range(15)]
# set_batch(0)
# set_batch_one(0)
