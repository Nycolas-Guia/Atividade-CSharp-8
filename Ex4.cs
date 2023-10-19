using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[20];
            int ma = 0, c = 0, i;

            for (i = 0; i < 20; i++)
            {
                pos:
                Console.WriteLine("Digite números positivos!");
                Console.WriteLine("Digite o {0}º número", i + 1);
                x[i] = Convert.ToInt32(Console.ReadLine());

                if (x[i] < 0)
                {
                    Console.WriteLine("Número inválido, tente novamente");
                    Console.ReadKey();
                    Console.Clear();
                    goto pos;
                }

                if (x[i] > ma)
                {
                    ma = x[i];
                    c = i;
                }
                    
                
                Console.Clear();
            }

            Console.WriteLine("O maior número foi {0} e ele foi o {1}º número digitado!", ma, c + 1);
            Console.ReadKey();
        }
    }
}