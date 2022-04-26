using System;

namespace _11._5_FactorialWithForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11.5 - Desafio: Fatorial com repetição FOR");

            int fatorial = 1;

            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine("Fatorial de " + n + " é " + fatorial);
            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
