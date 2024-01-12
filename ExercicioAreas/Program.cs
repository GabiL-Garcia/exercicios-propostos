using System;
using System.Globalization;

namespace ExercicioAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, pi = 3.14159f;

            string[] vet = Console.ReadLine().Split(' ');
            a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            c = float.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            areaCirculo = (float)(pi * Math.Pow(c, 2));
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = (float)(Math.Pow(b, 2));
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}