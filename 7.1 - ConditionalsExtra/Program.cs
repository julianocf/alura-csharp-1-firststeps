using System;

namespace _7._1___ConditionalsExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            //O João gostaria de criar um programa sobre Imposto de Renda(IR) e verificou as regras de alíquota. Ele descobriu no site da receita:
            //De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
            //De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.

            Console.WriteLine("Executando projeto 7.1 - Testando Condicionais Extra");

            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Sua alíquota do IR é de 7,5% e pode deduzir o valor de R$ 142,00 na declaração.");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Sua alíquota do IR é de 15% e pode deduzir o valor de R$ 350,00 na declaração.");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Sua alíquota do IR é de 22,5% e pode deduzir o valor de R$ 636,00 na declaração.");
            }

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
