using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bas3;
            double h;

            Console.Write("Digite a altura do seu Retangulo:");
            h = double.Parse(Console.ReadLine());

            Console.Write("Digite a Base do seu Retangulo:");
            bas3 = double.Parse(Console.ReadLine());

            double area = bas3 * h;

            if (area >= 100)
            {
                Console.WriteLine("Terreno Muito Grande!!");
            }

            else
            {
                Console.WriteLine("A area é {0}", area);
            }
        }
    }
}
