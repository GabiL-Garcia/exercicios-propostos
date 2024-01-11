using System;
using System.Globalization;

namespace ExercicioRaio
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, formulaArea;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            formulaArea = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + formulaArea.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}