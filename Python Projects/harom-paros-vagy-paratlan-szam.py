"""Írj egy Python programot amely bekér három egész számot a felhasználótól, majd megnézi, hogy mindehárom szám páros-e"""

szam1 = int(input("Kérek egy számot!"))
szam2 = int(input("Kérek egy második számot!"))
szam3 = int(input("Kérek egy harmadik számot!"))

if szam1 % 2 == 0:
    if szam2 % 2 == 0:
        if szam3 % 2 == 0:
            print("A három szám páros!")

else:
    print("Az egyik szám biztos páratlan.")