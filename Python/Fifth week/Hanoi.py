# Hanoi Original

class Hanoi():

    alpha = "\0ABCDEFGHIJKLMNOPQRSTUVWXUZ"
    def move(self, no, x, y):

        if no > 1:
            move(no-1, x, 6-x-y)
        print("원반{0}를(을) {1}기둥에서 {2}기둥으로 옮김".\
              format(no, x, y))

        if no > 1:
            move(no-1, 6-x-y, y)

    def move_convert(self, no, x, y):
        if no > 1:
            self.move_convert(no-1, x, 6-x-y)
        print("원반{0}를(을) {1}기둥에서 {2}기둥으로 옮김".\
              format(no, Hanoi.alpha[x], Hanoi.alpha[y]))

        if no > 1:
            self.move_convert(no-1, 6-x-y, y)

    def non_recur_move(self, no, x, y): # 재귀 X
        temp = list()
        sw = 0 # switch 변수

        while True:
            if sw == 0 and no > 1:
                temp.append([x,y,sw])
                no = no - 1
                y = 6-x-y
                continue

            print("원반{0}를(을) {1}기둥에서 {2}기둥으로 옮김".\
                  format(no, x, y))

            if sw == 1 and no > 1:
                temp.append([x,y,sw])
                no = no - 1
                x = 6-x-y
                sw+= 1
                if sw==2:
                    sw = 0
                continue

            if not temp:
                return None
            x = temp[-1][0]
            y = temp[-1][1]
            sw = temp[-1][2]
            temp.pop()
            sw+=1
            no+=1

            while sw ==2:
                if not temp:
                    return None
                x = temp[-1][0]
                y = temp[-1][1]
                sw = temp[-1][2]
                temp.pop()
                sw+=1
                no+=1


move = Hanoi()
# move.move_convert(3, 1, 3)
move.non_recur_move(3,1,3)
