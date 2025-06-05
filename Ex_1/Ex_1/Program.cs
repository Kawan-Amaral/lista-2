using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1;
            double n2;

            Console.Write("Digite o primeiro numero:");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo numero:");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O maior numero é {0}.", n1);

            }

            if (n1 < n2)
            {
                Console.WriteLine("O maior numero é {0}", n2);
            }
        }
    }
}
