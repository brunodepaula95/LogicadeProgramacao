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
           string[,] nome = new string[3,3];

           for(int linha = 0; linha < 3; linha++)
           {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    nome[linha, coluna] = Console.ReadLine();
                }
           }

           Console.WriteLine();

           for(int linha = 0; linha < 3; linha++)
           {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(nome[linha, coluna] + " ");
                }
                Console.WriteLine();
           }
        }
    }
}