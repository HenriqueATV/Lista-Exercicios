using System;

namespace Cadastro.Aluno
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            ImprimirDadosAluno(new AbstractAluno());
            ImprimirDadosAluno(new Aluno2());

            Console.ReadLine();
        }
        static void ImprimirDadosAluno(AbstractAluno aluno)
        {
            Console.WriteLine(aluno.ImprimirDados());
        }
    }
}
        }
    }
}
