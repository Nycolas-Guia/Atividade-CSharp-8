using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3real
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = new string[10];
            int i;
            string y;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o {0}º nome.", i + 1);
                x[i] = Console.ReadLine();
                x[i] = x[i].ToLower();
                Console.Clear();
            }

            tente:
            Console.WriteLine("Digite o nome a ser procurado");
            y = Console.ReadLine();
            y = y.ToLower();

            for (i = 0; i < 10; i++)
            {
                if (y == x[i])
                {
                    Console.WriteLine("ACHEI");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("NÃO ACHEI");
                    Console.ReadKey();
                    Console.Clear();
                    goto tente;
                }
            }
        }
    }
}