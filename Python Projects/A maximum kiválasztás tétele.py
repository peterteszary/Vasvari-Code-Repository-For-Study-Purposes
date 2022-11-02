# Írjunk alkalmazást bekér egy egész számot, majd mindaddig kér be további egész
# számokat, amíg nullát nem kap. A program határozza meg és írja ki a megadott egész
# számok közül a legnagyobbat.

szam = 1
legnagyobb = 0

while szam != 0:
    szam = int(input("Kérek egy számot: "))

    if szam > legnagyobb:
        legnagyobb = szam


print("\nAz eddig megadott legnagyobb szám: ", legnagyobb)
