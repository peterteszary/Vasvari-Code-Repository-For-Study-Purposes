def minoseg(ora):
    if 0 < ora < 10:
        return "aktív, példás szorgalom"
    elif 9 < ora < 31:
        return "átalgos, közepes szorgalom"
    elif ora > 30:
        return "passzív hanyag szorgalom"

hianyzas = 0

while hianyzas != "":
    hianyzas = input("Kérem a hiányzások számát órában: ")
    if hianyzas == "":
        break
        hianyzas = int(hianyzas)
        print("Minősítés: ", minoseg(hianyzas))