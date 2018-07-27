# Q1 search  함수 while -> for
def search(array, key):

    array.append(key)
    for i in range(len(array)):
        if array[i] == key:
            break;

    return False if i == len(array)-1 else i

"""Example O(n)
temp_list = [1,2,3,4,5,6]
print(search(temp_list, 6))
"""

# Q2 선형 검색 스캐닝 과정 표시
def linear_scaning(array, key):

    print("  | ", end='')
    for i in range(len(array)):
        print("{}  ".format(i), end='')
    print("")
    print("--*"+"----"*i)

    for i in range(len(array)):
        print("  | "+"   "*i+"*")
        print("%d |" % i, end='')
        for j in range(len(array)):
            print(" %d " % array[j], end='')
        print("")
        if array[i] == key:
            print("%d 는 array[%d]에 존재" % (key, i))
            break

"""Eample O(n^2)
temp_list = [1,2,3,4,5,6]
linear_scaning(temp_list, 5)
"""

# Q3
def search_idx(array, key, array_idx):

    for i in range(len(array)):
        if array[i] == key:
            array_idx.append(i)

    return len(array_idx)

"""Example O(n)
temp_list = [1,2,3,4,5,6,5,2,3,5]
temp_list_idx = []
print(search_idx(temp_list, 5, temp_list_idx))
"""

# Q4
def binary_search(array, key):

    pl = array.index(array[0])
    pr = array.index(array[-1])
    mid = int((pl + pr)/2)

    while (pl<=pr):
        if array[mid] == key:
            return mid
        elif array[mid] < key:
            pl = mid + 1
        else:
            pr = mid - 1
        mid = int((pl + pr)/2)
    return False

temp_list = [1,2,3,4,5,6,7]
print(binary_search(temp_list, 6))
