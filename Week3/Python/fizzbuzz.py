number = 1

while (number <= 100):
    fizz = "Fizz" if number % 3 == 0 else ""
    buzz = "Buzz" if number % 5 == 0 else ""
    string = "" + fizz + buzz
    if (string):
        print(string)
    else:
        print(number)
    number += 1