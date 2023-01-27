using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aviao1;
            double aviao2;
            double aviao3;
            double aviao4;

            double quantAviao;

           
            double subtotal1;
            double subtotal2;
            double subtotal3;
            double subtotal4;

            double totalGeral;

            Console.WriteLine(" Informe o valor do 1º avião: ");
            aviao1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Quantos aviões  você deseja comprar do modelo do 1º avião? ");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal1 = aviao1 * quantAviao;
            
            Console.WriteLine(" Informe o valor do 2º avião: ");
            aviao2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Quantos aviões  você deseja comprar do modelo do 2º avião? ");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal2= aviao2 * quantAviao;


            Console.WriteLine(" Informe o valor do 3º avião: ");
            aviao3 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Quantos aviões  você deseja comprar do modelo do 3º avião? ");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal3= aviao3 * quantAviao;


            Console.WriteLine(" Informe o valor do 4º avião: ");
            aviao4 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Quantos aviões  você deseja comprar do modelo do 4º avião? ");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal4= aviao4 * quantAviao;


            totalGeral = subtotal1 + subtotal2 + subtotal3 + subtotal4;
            Console.WriteLine($"    O total será R$: {totalGeral}");

            Console.ReadKey();
        }
    }
}
