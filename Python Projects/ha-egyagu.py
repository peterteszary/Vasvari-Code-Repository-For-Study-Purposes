"""Készítsen programont, amely bekér két egész számot majd kiírja, ha a második a nagyobb szám"""

szam1 = int(input("Kérek egy számot: "))
szam2 = int(input("Kérek egy számot: "))

if szam2 > szam1:
   print("A második szám a nagyobb!")
   print("Igaz a feltétel!")
  # pass
else:
    print("Az első szám a nagyobb!")
    print("Hamis volt a feltétel")

    print("Vége")