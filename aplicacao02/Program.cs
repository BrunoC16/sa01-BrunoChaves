using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar a variáveis - Idade do Primeiro Avião da Embrae
            DateTime data1, data2;
            TimeSpan result;

            //Entrada de dados
            data1 = DateTime.Parse("22/10/1968");
            data2 = DateTime.Parse("25/01/2023");
           
            //Processamento de dados
            result = data2 - data1;

            //Saída de dados
            Console.WriteLine($"Atualmente o primeiro avião tem {result.Days / 30 / 12} anos");
            Console.WriteLine($"Contando os dias, são o total de: {result.Days} dias");
            Console.WriteLine("Seu primeiro voo foram com 2 ou 3 tripulantes");
            Console.WriteLine("Atualmente existem 320 unidades ativas em voo");
            Console.WriteLine("Atualmente o avião Phenom 300E custa 11,7 milhões de dólares ou aproximadamente 60 milhões de reais ");

            // Console.WriteLine ($"Contando os semanas, são o total de: {result.Days / 3.6 /2 } semanas");

            //Parar a tela 
            Console.ReadKey();


        }
    }
}
