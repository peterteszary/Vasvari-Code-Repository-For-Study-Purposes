# 2 szám közül melyik a páratlan?

szam1 = int(input("Kérem adja meg az első számot: "))
szam2 = int(input("Kérem adja meg a második számot: "))

if szam1 % 2 == 0 and szam2 % 2 != 0:
    print("Az második szám Páratlan")
elif szam1 % 2 != 0 and szam2 % 2 == 0:
    print("Az első szám páratlan")
elif szam1 % 2 == 0 and szam2 % 2 == 0:
    print("Mindkét szám páros")
elif szam1 % 2 != 0 and szam2 % 2 != 0:
    print("Mindkét szám páratlan")