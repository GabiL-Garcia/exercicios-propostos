using System;
using System.Globalization;

namespace ExercicioPecas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1, p2;
            int c1, q1, c2, q2;
            double v1, v2;

            p1 = Console.ReadLine().Split(' ');
            c1 = int.Parse(p1[0]);
            q1 = int.Parse(p1[1]);
            v1 = double.Parse(p1[2], CultureInfo.InvariantCulture);

            p2 = Console.ReadLine().Split(' ');
            c2 = int.Parse(p2[0]);
            q2 = int.Parse(p2[1]);
            v2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

            double valor = (q1 * v1) + (q2 * v2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}