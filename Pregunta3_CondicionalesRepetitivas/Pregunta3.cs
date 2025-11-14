using System;

class Pregunta3 {
    static void Main() {
        while (true) {
            Console.Write("Ingrese el nombre (FIN para terminar): ");
            string nombre = Console.ReadLine();
            if (nombre == "FIN") break;

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;
            string estado = "";

            if (promedio <= 10) estado = "Desaprobado";
            else if (promedio <= 14) estado = "Recuperación";
            else estado = "Aprobado";

            Console.WriteLine($"Hola {nombre}, tu estado es: {estado}");
        }
    }
}
