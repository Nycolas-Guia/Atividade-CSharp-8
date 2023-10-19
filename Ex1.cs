using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] x = new string[6];
            double[] n1 = new double[6], n2 = new double[6];
            int y;

            
            for (int i = 1; i <= 5; i++)
            {         
                Console.WriteLine("Digite o {0}º nome",i);
                x[i] = Console.ReadLine();
                Console.Clear();
            }
            
            Console.WriteLine("Digite as notas");
            for (int i = 1; i <= 5; i++)
            {
                notas:
                Console.WriteLine(x[i]);
                n1[i] = Convert.ToDouble(Console.ReadLine());
                n2[i] = Convert.ToDouble(Console.ReadLine());
               
                if(n1[i] > 10 || n1[i] < 0 || n2[i] > 10 || n2[i] < 0)
                {
                    Console.WriteLine("Nota inválida, tente novamente");
                    Console.ReadKey();
                    Console.Clear();
                    goto notas;
                }
                Console.Clear();
            }
            Qual:
            Console.WriteLine("Qual aluno deseja checar?\n1 - " + x[1] + "\n2 - " + x[2] + "\n3 - " + x[3] + "\n4 - " + x[4] +"\n5 - " + x[5]);
            y = Convert.ToInt32(Console.ReadLine());
            if(y > 5)
            {
                goto Qual;
            }

            Console.WriteLine("\nA primeira nota de " + x[y] + " é: " + n1[y] + " a segunda: " + n2[y] + " e sua média foi: " + (n1[y] + n2[y]) / 2);
            Console.ReadKey();

        }
    }
}