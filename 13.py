import math

def check(x):
    if math.sin(x)**2 + math.cos(x)**2  == 1:
        return 1
    else:
        return 0

print(check(math.pi))
print(check(math.pi*(1/2)))
print(check(math.pi*(4/3)))