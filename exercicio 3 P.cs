using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercícios 2
            //Nome:Lucas Luna de Queiroz; Matricula: 8139081; Turma:01AM
            uint[] numeros = new uint[10];
            uint  maior = 0, posicao_maior = 0;

            Console.WriteLine("Informe 10 números inteiros:");

            for (uint i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = uint.Parse(Console.ReadLine());

                if (i == 0)
                { 
                    maior = numeros[0];
                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao_maior = i;
                }

            }
            Console.WriteLine("O maior número é:" + maior);
            Console.WriteLine("A posição do maior número é:" + posicao_maior);
        }
    }
}
