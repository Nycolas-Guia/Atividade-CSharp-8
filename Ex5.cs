using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o {0}º número", i + 1);
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Vamos organizar!");
            Array.Sort(x);
            Console.WriteLine("Em ordem crescente ficaria assim: ");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(x[i]);
                Thread.Sleep(250);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("E em ordem decrescente ficaria: ");
            for (int i = 14; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
                Thread.Sleep(250);
            }

            Console.ReadKey();

        }
    }
}