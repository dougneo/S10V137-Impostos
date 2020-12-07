using System;
using System.Collections.Generic;
using S10V137_Impostos.Entities;
using System.Globalization;

namespace S10V137_Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> list = new List<Contribuinte>();

            for(int i =1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (f/j)? ");
                char fj = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(fj == 'f')
                {
                    Console.Write("Gastos medicos: ");
                    double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, rendaAnual, gastosMedicos));
                }
                else
                {
                    Console.Write("Numero de Funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, rendaAnual, funcionarios));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXAS PAGAS");

            foreach(Contribuinte cont in list)
            {
                Console.WriteLine(cont);
            }

            Console.WriteLine();
            double sum = 0.0;
            foreach(Contribuinte cont1 in list)
            {
                sum = sum + cont1.Imposto();
            }
            Console.Write("Total de Taxas: $"+sum.ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
