using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, year;
            double annualSales, quarterlySales, employeeCommission = 0.0;

            Console.WriteLine("Insira o nome do funcionário: ");
            name = Console.ReadLine();
            Console.WriteLine("Insira o ano: ");
            year = Console.ReadLine();
            Console.WriteLine("Insira o número de vendas deste ano: ");
            annualSales = Convert.ToDouble(Console.ReadLine());

            quarterlySales = annualSales / 4;

            Console.WriteLine();
            Console.WriteLine("Dados Informados: ");
            Console.WriteLine("Nome do Funcionário: " + name);
            Console.WriteLine("Ano Informado: " + year);
            Console.WriteLine("Vendas Anuais do Ano Informado: " + annualSales);
            Console.WriteLine("Vendas por Trimestre do Ano Informado: " + quarterlySales);

            if (quarterlySales <= 5000)
            {
                employeeCommission = quarterlySales / 0.1;
                Console.WriteLine("Comissão do Funcionário " + name + ": " + employeeCommission);
            }
            else if (quarterlySales <= 10000)
            {
                employeeCommission = quarterlySales / 0.5;
                Console.WriteLine("Comissão do Funcionário " + name + ": " + employeeCommission);
            }
            else if (quarterlySales <= 20000)
            {
                employeeCommission = quarterlySales / 0.8;
                Console.WriteLine("Comissão do Funcionário " + name + ": " + employeeCommission);
            }
            else if (quarterlySales > 20000)
            {
                employeeCommission = quarterlySales / 0.10;
                Console.WriteLine("Comissão do Funcionário " + name + ": " + employeeCommission);
            }

            Console.ReadKey();
        }
    }
}
