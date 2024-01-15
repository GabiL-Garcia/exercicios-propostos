using System;

namespace ExercicioSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int tentativaSenha = int.Parse(Console.ReadLine());

            while (tentativaSenha != senha)
            {
                Console.WriteLine("Senha invalida");
                tentativaSenha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}