#Írjunk egymás mellé 10 csillagot („*”) úgy, hogy a programkódban csak egyetlen csillag karakter legyen!
# Csillagok több sorban Írjunk egymás alá öt csillagsort! Minden sorba 10 csillag legyen!

csillag = 1
sor = 1

while sor <6:
    while csillag < 11:
         print('*', end = '') # csillag = csillag +1
         csillag += 1
    print("")
    sor += 1
print("\nVége")