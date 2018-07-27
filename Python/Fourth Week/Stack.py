class Stack(list):

    def push(self, value):
        self.append(value)

    def pop(self):

        try:
            temp = self[-1]
            del self[-1]
        except:
            return False

        return print(temp)

    def peek(self):
        return print(self[-1])

    def size(self):
        return print(len(self))

    def IsEmpty(self):

        try:
            if self[0]:
                return print(False)
        except:
            return print(True)

    def search(self, value):

        try:
            return print(self.index(value))

        except:
            return print(False)
if __name__=="__main__":

    s = Stack()
    s.push(3)
    s.IsEmpty()
    s.search(3)
