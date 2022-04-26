using System;

namespace _10._1_WhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10.1 - Mão na massa: Repetição While");

            int contador = 0;
            
            while (contador <= 10)
            {
                Console.WriteLine("O contador atual é: " + contador);
                contador++;
            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
