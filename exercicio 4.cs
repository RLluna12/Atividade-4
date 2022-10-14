using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] numeros = new uint[10];
            uint menor = 0, posicao_menor = 0;

            Console.WriteLine("Informe 10 números inteiros:");

            for (uint i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = uint.Parse(Console.ReadLine());

                if (i == 0)
                {
                    menor = numeros[0];
                }
                else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicao_menor = i;
                }

            }
            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("A posição do menor número é:" + posicao_menor);
        }
    }
}
