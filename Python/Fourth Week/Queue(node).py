class Node:

    def __init__(self, data):
        self.data = data
        self.next = None

class Queue:

    def __init__(self):
        self.front = None
        self.rear = None
        self.count = 0

    def is_empty(self):
        if not self.front:
            return True
        else:
            return False

    def Enqueue(self, data):
        new_node = Node(data)

        if self.is_empty(): # Queue가 비어있는 상태
            self.front = new_node
            self.rear = new_node
            self.count += 1
            return None

        self.rear.next = new_node
        self.rear = new_node
        self.count += 1

    def Dequeue(self):
        if self.is_empty():
            return None

        ret_data = self.front.data
        self.front = self.front.next
        return ret_data

    def Peek(self):
        if self.is_empty():
            return None

        return print(self.front.data)

    def Search(self, data):

        temp = self.front
        while(True):
            if temp.next == None:
                return False

            if temp.data ==data:
                return print("%d 에 존재" % self.count)
            else:
                temp = temp.next

    def Print(self):

        temp = self.front
        while(True):
            if temp.data != None:
                print(temp.data, end=' ')

            if temp.next == None:
                return None

            temp = temp.next

if __name__=="__main__":

    s = Queue()
    s.Enqueue(3)
    s.Enqueue(2)
    s.Peek()
    s.Print()
