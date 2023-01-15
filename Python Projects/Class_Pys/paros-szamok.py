"""Írjon egy programot amely eldönt, hogy a bekért szám az páros, vagy páratlan!
be: szam1
ki: A szám páros, a szám páratlan"""

szam1 = int(input("Kérek egy számot: "))

if szam1 % 2 == 0 :
    print("A szám páros!")


else:
    print("A szám páratlan!")
