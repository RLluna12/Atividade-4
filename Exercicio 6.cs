using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercícios 6
            //Nome:Lucas Luna de Queiroz; Matricula: 8139081; Turma:01AM
            int[] v = new int[10];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Inverso do q foi digitado: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[9-i]);
            }
        }
    }
}
