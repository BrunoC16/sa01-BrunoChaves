using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2 = 0;
            int resultado = 0;

            Console.Write("Digite o valor do primeiro avião R$: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo avião R$: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine("A soma do valores dos aviões são de R$: {0}", resultado);

            Console.ReadKey();

        }
    }
}
