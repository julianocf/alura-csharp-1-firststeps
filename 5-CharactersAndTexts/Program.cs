using System;

namespace _5_CharactersAndTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

            // uma string é declarada com aspas duplas " e pode ter zero ou mais caracteres. Um char é declarado com aspas simples ' e pode usar apenas um caractere!
            // char é o tipo de variável do tipo de texto  que guarda somente 1 caractere, internamente é um int de 16 bits

            // Crie uma variável do tipo char e imprima no console
            char letra = 'a';
            Console.WriteLine(letra);

            // convertendo ascii code para char
            char asciiCode = (char)65;
            Console.WriteLine("ASCII Code para char: " + asciiCode);

            // pode ser feito dessa forma também
            asciiCode = (char)(asciiCode + 1);
            Console.WriteLine("ASCII + 1: " + asciiCode);

            // string é o tipo de texto que guarda mais de uma caractere
            string frase = "Aprendendo C# com a Alura";
            Console.WriteLine(frase);

            // aqui o número é convertido para string e concatenado com a string "palavra"
            frase = frase + " " + 2022;
            Console.WriteLine(frase);

            Console.WriteLine("Execução finalizada, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
