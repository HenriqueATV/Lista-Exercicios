using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Aluno
{
    class Aluno2 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 12;
        }

        public override string ObterNome()
        {
            return "Henrique";
        }

        public override int ObterNota()
        {
            return 80;
        }

        public override string ObterRa()
        {
            return "675";
        }
    }
}


