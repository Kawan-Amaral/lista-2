using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da P1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da P2: ");
            double p2 = double.Parse(Console.ReadLine());

            double media = (p1 + 2 * p2) / 3;

            Console.WriteLine($"Média final: {media:F2}");

            if (media >= 5)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }
        }
    }
}
