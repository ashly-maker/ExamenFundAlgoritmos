n = int(input("Ingrese el número de productos N: "))
subtotal = 0.0

for i in range(1, n+1):
    print(f"Producto {i}:")
    precio = float(input("  Precio: "))
    cantidad = int(input("  Cantidad: "))
    subtotal += precio * cantidad

igv = subtotal * 0.18
total = subtotal + igv

print(f"Subtotal: {subtotal:.2f}")
print(f"IGV: {igv:.2f}")
print(f"Total a pagar: {total:.2f}")
