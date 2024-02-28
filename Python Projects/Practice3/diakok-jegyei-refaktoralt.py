def diak_atlag():
    while True:
        nev = input("Kérlek add meg a diák nevét: ")
        if not nev:
            break
        jegyek = []
        for i in range(3):
            jegy = int(input(f"Kérlek add meg a(z) {i+1}. osztályzatot: "))
            jegyek.append(jegy)
        atlag = sum(jegyek) / len(jegyek)
        print(f"A {nev} hallgató jegyátlaga: {atlag:.2f}")

diak_atlag()
