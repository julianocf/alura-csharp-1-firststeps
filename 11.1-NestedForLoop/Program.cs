using System;

namespace _11._1_NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11.1 - Repetição For Aninhada");

            double valorInvestido = 1000;
            double fatorInvestimento = 1.0036;
            
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorInvestimento;
                }
                fatorInvestimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
