using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double salario, calculoSalario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calculoSalario = (double)salario * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + calculoSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}