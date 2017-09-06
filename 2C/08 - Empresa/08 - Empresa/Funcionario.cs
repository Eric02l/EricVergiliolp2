using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Empresa
{
    class Funcionario
    {
        
        public string nomeCompleto { get { return nomeCompleto; } }
        public double numRegistro { get { return numRegistro; } }

        public string email { get; set; }
        public double salario { get; set; }
        private double cpf { get { return cpf; } }



    }
}
