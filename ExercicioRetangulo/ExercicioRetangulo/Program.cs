using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo t = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo:");
            t.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + t.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + t.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + t.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}