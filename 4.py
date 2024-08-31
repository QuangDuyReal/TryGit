num = int(input("Nhap bien so: "))
sum = 0
while num != 0:
    sum += num % 10
    if sum >= 10:
        sum -= 10
    num //= 10
print(sum)
