
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