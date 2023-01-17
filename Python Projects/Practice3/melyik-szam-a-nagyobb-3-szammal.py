# Melyik szám a nagyobb?

szam1 = int(input("Kérlek add meg az első számot: "))
szam2 = int(input("Kérlek add meg a második számot: "))
szam3 = int(input("Kérlek add meg a harmadik számot: "))

if szam1 > szam2 and szam1 > szam3:
    print("Az első szám a nagyobb")
elif szam2 > szam1 and szam2 > szam3:
    print("A második szám a nagyobb")
elif szam3 > szam2 and szam3 > szam1:
    print("A harmadik szám a nagyobb")
elif szam1 == szam2 == szam3:
    print("Mindhárom szám egyenlő!")