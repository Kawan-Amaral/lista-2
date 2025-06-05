using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro lado: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo lado: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro lado: ");
            double c = double.Parse(Console.ReadLine());

            
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.Write("Forma um triângulo: ");

                if (a == b && b == c)
                {
                    Console.WriteLine("Equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Isósceles");
                }
                else
                {
                    Console.WriteLine("Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo.");
            }
        }
    }
}
