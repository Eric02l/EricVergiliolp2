using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nv;
            double km, cv;
            string n, cla, sla;
            Console.WriteLine("qual a quantidade de veículos do galpão?");
            nv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nv; i++)
            {
                Console.WriteLine("qual o nome do carro?");
                n = Console.ReadLine();

                Console.WriteLine("qual é a potência do veiculo?");
                cv = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("quantos quilometros rodados?");
                km = Convert.ToDouble(Console.ReadLine());
            }
                
                
                
                if(km< 5000)
            {
                cla= "novo" ;
            }
            
               
            else if(km>5000 && km <30000)
            {
                cla="semi-novo";
            }

            else
            {

               cla="velho";
            }
            if(cv > 200 )
            {
                sla="potente";
            }
     
            else if (cv>=120 && cv< 200)
            {
                sla = "forte";
            }
            else
            {
                sla="popular";
            }

                Console.WriteLine("{0} - {1} {2}", n, cla, sla);

            }



           
        
    }
}
