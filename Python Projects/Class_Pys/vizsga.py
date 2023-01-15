# Teszáry Péter

# Itt adom meg a pontozási feltételt, hogy ha 48-nál kisebb akkor nem sikerült
def pontszam_ellenorzes(pontszam):
    if pontszam >= 48:
        return True
    else:
        return False

# A ciklus ami elvégzi az ellenőrzést a bekért adatok alapján
# Ha üres értéket ad meg a felhasználó akkor a program kilép
while True:
    nev = input("Add meg a vizsgázó nevét! ")
    if nev == "":
        break
    pontszam = int(input("Add meg a pontszámát! "))
    result = pontszam_ellenorzes(pontszam)
    if result:
        print(f"{nev} vizsgája sikeres!")
    else:
        print(f"{nev} vizsgája sikertelen.")
