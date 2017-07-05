using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livroBbk
{
    class livro
    {

        public string nome;
        public int qnth, npag;

        public double calcularTempo()
        {
            return npag / qnth;
           
        }
       



    }
}
