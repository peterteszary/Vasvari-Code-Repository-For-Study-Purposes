# Minőség-ellenőrzés
# A szalag mellett dolgozó ellenőrök 60 –as skálán osztályozzák, pontozzák a lekerülő
# termékeket. A program addig kéri be az adatokat, amíg végjelent (Entert) nem nyom a
# felhasználó,
# Írjon függvényt, amely a bekért érték alapján rangsorolja a termékeket. A függvény
# bemeneti paramétere legyen a termék pontszáma, a visszatérési értéke pedig a
# minősítés.
# A skála érték a függvény belsejében használandó mennyiség legyen. A visszatérési érték
# a minnősítés legyen (selejt, átlagos, kiváló).
# Minősítés:
# 0-20 között selejt
# 21-40 megfelelő
# 81-60 kitűnő

def minoseg(pont):
    if 0 <= pont <= 20:
        return "selejt"
    elif 21 <= pont <=40:
        return "megfelelő"
    elif 41 <= pont <= 60:
        return "kitűnő"

while True:
    pontszam = input("Kérem adja meg a pontszámot: ")
    if pontszam == " ":
        break
    pontszam = int(pontszam)
    print("A termék minősítése:", minoseg(pontszam))