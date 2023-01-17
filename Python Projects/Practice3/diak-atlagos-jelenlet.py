# def ossz_jelenlet():
#     while True:
#         oraszamok = int(input("Add meg az órák számát: "))
#         hianyzas = int(input("Add meg a hiányzások számát: "))
#
#         if oraszamok == hianyzas:
#             print("Nem voltál egyáltalán órákon")
#         elif oraszamok == (hianyzas % 2):
#             print("Az órák felén voltál csak")
#         elif oraszamok == (hianyzas % 3):
#             print("az órák harmadán voltál csak")
#         elif hianyzas == 0:
#             print("Gratulálok, minden órán bent voltál")
# ossz_jelenlet()

def ossz_jelenlet():
    while True:
        oraszamok = int(input("Add meg az órák számát: "))
        hianyzas = int(input("Add meg a hiányzások számát: "))
        jelenlet = (oraszamok - hianyzas) / oraszamok
        print(f"Jelenléti arány: {jelenlet:.0%}")

ossz_jelenlet()