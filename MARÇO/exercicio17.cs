using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, mes, dia, idadef;

            Console.WriteLine("digite a quantidade de dias que você viveu");
            dia = int.Parse(Console.ReadLine());


            ano = (dia / 365);
            mes = (dia % 365) / 30;
            idadef = (dia % 365) % 30;



         

            Console.WriteLine("vc viveu {0} anos ,{1} meses e {2} dias",ano,mes,idadef);

            Console.ReadKey();
        }
    }
}
