using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int nquest, cont = 0;
            double tomA, tomB, tomC, tomD, tomE;
            string resp = "x";

            Console.WriteLine("quanttas questoes sao?");
            nquest = int.Parse(Console.ReadLine());

            for (int i = 0; i < nquest; i++)
            {

                Console.WriteLine("qual a tonalidade de 'A'?");
                tomA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("qual a tonalidade de 'B'?");
                tomB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("qual a tonalidade de 'C'?");
                tomC = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("qual a tonalidade de 'D'?");
                tomD = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("qual a tonalidade de 'E'?");
                tomE = Convert.ToDouble(Console.ReadLine());


                if (tomA <= 100)
                {
                    resp = "A";
                    cont++;
                }
                if (tomB <= 100)
                {
                    resp = "B";
                    cont++;

                }
                if (tomC < 100)
                {
                    resp = "C";
                    cont++;

                }

                if (tomD < 100)
                {
                    resp = "D";
                    cont++;

                }

                if (tomE < 100)
                {
                    resp = "E";
                    cont++;

                }



                else
                {
                    resp = "*";
                }



                if (cont == 1)
                {

                    Console.WriteLine(resp);
                }

                else if (cont > 1)
                {
                    Console.WriteLine("*");
                }



                else if (tomA >= 101 && tomA <= 154 || tomB >= 101 && tomB <= 154 || tomC >= 101 && tomC <= 154 || tomD >= 101 && tomD <= 154 || tomE >= 101 && tomE <= 154)
                {
                    Console.WriteLine("*");
                }


            }


            Console.ReadLine();
        }
    }
}
