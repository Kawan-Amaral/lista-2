using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1;
            double n2;
            double n3;

            Console.Write("Digite o Primeiro Numero:");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Numero:");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro Numero:");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior numero é {0}.", n1);

            }

            if (n2 > n3 && n2 > n1)
            {
                Console.WriteLine("O maior numero é {0}", n2);
            }

            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("O maior numero é {0}", n3);
            }
        }
    }
}
