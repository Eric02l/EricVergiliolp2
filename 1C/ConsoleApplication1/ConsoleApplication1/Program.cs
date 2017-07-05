using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Carro
        {
            public string Modelo;
            public double Quilometragem;
            public int Potencia;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Carro[] carros = new Carro[n];

            for (int i = 0; i < n; i++)
            {
                carros[i].Modelo = Console.ReadLine();
                carros[i].Quilometragem = double.Parse(Console.ReadLine());
                carros[i].Potencia = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine(carros[i].Classificar());
        }



            

        }

    }
}