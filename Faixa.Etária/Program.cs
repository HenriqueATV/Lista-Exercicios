using System;

namespace Faixa.Etária
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua data de Nascimento: ");
            string anoNas = Console.ReadLine();

            int anoNasConv = 0;

            int.TryParse(anoNas, out anoNasConv);

            int anoAtual = DateTime.Today.Year;

            int idade = anoAtual - anoNasConv;

            if (idade <= 19)
                Console.WriteLine($"{nome}. Sua idade é de {idade} anos, e você é Jovem!");

            else if (idade >= 20 || idade <= 59)
                Console.WriteLine($"{nome}. Sua idade é de {idade} anos, e você é Adulto");
             
            else if (idade >= 60) 
                Console.WriteLine($"{nome}. Sua idade é de {idade} anos, e você é Idoso");
           
            Console.ReadLine();
        }
    }
}
