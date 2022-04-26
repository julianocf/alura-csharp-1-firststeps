using System;

namespace _7_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Testando Condicionais");

            int idade = 20;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("voce não tem 18, mas pode entrar, pois está acompanhado");

                }
                else
                {
                    Console.WriteLine("Infelizmente voce não pode entrar :(");
                }

            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
