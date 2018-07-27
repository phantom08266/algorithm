class Queue(list):

    Enqueue = list.append

    def Dequeue(self, data):
        list.pop(0)

    def Is_empty(self):
        if not self:
            return True
        else:
            return False

    def Peek(self):
        return print(self[0])

    def Search(self, data):

        for i in self:
            if i == data:
                return print(self.index(i))
        return None

if __name__=="__main__":

    s = Queue()
    s.Enqueue(3)
    s.Enqueue(2)
    s.Search(2)
