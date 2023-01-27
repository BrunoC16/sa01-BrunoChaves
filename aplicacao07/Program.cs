using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis - Soma das peças para aviões
            int pecaA1;
            int pecaA2;
            int pecaA3;
            int pecaA4;
            int pecaA5;
            int totalPecas;
            
            //Entrada de dados
            Console.WriteLine("Digite o valor da 1º peça: ");
            pecaA1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da 2º peça: ");
            pecaA2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da 3º peça: ");
            pecaA3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da 4º peça: ");
            pecaA4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da 5º peça: ");
            pecaA5 = int.Parse(Console.ReadLine());
            
            //Processamento de dados
            totalPecas = pecaA1 + pecaA2 + pecaA3 + pecaA4 + pecaA5;

            //Saída de dados
            Console.WriteLine(totalPecas);
            Console.WriteLine("O valor total das peças solicitadas são de R$: " + totalPecas); 
            
            //Parar terla
            Console.ReadLine();



        }
    }
}
