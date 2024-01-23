using System;
using System.Globalization;

namespace ExercicioDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Dolar(c, d).ToString("F2", CultureInfo.InvariantCulture));  
        }
    }
}