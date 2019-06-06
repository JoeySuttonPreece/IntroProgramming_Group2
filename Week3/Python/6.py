import random

def getNum():
    while (True):
        try:
            print("Enter guess.")
            num = int(input())
            break
        except ValueError:
            pass
    return num

counter = 0

num = random.randint(1, 1000)

print("Dont tell anyone but the big spooky random number is ", num)

print("Can you guess the big spooky secret number??????!??!!???!1?/?")

while (counter < 10):
    if (getNum() == num):
        print("Correct")
    else:
        print("Wrong, counter value is ", counter)
    counter += 1