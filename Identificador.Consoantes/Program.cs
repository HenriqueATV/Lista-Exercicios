using System;

namespace Identificador.Consoantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            int vogal = 0;
            int consoante = 0;
            foreach (char letra in nome)
            {
                if (letra.Equals('a') || letra.Equals('A') || letra.Equals('e') || letra.Equals('E') || letra.Equals('I') ||
                            letra.Equals('I') || letra.Equals('o') || letra.Equals('O') || letra.Equals('u') || letra.Equals('u'))
                {
                    vogal++;
                } else
                {
                    consoante++;
                }
            }
            Console.WriteLine($"O número de cosoantes é: {consoante}");
            Console.ReadLine();
        }
    }
}
