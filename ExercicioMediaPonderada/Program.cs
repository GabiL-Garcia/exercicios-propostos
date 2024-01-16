using System;
using System.Globalization;

namespace ExercicioMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double v1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                double media = (v1 * 2 + v2 * 3 + v3 * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

       


        }
    }
}