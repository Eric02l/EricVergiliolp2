using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Empresa
{
    class Empregado : Funcionario
    {

        public Gerente ahmano { get; set; }
        public int dataEntrada { get { return dataEntrada; } }
    }
}
