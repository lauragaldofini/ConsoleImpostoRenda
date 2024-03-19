using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImpostoRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a forma de contratação: (A) Assalariado, (C) Comissionado, (H) Horista");
            String contratacao = Console.ReadLine().ToUpper();

            switch (contratacao)
            {
                case "A":
                    Console.Write("Digite o salário bruto:");
                    double bruto = Console.ReadLine();

                    Console.WriteLine("digite o valor do desconto:");
                    double desconto = Console.ReadLine(); 


            }

        }
    }
}
