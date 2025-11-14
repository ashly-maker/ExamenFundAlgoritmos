import math

def mostrarMenu():
    print("1) Cuadrado")
    print("2) Rectángulo")
    print("3) Círculo")
    print("4) Salir")
    return input()

while True:
    op = mostrarMenu()
    if op == "4":
        break
    if op == "1":
        lado = float(input())
        print(f"{lado*lado:.2f}")
        print(f"{4*lado:.2f}")
    elif op == "2":
        b = float(input())
        h = float(input())
        print(f"{b*h:.2f}")
        print(f"{2*(b+h):.2f}")
    elif op == "3":
        r = float(input())
        print(f"{math.pi*r*r:.2f}")
        print(f"{2*math.pi*r:.2f}")
