def pontszam_ellenorzes(pontszam):
    if pontszam >= 48:
        return True
    else:
        return False

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
