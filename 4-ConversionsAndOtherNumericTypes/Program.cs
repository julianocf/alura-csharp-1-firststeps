using System;

namespace _4_ConversionsAndOtherNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversões e Outros Tipos Numéricos");

            Console.WriteLine(" > Inteiro (int) possui um tamanho de 32 bits, podendo armazenar um número até 2.147.483.647");

            int intNumber = 2147483647;

            Console.WriteLine("   Exemplo de inteiro: " + intNumber);

            Console.WriteLine(" > Longo (long) possui um tamanho de 64 bits, podendo armazenar um número até 9.223.372.036.854.775.807");

            long longNumber = 9223372036854;

            Console.WriteLine("   Exemplo de Longo: " + longNumber);

            Console.WriteLine(" > Curto (short) possui um tamanho de 16 bits, podendo armazenar um número até 32.767");

            short shortNumber = 32767;

            Console.WriteLine("   Exemplo de Curto: " + shortNumber);

            Console.WriteLine(" > Ponto Flutuante (double) é o tipo de ponto flutuante com maior precisão de casas numéricas.");

            double doubleNumber = 321.1354879;

            Console.WriteLine("   Exemplo de Ponto Flutuante: " + doubleNumber);

            Console.WriteLine(" > Ponto Flutuante (float) é o tipo de ponto flutuante com menor precisão de casas numéricas, para declarar é necessário usar o sufixo 'f'.");

            float floatNumber = 123.45f;

            Console.WriteLine("   Exemplo de Ponto Flutuante com menor precisão: " + floatNumber);

            Console.WriteLine(" > Para converter um número Ponto Flutuante (double) para inteiro (int) basta adicionar '(int)' na frente da variável" );
            Console.WriteLine("   Exemplo de Ponto Flutuante (" + doubleNumber + ") para inteiro: " + (int)doubleNumber);

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
