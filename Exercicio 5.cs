using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercícios 5
            //Nome:Lucas Luna de Queiroz; Matricula: 8139081; Turma:01AM
            double[] a = new double[10];
            double x;
            double[] m = new double[10];
            Console.WriteLine("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine());   
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite o numero " + (i+1) + ":");
                a[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i < m.Length; i++)
            {
                m[i] = a[i]*x;
                Console.WriteLine(m[i]);
            }


        }
    }
}
