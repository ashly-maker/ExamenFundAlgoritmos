using System;
using System.Globalization;

class Pregunta2 {
    static void Main() {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Ingrese el número de productos N: ");
        int N = int.Parse(Console.ReadLine());

        double subtotal = 0;

        for (int i = 1; i <= N; i++) {
            Console.WriteLine($"Producto {i}:");
            Console.Write("  Precio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("  Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            subtotal += precio * cantidad;
        }

        double igv = subtotal * 0.18;
        double total = subtotal + igv;

        Console.WriteLine($"Subtotal: {subtotal:F2}");
        Console.WriteLine($"IGV: {igv:F2}");
        Console.WriteLine($"Total a pagar: {total:F2}");
    }
}
