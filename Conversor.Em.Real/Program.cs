using System;

namespace Conversor.Em.Real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em R$: ");
            string valor = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 0.1932m;

            decimal.TryParse(valor, out valorConvertido);

            decimal valorCambioConvertido = valorCambio * valorConvertido;

            Console.WriteLine($"Valor em USD: { valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
