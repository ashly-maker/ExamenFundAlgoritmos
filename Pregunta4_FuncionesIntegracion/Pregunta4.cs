using System;

class Pregunta4 {
    static string mostrarMenú() {
        Console.WriteLine("1) Cuadrado");
        Console.WriteLine("2) Rectángulo");
        Console.WriteLine("3) Círculo");
        Console.WriteLine("4) Salir");
        return Console.ReadLine();
    }

    static void Main() {
        while (true) {
            string op = mostrarMenú();
            if (op == "4") break;

            if (op == "1") {
                double lado = double.Parse(Console.ReadLine());
                Console.WriteLine($"{lado*lado:F2}");
                Console.WriteLine($"{4*lado:F2}");
            }
            else if (op == "2") {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{b*h:F2}");
                Console.WriteLine($"{2*(b+h):F2}");
            }
            else if (op == "3") {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*r*r:F2}");
                Console.WriteLine($"{2*Math.PI*r:F2}");
            }
        }
    }
}
