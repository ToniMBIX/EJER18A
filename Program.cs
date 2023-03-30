using System;
class TriangleProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca los tres lados del triángulo: ");

        Console.Write("Lado 1: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Lado 2: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Lado 3: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado1 == lado3)
        {
            Console.WriteLine("El triángulo es equilátero.");
        }
        else
        {
            double ladoMayor = Math.Max(lado1, Math.Max(lado2, lado3));
            Console.WriteLine("El triángulo no es equilátero, el lado más largo es: " + ladoMayor);
        }

        Console.ReadKey();
    }
}
