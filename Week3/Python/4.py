def getNum():
    while (True):
        try:
            print("Enter target.")
            num = int(input())
            break
        except ValueError:
            pass
    return num

num = getNum()

counter = 0

while (counter <= num):
    print(counter)
    counter += 1