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
            int tempo = 500;
            int oitava = 2;
            int DO = 264 * oitava;
            int RE = 297 * oitava;
            int MI = 330 * oitava;
            int FA = 352 * oitava;
            int SOL = 396 * oitava;
            int LA = 440 * oitava;
            int SI = 495 * oitava;

            int DO2 = DO * 2;
            int RE2 = RE * 2;
            int MI2 = MI * 2;
            int FA2 = FA * 2;
            int SOL2 = SOL * 2;
            int LA2 = LA * 2;
            int SI2 = SI * 2;


            Console.Beep(SOL, tempo / 2);
            Console.Beep(SOL, tempo / 2);
            Console.Beep(LA, tempo);
            Console.Beep(SOL, tempo);
            Console.Beep(DO2, tempo);
            Console.Beep(SI, tempo * 2);

            Console.Beep(SOL, tempo / 2);
            Console.Beep(SOL, tempo / 2);
            Console.Beep(LA, tempo);
            Console.Beep(SOL, tempo);
            Console.Beep(RE2, tempo);
            Console.Beep(DO2, tempo * 2);

            Console.Beep(MI2, tempo / 2);
            Console.Beep(MI2, tempo / 2);
            Console.Beep(SOL2, tempo);
            Console.Beep(MI2, tempo);
            Console.Beep(DO2, tempo);
            Console.Beep(SI, tempo);
            Console.Beep(LA, tempo);

            Console.Beep(FA2, tempo / 2);
            Console.Beep(FA2, tempo / 2);
            Console.Beep(MI2, tempo);
            Console.Beep(DO2, tempo);
            Console.Beep(RE2, tempo);
            Console.Beep(DO2, tempo * 2);
            Console.Beep(SOL, tempo);
            Console.Beep(MI, tempo);
            Console.Beep(DO, tempo);
            

            Console.Beep(DO, 250);
            Console.Beep(RE, 250);
            Console.Beep(MI, 500);
            Console.Beep(SOL, 500);
            Console.Beep(SOL, 500);
            Console.Beep(MI, 500);
            Console.Beep(FA, 1250);

            Console.Beep(DO, 250);
            Console.Beep(RE, 250);
            Console.Beep(MI, 500);
            Console.Beep(SOL, 500);
            Console.Beep(SOL, 500);
            Console.Beep(FA, 500);
            Console.Beep(MI, 500);

            Console.Beep(DO, 250);
            Console.Beep(RE, 250);
            Console.Beep(MI, 500);
            Console.Beep(SOL, 750);
            Console.Beep(SOL, 250);
            Console.Beep(FA, 250);
            Console.Beep(RE, 250);
            Console.Beep(DO, 500);

            Console.Beep(MI, 1000);
        }
    }
}
