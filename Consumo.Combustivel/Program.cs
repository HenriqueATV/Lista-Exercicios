using System;

namespace Consumo.Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos KM você rodou: ");
            string valorDigitado = Console.ReadLine();
            decimal valorRodado = 0.0m;

            decimal.TryParse(valorDigitado, out valorRodado);


            Console.WriteLine("Informe quantos Lts você gastou: ");
            string valorDigitado1 = Console.ReadLine();
            decimal valorLitros = 0.0m;

            decimal.TryParse(valorDigitado1, out valorLitros);

            decimal valorTotal = valorRodado / valorLitros;

            Console.WriteLine($"Sua média foi de: {valorTotal}KMs com o litro");
            Console.ReadLine();
        }
    }
}
