using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao04
{
    internal class Program
    {
        static void Main(string[] args)

        {   //Declarar a variáveis - Divisão de pamentos para clientes
            decimal valor = 5000, Clientes = 10;

            //Entrada de dados
            //Processamento de dados
            Console.Write("Serão o valor de R$: ");
            
            //Saída de dados
            Console.Write( valor / Clientes);
            Console.Write("  por passageiro");

            //Parar a tela
            Console.ReadLine();
        }
    }
}
