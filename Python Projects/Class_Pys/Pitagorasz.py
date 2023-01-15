""" Pitagorasz tételt alkalmazó program. Kiszámolja derékszögű háromszög átfogóját a befogók ismeretében"""
import math

a_befogo = int(input("Kérem az egyik befogóját a háromszögnek: "))
b_befogo = int(input("Kérem a másik befogóját a háromszögnek: "))

atfogo = a_befogo ** 2 + b_befogo ** 2
atfogo1 = math.sqrt(atfogo) #négyzetgyök
atfogo2 = pow(atfogo, 1/2) #négyzetgyök
print("Az átfogó részeredmény 1: ", round(atfogo1,2))
print("Az átfogó részeredmény 2: ", round(atfogo2,2))

print("A pi állandó a matematikai modulból: " ,math.pi)