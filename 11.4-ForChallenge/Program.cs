using System;

namespace _11._4_ForChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11.4 - Desafio: Múltiplos de 3 com repetição FOR");

            Console.WriteLine("Com MÓDULO:");
            for (int contador = 1; contador < 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
            }

            Console.WriteLine("Sem MÓDULO:");
            for (int contador = 3; contador < 100; contador+=3)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
