using System;

namespace Identificador.Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            int vogal = 0;

            foreach (char letra in nome)
            { 
            if (letra.Equals('a') || letra.Equals('A') || letra.Equals('e') || letra.Equals('E') || letra.Equals('I') ||
                        letra.Equals('I') || letra.Equals('o') || letra.Equals('O') || letra.Equals('u') || letra.Equals('u'))
                    vogal++;
            }
            Console.WriteLine($"O número de vogais é: {vogal}");
            Console.ReadLine();
        }
    }
}
