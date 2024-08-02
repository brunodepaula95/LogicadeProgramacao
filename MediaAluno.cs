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

            double n1, n2, resultado;
            string avaliacao;

            Console.WriteLine("Digite a nota 1 do aluno:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 do aluno:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 + n2) / 2;

            if(resultado >= 6)
            {
                avaliacao = "Parabéns, você passou!";}
            else if (resultado >= 5)
            {
                avaliacao = "Eita! Você está de recuperação!";}
            else
            {
                avaliacao = "Você foi reprovado!";}

            Console.WriteLine("A média do aluno é:" + resultado " " + avaliacao);
        }
    }
}