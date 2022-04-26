using System;

namespace _6_AssignVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

            // declaro uma nova variável idade e atribuo um valor
            int idade = 32;
            // atribui o valor da variável idade para a variável idadeJuliano
            int idadeJuliano = idade;

            // atribuo um novo valor para idade, mas como a variável idadeJuliano recebeu o valor de idade anteriormente, ela não será alterada
            idade = 20;

            Console.WriteLine("Variável idade é " + idade);
            Console.WriteLine("Variável idadeJuliano é " + idadeJuliano);

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
