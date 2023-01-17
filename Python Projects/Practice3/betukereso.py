#Definiálj egy függvényt, ami bekér egy szöveget és egy betűt, és visszaadja hogy hányszor szerepel a szövegben a betű.

def szovegben_a_betu(szoveg, betu):
        return szoveg.count(betu)
szoveg = input("Kérem adja meg a kívánt szöveget: ")
betu = input("Kérem adja meg a kívánt betűt: ")
print(f"A(z) {betu} betű {szovegben_a_betu(szoveg, betu)} alkalommal szerepel a szövegben.")
