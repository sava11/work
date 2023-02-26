def choice(mass):
    exit=[]
    for e in mass:
        if len(e)<=3:
            exit.append(e)
    return exit

mass=["чур", "реформа", "войско", "метр", "май","минута", "озеро", "музей",":-)"]
print("изначальный массив:")
print(mass)

print("результат выборки:")
print(choice(mass))