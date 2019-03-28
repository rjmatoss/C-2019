using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano,mes,dia;       
            Console.WriteLine("digite sua idade");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o mês que você nasceu");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o dia que você nasceu");
            dia = int.Parse(Console.ReadLine());

            dia = dia + (ano * 365) + (mes * 30);

            Console.WriteLine("vc viveu {0} dias",dia);

            Console.ReadKey();
            


        }
    }
}
