using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mêsescristo
{
    class Program
    {
        static void Main(string[] args)
        {
            double me;
            string data, dt,me, di, ano;
          
            Console.WriteLine("Qual é a data?");
            data = Console.ReadLine();

            me = data.substring (3,2);

            di = data.Substring(0,2);

            ano = data.Substring(6);






            if (me == 01)
                dt = "janeiro";

            else if (me == 02)
                dt = "fevereiro";

            else if (me == 03)
                dt = "março";

            else if (me == 04)
                dt = "abril";

            else if (me == 05)
                dt = "maio";

            else if (me == 06)
                dt = "junho";

            else if (me == 07)
                dt = "julho";

            else if (me == 08)
                dt = "agosto";


            else if (me == 09)
                dt = "setembro";

            else if (me == 10)
                dt = "outubro";

            else if (me == 11)
                dt = "novembro";

            else if (me == 12)
                dt = "dezembro";


            Console.WriteLine("{0} de {1} de {2}", di, dt,ano);

            Console.ReadKey();


        }
    }
}
