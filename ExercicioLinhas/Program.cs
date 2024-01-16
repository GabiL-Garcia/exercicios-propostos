using System;

namespace ExercicioLinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int _1 = i;
                int _2 = i * i;
                int _3 = i * i * i;

                Console.WriteLine("{0} {1} {2}" ,_1 , _2, _3);
            }
        }
    }
}