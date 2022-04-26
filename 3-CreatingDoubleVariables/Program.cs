using System;

namespace _3_CreatingDoubleVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis Ponto Flutuante (Double)");

            Console.WriteLine(" > Testando impressão da variável:");

            double salary = 1250.70;

            Console.WriteLine(salary);

            Console.WriteLine(" > Testando impressão da variável concatenada com texto:");

            Console.WriteLine("O valor do salário é " + salary);

            Console.WriteLine(" > Testando a divisão de um número com resultado inteiro:");

            int divisionInt = 5 / 2;

            Console.WriteLine(divisionInt);

            Console.WriteLine(" > Testando a divisão de um número com resultado quebrado:");

            double divisionDouble = 5.0 / 2;

            Console.WriteLine(divisionDouble);

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
