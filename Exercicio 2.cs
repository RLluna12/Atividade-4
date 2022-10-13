using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercícios 2
            //Nome:Lucas Luna de Queiroz; Matricula: 8139081; Turma:01AM
            double[] v = new double[10];
            double media=0, am=0;
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("Digite sua nota");
                v[i] = double.Parse(Console.ReadLine());
                media += v[i];
            }
            media /= 10;
            Console.WriteLine(media);
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > media)
                {
                    am++;
                }
            }
            Console.WriteLine(am);
           
        }
    }
}
