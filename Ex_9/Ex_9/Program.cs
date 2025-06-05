using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o sexo (M ou F): ");
            string sexo = Console.ReadLine().ToUpper();

            double r = peso / (altura * altura);
            string mensagem;

            if (sexo == "F")
            {
                if (r < 19)
                    mensagem = "Abaixo do peso";
                else if (r < 24)
                    mensagem = "Peso ideal";
                else
                    mensagem = "Acima do peso";
            }
            else if (sexo == "M")
            {
                if (r < 20)
                    mensagem = "Abaixo do peso";
                else if (r < 25)
                    mensagem = "Peso ideal";
                else
                    mensagem = "Acima do peso";
            }
            else
            {
                mensagem = "Sexo inválido!";
            }

            Console.WriteLine("Resultado: {0}", mensagem);
        }
    }
}
