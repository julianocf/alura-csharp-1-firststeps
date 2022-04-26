using System;

namespace _11._2_ForExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11.2 - Mão na massa: Repetição FOR");

            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("O contador atual é: " + contador);
            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
