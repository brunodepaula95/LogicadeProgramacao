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
          string[] nomes = new string[] { "Maria", "José", "Marcos", "Pedro", "Jubileu"};

          foreach(string nome in nomes)
          {
                Console.WriteLine(nome);
          }

        }
    }
}