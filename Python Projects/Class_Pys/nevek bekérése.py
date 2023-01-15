v_nev = input("Kérem a vezetéknevét: ") #bekérem az adatokat
k_nev = input("Kérem a keresztnevét: ")
print(v_nev, k_nev)
print("Az ön neve: ", v_nev, k_nev)

szul_ev = input("Az ön születési éve: ")
sport = input("Az ön kedvenc sportja: ")

print("az ön neve: ", v_nev, k_nev, szul_ev, "-évben született", "és a kedvenc sportja a(z):", sport) # kiíratom a bekért adatokat

kor =  2022 - int(szul_ev) #kor meghatározása a születési évből
print("Ön", kor, "éves")