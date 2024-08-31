input = int(input("nhap 1 so nguyen: "))
sum = 0
cnt = 0
while input != 0:
    sum += input % 10
    input //= 10
    cnt += 1
sum /= cnt
print(sum) 