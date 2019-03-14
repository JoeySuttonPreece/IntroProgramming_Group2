def getNum():
    while (True):
        try:
            print("Guess the magic number. It's somewhere between 1 and 10!!!")
            num = int(input())
            break
        except ValueError:
            pass
    return num

while (True):
    if (getNum() == 5):
        break

print("Congrats on guessing the 5!!!")