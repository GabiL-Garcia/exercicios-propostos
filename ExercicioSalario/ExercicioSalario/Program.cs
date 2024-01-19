﻿using System;
using System.Globalization;

namespace ExercicioSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}