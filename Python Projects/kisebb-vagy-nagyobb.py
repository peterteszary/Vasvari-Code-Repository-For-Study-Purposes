"""Írj olyan programot ami a 16-nál kisebb számot szorozza meg 10-el, a 16-nál nagyobb vagy egyenlő számokat ossza 3-al. Az eredményt írasd ki!"""

szam1 = int(input("Kérek egy számot: "))

if szam1 < 16 :
    print("Szam1 * 10 =",szam1 * 10)


else:
    print("Szam1 / 3 =",szam1 / 3)
