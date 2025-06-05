using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            
            double[] lados = { a, b, c };
            Array.Sort(lados); 

            double cat1 = lados[0];
            double cat2 = lados[1];
            double hipo = lados[2];

            
            if (Math.Pow(hipo, 2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2))
            {
                Console.WriteLine("É um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Não é um triângulo retângulo.");
            }
        }
    }
}
