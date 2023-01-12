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

def sikeres_e(pontszam):
    if pontszam >= 48:
        return True
    else:
        return False

nev = input("Adja meg a vizsgázó nevét: ")
while nev:
    pontszam = int(input("Adja meg a vizsgázó pontszámát: "))
    if sikeres_e(pontszam):
        print(f"A(z) {nev} sikeresen vizsgázott.")
    else:
        print(f"A(z) {nev} sikertelenül vizsgázott.")
    nev = input("Adja meg a vizsgázó nevét: ")