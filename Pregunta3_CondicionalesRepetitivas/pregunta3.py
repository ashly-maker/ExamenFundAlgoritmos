while True:
    nombre = input("Ingrese el nombre (FIN para terminar): ")
    if nombre == "FIN":
        break

    n1 = float(input())
    n2 = float(input())
    n3 = float(input())

    promedio = (n1 + n2 + n3) / 3

    if promedio <= 10:
        estado = "Desaprobado :c"
    elif promedio <= 14:
        estado = "Recuperación :/"
    else:
        estado = "Aprobado :D"

    print(f"Hola {nombre}, tu estado es: {estado}")
