using System;

namespace Conversor.Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em USD: ");
            string valor = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valor, out valorConvertido);

            decimal valorCambioConvertido = valorCambio * valorConvertido;

            Console.WriteLine($"Valor em R$: { valorCambioConvertido}");
            Console.ReadLine();

        }
    }
}
