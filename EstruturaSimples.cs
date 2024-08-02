using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
                Estrutura de decisão simples: Se-Então (if)
                Estrutura de decisão composta: Se-então-Senão (if-else)
            
            */

            int x, y;

            x = 2;
            y = 3;

            if (x == y)
            {
                Console.WriteLine("Os números são iguais");
            }

            else
            {
                Console.WriteLine("Os números são diferentes");
            }

        }
    }
}