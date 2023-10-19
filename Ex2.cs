using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[21];
            int Me = 100, Ma = 1;
            
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Digite o {0}º valor",i);
                x[i] = Convert.ToInt32(Console.ReadLine());
               
                if(x[i] < Me)
                {
                    Me = x[i];
                }
                if(x[i] > Ma)
                {
                    Ma = x[i];
                }
            }
            Console.WriteLine("O maior número foi: " + Ma + " e o menor foi: " + Me);
            Console.ReadKey();
        }
    }
}