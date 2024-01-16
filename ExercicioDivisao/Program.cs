using System;
using System.Globalization;

namespace ExercicioDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] l = Console.ReadLine().Split(' ');
                int l1 = int.Parse(l[0]);
                int l2 = int.Parse(l[1]);

                if(l2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double d = (double)l1 / l2;
                    Console.WriteLine(d.ToString("F1", CultureInfo.InvariantCulture));
                }

        
            }
        }
    }
}