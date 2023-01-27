using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2 = 0;
            int resultado = 0;

            Console.WriteLine(" Digite a quantidades de aviões tem : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidades de assentos que existem em cada avião: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 * n2;
            Console.WriteLine("O total de assentos é: {0}", resultado);

            Console.ReadKey();

        }
    }
}
