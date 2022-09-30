"""Írjunk kamatszámító programot Összeg=alap*(1+kamat/100/12*hónap)"""

alap = float(input("Kérem a befektetni való összeget:" ))
kamat = float(input("Kérem az aktuális kamatot: "))
honap = int(input("Kérem a hónapok számát -> a befektetés hosszát: "))

osszeg = alap * (1 + kamat /100/12 * honap)
print("A FUTAMIDŐ VÉGÉN VÁRHATÓ BEFEKTETÉSI ÉRTÉK: ", int(osszeg))