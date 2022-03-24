using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    internal class Livro
    {
        internal string Titulo { get; private set; }
        internal string Autor { get; private set; }
        internal string Valor { get; private set; }

        public Livro(string titulo, string autor, string valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            Valor = valor ?? throw new ArgumentNullException(nameof(valor));
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"Vaçpr: {Valor}";
        }
    }
}
