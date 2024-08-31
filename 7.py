import math

a = int(input())
b = int(input())
c = int(input())
delta = b**2 - 4*a*c
if delta < 0:
    print("Phuong trinh vo nghiem")
elif delta > 0:
    x1 = (-b + math.sqrt(delta))/(2*a)
    x2 = (-b - math.sqrt(delta))/(2*a)
    print(f"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}")
elif delta == 0:
    x = -b/(2*a)
    print(f"Phuong trinh co 1 nghiem kep: x = {x}")
