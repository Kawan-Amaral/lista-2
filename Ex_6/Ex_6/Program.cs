using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double r = peso / (altura * altura);

            Console.WriteLine($"Relação peso/altura²: {r:F2}");

            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (r < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
