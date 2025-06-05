using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da P1: ");
            double p1 = double.Parse(Console.ReadLine());

            double p2 = (15 - p1) / 2;

            if (p2 > 10)
            {
                Console.WriteLine($"Infelizmente, mesmo com 10 na P2, a média não alcança 5. Você está reprovado.");
            }
            else if (p2 < 0)
            {
                Console.WriteLine($"Com essa nota na P1, você já está aprovado! Nem precisa fazer a P2.");
            }
            else
            {
                Console.WriteLine($"Você precisa tirar {p2:F2} na P2 para ser aprovado com média 5.");
            }
        }
    }
}
