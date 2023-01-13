# paratlan.py

szam1 = int(input("Adj meg egy számot! "))
szam2 = int(input("Adj meg egy másik számot! "))

# ha a szám2 oszhtató kettővel és a maradék nem egyenlő nulla és szam1 oszhtató kettővel és egyenlő nulla.
if szam2 % 2 != 0 and szam1 % 2 == 0:
    print("A második szám a páratlan.")

elif szam1 % 2 != 0 and szam2 % 2 == 0:
    print("Az első szám a páratlan,")

elif szam1 % 2 != 0 and szam2 % 2 != 0:
    print("Mind a két szám páratlan.")

else:
    print("Egyik szám sem páratlan.")

