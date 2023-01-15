def tree():
    x = "+"
    y = " "
    for n in range(0, 10, 2):
        if n == 0:
            print("          *")
        print(y * (10 - int(n / 2)) + (x * n) + x + y * (10 - int(n / 2)))
    print("_________||__________\n")

szo = 0
while szo < 3:
    print(szo*'Ho')
    szo+=1
print("Boldog karácsonyt!")

tree()